using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Hyves.Api;
using Hyves.Api.Service;
using Hyves.Api.Model;
using System.Diagnostics;
using System.Net;
using System.IO;
using System.Runtime.InteropServices;

namespace Hyves.Desktop.Interface
{
    public partial class AlbumForm : Form
    {
        private bool isLoading = false;
        private UploadProgress uploadProgress = new UploadProgress();
        private delegate void UpdateProgressDelegate(int percent);
        private DirectoryInfo uploadDirectory;
        private delegate void UploadFilesDelegate(string[] files);


        [DllImport("uxtheme.dll", CharSet = CharSet.Unicode)]
        public static extern int SetWindowTheme(IntPtr hWnd, String pszSubAppName, String pszSubIdList);

        public AlbumForm()
        {
            InitializeComponent();
            AlbumForm.SetWindowTheme(lvAlbum.Handle, "explorer", null);
            AlbumForm.SetWindowTheme(lvMedia.Handle, "explorer", null);
            

            // Localization
            lblFeedback.Text = Util.LocalizedText("GiveFeedback");
            lblDragFolder.Text = Util.LocalizedText("DragFolder");
            lblDragPicture.Text = Util.LocalizedText("DragPicture");
            lblSelectMedia.Text = Util.LocalizedText("ChooseFile");
        }
        private void ShowAlbums_Load(object sender, EventArgs e)
        {
            HyvesApplication hyvesApplication = HyvesApplication.GetInstance();
            MediaService.AlbumsGetByUser(hyvesApplication.UserId, (HyvesServicesCallback<List<Album>>)delegate(ServiceResult<List<Album>> serviceResult)
            {
                HyvesServicesCallback<List<Album>> callback = new HyvesServicesCallback<List<Album>>(UpdateAlbumListView);
                this.BeginInvoke(callback, serviceResult);

            });
            Loading();
            lvMedia.LargeImageList = ilMedia;
        }


        private void Loading() 
        {
            this.pbLoading.Visible = true;
            this.Cursor = Cursors.WaitCursor;
            this.isLoading = true;
            ((AlwaysSelectedListView)lvAlbum).Processing = true;
        }

        private void LoadingCompleted() 
        {
            this.pbLoading.Visible = false;
            this.Cursor = Cursors.Default;
            this.isLoading = false;
            ((AlwaysSelectedListView)lvAlbum).Processing = false;
        
        } 
        private void UpdateAlbumListView(ServiceResult<List<Album>> serviceResult)
        {
            // Adding Albums to List View
            lvAlbum.SuspendLayout();
            foreach (Album album in serviceResult.Result)
            {
                AddAlbumInListView(album);
            }
            lvAlbum.ResumeLayout();
            ShowMedia(serviceResult.Result[0]);
        }

        private void AddAlbumInListView(Album album)
        {
            ListViewItem listViewItem = new ListViewItem();
            UpdateAlbumInListView(listViewItem, album);
            lvAlbum.Items.Add(listViewItem);
        }

        private void UpdateAlbumInListView(ListViewItem listViewItem, Album album)
        {
            listViewItem.Text = string.Format(album.title);
            if (listViewItem.SubItems.Count == 1)
            {
                listViewItem.SubItems.Add(string.Format("{0}, {1} photos", VisibilityHelper.GetVisibilityText(album.visibility), album.mediacount.ToString()));
            }
            else
            {
                listViewItem.SubItems[1].Text = string.Format("{0}, {1} photos", VisibilityHelper.GetVisibilityText(album.visibility), album.mediacount.ToString());
            }
            listViewItem.ImageIndex = 0;
            listViewItem.Tag = album;
        }

        private void ShowMedia(Album album)
        {
            MediaService.MediaGetByAlbum(album.albumid, (HyvesServicesCallback<List<Media>>)delegate(ServiceResult<List<Media>> serviceResult)
            {
                HyvesServicesCallback<List<Media>> updateMedia = new HyvesServicesCallback<List<Media>>(UpdateMedia);
                foreach (Media media in serviceResult.Result)
                {
                    media.square_extralarge.image = Hyves.Api.Util.GetImageFromUrl(media.square_extralarge.src);
                }
                this.BeginInvoke(updateMedia, serviceResult);
            });

            Loading();
            // Updating selection
            lvMedia.Tag = album;
            for (int index = 0; index < lvAlbum.Items.Count; index++)
            {
                lvAlbum.Items[index].Selected = ((Album)lvAlbum.Items[index].Tag).albumid == album.albumid ? true : false;
            }
        }
        private void UpdateMedia(ServiceResult<List<Media>> serviceResult)
        {
            // Adding Albums to List View
            lvMedia.SuspendLayout();
            lvMedia.Items.Clear();
            foreach (Media media in serviceResult.Result)
            {
                if (!ilMedia.Images.ContainsKey(media.mediaid))
                {
                    ilMedia.Images.Add(media.mediaid, media.square_extralarge.image);
                }

                ListViewItem listViewItem = new ListViewItem(media.title);
                listViewItem.Tag = media;
                listViewItem.ImageKey = media.mediaid;
                lvMedia.Items.Add(listViewItem);
            }
            lvMedia.ResumeLayout();
            LoadingCompleted();
            lvMedia.Focus();
        }
        private void lvMedia_ItemActivate(object sender, EventArgs e)
        {
            ListViewItem listViewItem = ((ListView)sender).SelectedItems[0];
            Media media = (Media)listViewItem.Tag;
            Process.Start(media.url);
        }
        private void HyvesBatchUploadCallback(ServiceResult<HyvesBatchUploadRequest> serviceResult)
        {
            this.Invoke((UpdateProgressDelegate)delegate(int p)
            {
                uploadProgress.Hide();
                uploadProgress.Close();

                // Checking if there was error in uploading one of the media, if yes then showing
                bool isError = false;
                foreach (KeyValuePair<HyvesUploadRequest, bool> status in serviceResult.Result.HyvesUploadRequestList)
                {
                    if (status.Key.ServiceResult.IsError) 
                    {
                        isError = true;
                        break;
                    }
                }
                if (isError) 
                {
                    UploadErrorForm uploadErrorForm = new UploadErrorForm(serviceResult.Result.HyvesUploadRequestList);
                    uploadErrorForm.ShowDialog();
                }

                lvMedia.Tag = serviceResult.Result.Album;
                foreach (ListViewItem item in lvAlbum.Items)
                {
                    if (((Album)item.Tag).albumid == serviceResult.Result.Album.albumid)
                    {
                        UpdateAlbumInListView(item, serviceResult.Result.Album);
                        break;
                    }
                }
                this.ShowMedia((Album)lvMedia.Tag);

                // Lets show faces :)
                List<Media> mediaWithFaces = new List<Media>();
                foreach (KeyValuePair<HyvesUploadRequest, bool> status in serviceResult.Result.HyvesUploadRequestList)
                {
                    if (!status.Key.ServiceResult.IsError && status.Key.ServiceResult.Result.HyvesUploadRequest.Media.Faces[0].Length > 0)
                    {
                        mediaWithFaces.Add(status.Key.ServiceResult.Result.HyvesUploadRequest.Media);
                    }
                }
                if (mediaWithFaces.Count > 0) 
                {
                    FaceForm faceForm = new FaceForm(mediaWithFaces);
                    faceForm.ShowDialog();
                }

            }, 100);
        }
        private void lblCreateAlbum_Click(object sender, EventArgs e)
        {
            CreateAlbum createAlbum = new CreateAlbum();
            createAlbum.AlbumName = "";
            if (createAlbum.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                MediaService.AlbumsCreate(createAlbum.AlbumName, createAlbum.Visibility, (HyvesServicesCallback<Album>)delegate(ServiceResult<Album> serviceResult)
                {
                    // Adding Dir to control;
                    this.Invoke((HyvesServicesCallback<Album>)delegate(ServiceResult<Album> result)
                    {
                        AddAlbumInListView(result.Result);
                        lvMedia.Items.Clear();
                        lvMedia.Tag = result.Result;
                        for (int index = 0; index < lvAlbum.Items.Count; index++)
                        {
                            lvAlbum.Items[index].Selected = ((Album)lvAlbum.Items[index].Tag).albumid == result.Result.albumid ? true : false;
                        }
                    }, serviceResult);
                });
            }
        }

        private void lvMedia_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            this.BeginInvoke(new UploadFilesDelegate(OnUploadFiles), (object)files);
        }

        private void OnUploadFiles(string[] files)
        {
            lvMedia.BackColor = SystemColors.Window;
            Album album = (Album)lvMedia.Tag;
            HyvesBatchUploadRequest hyvesBatchUploadRequest = MediaService.UploadFiles(new List<string>(files), album, new HyvesServicesCallback<HyvesBatchUploadRequest>(HyvesBatchUploadCallback));
            hyvesBatchUploadRequest.OnBatchUploadProgressChanged += new HyvesServicesCallback<int>(hyvesBatchUploadRequest_OnBatchUploadProgressChanged);
            uploadProgress.Completed = 0;
            uploadProgress.Total = files.Length;
            uploadProgress.ShowDialog();
        }

        void hyvesBatchUploadRequest_OnBatchUploadProgressChanged(ServiceResult<int> serviceResult)
        {
            this.Invoke((UpdateProgressDelegate)delegate(int p) { uploadProgress.Completed = p; }, serviceResult.Result);
        }

        private void CreateAlbumAndUploadImages(string directoryPath)
        {
            DirectoryInfo directoryInfo = new DirectoryInfo(directoryPath);
            if (directoryInfo.GetDirectories().Length > 0)
            {
                MessageBox.Show(Util.LocalizedText("AlbumVaildationFail"), "Hyves Fotos");
                return;
            }
            string albumName = directoryInfo.Name;
            CreateAlbum createAlbum = new CreateAlbum();
            createAlbum.AlbumName = albumName;
            if (createAlbum.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                // Creating Album
                this.uploadDirectory = directoryInfo;
                MediaService.AlbumsCreate(createAlbum.AlbumName, createAlbum.Visibility, new HyvesServicesCallback<Album>(AlbumCallback));
            }
        }

        public void AlbumCallback(ServiceResult<Album> serviceResult)
        {
            // Adding Dir to control;
            this.Invoke((HyvesServicesCallback<Album>)delegate(ServiceResult<Album> result) { AddAlbumInListView(result.Result); }, serviceResult);

            List<string> files = new List<string>();
            foreach (FileInfo file in this.uploadDirectory.GetFiles())
            {
                files.Add(file.FullName);
            }

            if (files.Count == 0)
            {
                return;
            }

            // uploading files
            this.Invoke((HyvesServicesCallback<Album>)delegate(ServiceResult<Album> result)
            {
                lvMedia.Tag = result.Result;
                HyvesBatchUploadRequest hyvesBatchUploadRequest = MediaService.UploadFiles(files, result.Result, new HyvesServicesCallback<HyvesBatchUploadRequest>(HyvesBatchUploadCallback));
                hyvesBatchUploadRequest.OnBatchUploadProgressChanged += new HyvesServicesCallback<int>(hyvesBatchUploadRequest_OnBatchUploadProgressChanged);
                uploadProgress.Completed = 0;
                uploadProgress.Total = files.Count;
                uploadProgress.ShowDialog();
            }, serviceResult);
        }

        private void lvMedia_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
                foreach (string file in files)
                {
                    if (!File.Exists(file))
                    {
                        e.Effect = DragDropEffects.None;
                        return;
                    }

                }
                e.Effect = DragDropEffects.Copy;
                lvMedia.BackColor = SystemColors.Info;
                return;
            }
            e.Effect = DragDropEffects.None;
        }



        private void lvAlbum_ItemActivate(object sender, EventArgs e)
        {
            if (isLoading) { return; }
            Loading();
            ListViewItem listViewItem = lvAlbum.SelectedItems[0];
            Album album = (Album)listViewItem.Tag;
            ShowMedia(album);
        }

        private void lvAlbum_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
                if (files.Length == 1)
                {
                    if (Directory.Exists(files[0]))
                    {
                        DirectoryInfo dir = new DirectoryInfo(files[0]);
                        if (dir.GetDirectories().Length == 0)
                        {
                            e.Effect = DragDropEffects.Copy;
                            lvAlbum.BackColor = SystemColors.Info;
                            return;
                        }
                    }
                }
            }
            e.Effect = DragDropEffects.None;
        }

        private void lvAlbum_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            lvAlbum.BackColor = SystemColors.Window;
            CreateAlbumAndUploadImages(files[0]);
        }

        private void lblSelectMedia_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (ofdMedia.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                Album album = (Album)lvMedia.Tag;
                HyvesBatchUploadRequest hyvesBatchUploadRequest = MediaService.UploadFiles(new List<string>(ofdMedia.FileNames), album, new HyvesServicesCallback<HyvesBatchUploadRequest>(HyvesBatchUploadCallback));
                hyvesBatchUploadRequest.OnBatchUploadProgressChanged += new HyvesServicesCallback<int>(hyvesBatchUploadRequest_OnBatchUploadProgressChanged);
                uploadProgress.Completed = 0;
                uploadProgress.Total = ofdMedia.FileNames.Length;
                Application.DoEvents();
                uploadProgress.ShowDialog();
            }
        }
        private void AlbumForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void lvAlbum_DragLeave(object sender, EventArgs e)
        {
            lvAlbum.BackColor = SystemColors.Window;
        }

        private void lvMedia_DragLeave(object sender, EventArgs e)
        {
            lvMedia.BackColor = SystemColors.Window;
        }

        private void lblFeedback_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(@"http://hyvesfotosuploader.hyves.nl/");
        }
    }
}
