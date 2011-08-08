using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.Structure;
using System.Diagnostics;
using Hyves.Api.Model;
using System.Net;
using Hyves.Api.Service;
using Hyves.Desktop.Interface;
using Hyves.Desktop.Interface.Controls;
using Hyves.Api;

namespace Hyves.Desktop.Interface
{
    public partial class FaceForm : Form
    {
        private List<Media> mediaList;
        private List<User> userList;
        private object _lock = new object();

        public FaceForm(List<Media> mediaList)
        {
            this.mediaList = mediaList;
            InitializeComponent();
        }

        private void LoadFaces(List<Media> mediaList)
        {
            foreach (Media media in mediaList)
            {
                if (media.mediatype == "image")
                {
                    try
                    {
                        Image<Bgr, Byte> image = new Image<Bgr, byte>(new Bitmap(media.image.image)); //Read the files as an 8-bit Bgr image
                        foreach (MCvAvgComp f in media.Faces[0])
                        {
                            //draw the face detected in the 0th (gray) channel with blue color
                            Image<Bgr, Byte> cimage = image.Clone();
                            cimage.Draw(f.rect, new Bgr(Color.Blue), 1);
                            FaceOverlay face = new FaceOverlay();
                            face.Image = cropImage(cimage.ToBitmap(), f.rect);
                            face.OnClick += new OnClickDelegate(friend_OnClick);
                            face.Media = Util.Clone<Media>(media);
                            face.Tag = f;
                            face.Media.image.image = cimage.ToBitmap();
                            face.UserList = this.userList;
                            flpFaces.Controls.Add(face);
                        }
                        if (flpFaces.Controls.Count > 0)
                        {
                            friend_OnClick(((FaceOverlay)flpFaces.Controls[0]).Media);

                        }
                    }
                    catch (Exception ex) { 
                    
                    }
                }
            }
        }

        void friend_OnClick(Media media)
        {
            pnlPicture.Image = media.image.image;
        }

        private Image cropImage(Image img, Rectangle cropArea)
        {
            Bitmap bmpImage = new Bitmap(img);
            Bitmap bmpCrop = bmpImage.Clone(cropArea,
            bmpImage.PixelFormat);
            return (Image)(bmpCrop);
        }

        private void Faces_Load(object sender, EventArgs e)
        {
            pbLoading.Visible = true;
            HyvesApplication hyvesApplication = HyvesApplication.GetInstance();

             UserService.UsersGetByFriendsLastLogin(hyvesApplication.UserId,  (HyvesServicesCallback<List<User>>)delegate(ServiceResult<List<User>> serviceResult){
                HyvesServicesCallback<List<User>> callback = new HyvesServicesCallback<List<User>>(UpdateUserList);
                this.BeginInvoke(callback, serviceResult);
            });
        }

        private void UpdateUserList(ServiceResult<List<User>> serviceResult)
        {
            serviceResult.Result.Sort();
            // Adding loggedin user
            serviceResult.Result.Insert(0, new User(){firstname = "Me", userid =HyvesApplication.GetInstance().UserId});
            this.userList = serviceResult.Result;
            pbLoading.Visible = false;
            LoadFaces(this.mediaList);
        }

        private void btnSpot_Click(object sender, EventArgs e)
        {
            for( int index = 0; index < flpFaces.Controls.Count;) 
            {
                FaceOverlay face = (FaceOverlay)flpFaces.Controls[index];
                if (face.User.userid != String.Empty)
                {
                    MediaSpottedRectangle rectangle = new MediaSpottedRectangle();
                    rectangle.x = (65535 / face.Media.image.width) * ((MCvAvgComp)face.Tag).rect.Left;
                    rectangle.y = (65535 / face.Media.image.height) * ((MCvAvgComp)face.Tag).rect.Top;
                    rectangle.width = (65535 / face.Media.image.width) * ((MCvAvgComp)face.Tag).rect.Width;
                    rectangle.height = (65535 / face.Media.image.height) * ((MCvAvgComp)face.Tag).rect.Height;
                    MediaService.MediaAddSpotted(face.Media.mediaid, face.User.userid, rectangle, (HyvesServicesCallback<bool>) delegate(ServiceResult<bool> serviceResult){
                        this.BeginInvoke( new HyvesServicesCallback<bool>(SpottedAdded),serviceResult);
                    });
                    flpFaces.Controls.Remove(face);
                }
                else 
                {
                    index++;
                }
            }
        }

        private void SpottedAdded(ServiceResult<bool> serviceResult) 
        {
            lock (_lock) 
            {
                if (flpFaces.Controls.Count == 0) 
                {
                    this.Close();
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
