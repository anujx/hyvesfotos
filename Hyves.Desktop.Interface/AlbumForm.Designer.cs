namespace Hyves.Desktop.Interface
{
    partial class AlbumForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AlbumForm));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.ilAlbum = new System.Windows.Forms.ImageList(this.components);
            this.pnlAlbumMarginLeft = new System.Windows.Forms.Panel();
            this.pnlAlbumMarginTop = new System.Windows.Forms.Panel();
            this.pnlAlbumBottom = new System.Windows.Forms.Panel();
            this.lblDragFolder = new System.Windows.Forms.Label();
            this.pnlAlbumBottomBorder = new System.Windows.Forms.Panel();
            this.pnlMediaMargin = new System.Windows.Forms.Panel();
            this.pnlMediaBottom = new System.Windows.Forms.Panel();
            this.flpMediaBottom = new System.Windows.Forms.FlowLayoutPanel();
            this.lblDragPicture = new System.Windows.Forms.Label();
            this.lblSelectMedia = new System.Windows.Forms.LinkLabel();
            this.pnlMediaBottomBorder = new System.Windows.Forms.Panel();
            this.ilMedia = new System.Windows.Forms.ImageList(this.components);
            this.ilIcons = new System.Windows.Forms.ImageList(this.components);
            this.ofdMedia = new System.Windows.Forms.OpenFileDialog();
            this.fbdAlbum = new System.Windows.Forms.FolderBrowserDialog();
            this.pnlContainer = new System.Windows.Forms.Panel();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.pbLoading = new System.Windows.Forms.PictureBox();
            this.pnlHeader2 = new System.Windows.Forms.Panel();
            this.lblFeedback = new System.Windows.Forms.LinkLabel();
            this.pnlHyvesFotos = new System.Windows.Forms.Panel();
            this.pnlHeader1 = new System.Windows.Forms.Panel();
            this.lvAlbum = new Hyves.Desktop.Interface.AlwaysSelectedListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvMedia = new Hyves.Desktop.Interface.AlwaysSelectedListView();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.pnlAlbumBottom.SuspendLayout();
            this.pnlMediaBottom.SuspendLayout();
            this.flpMediaBottom.SuspendLayout();
            this.pnlContainer.SuspendLayout();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLoading)).BeginInit();
            this.pnlHeader2.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.splitContainer1, "splitContainer1");
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.lvAlbum);
            this.splitContainer1.Panel1.Controls.Add(this.pnlAlbumMarginLeft);
            this.splitContainer1.Panel1.Controls.Add(this.pnlAlbumMarginTop);
            this.splitContainer1.Panel1.Controls.Add(this.pnlAlbumBottom);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.lvMedia);
            this.splitContainer1.Panel2.Controls.Add(this.pnlMediaMargin);
            this.splitContainer1.Panel2.Controls.Add(this.pnlMediaBottom);
            this.splitContainer1.TabStop = false;
            // 
            // ilAlbum
            // 
            this.ilAlbum.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ilAlbum.ImageStream")));
            this.ilAlbum.TransparentColor = System.Drawing.Color.Transparent;
            this.ilAlbum.Images.SetKeyName(0, "hyves-uploader-folder-icon.png");
            // 
            // pnlAlbumMarginLeft
            // 
            this.pnlAlbumMarginLeft.BackColor = System.Drawing.SystemColors.Window;
            resources.ApplyResources(this.pnlAlbumMarginLeft, "pnlAlbumMarginLeft");
            this.pnlAlbumMarginLeft.Name = "pnlAlbumMarginLeft";
            // 
            // pnlAlbumMarginTop
            // 
            this.pnlAlbumMarginTop.BackColor = System.Drawing.SystemColors.Window;
            resources.ApplyResources(this.pnlAlbumMarginTop, "pnlAlbumMarginTop");
            this.pnlAlbumMarginTop.Name = "pnlAlbumMarginTop";
            // 
            // pnlAlbumBottom
            // 
            this.pnlAlbumBottom.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnlAlbumBottom.Controls.Add(this.lblDragFolder);
            this.pnlAlbumBottom.Controls.Add(this.pnlAlbumBottomBorder);
            resources.ApplyResources(this.pnlAlbumBottom, "pnlAlbumBottom");
            this.pnlAlbumBottom.Name = "pnlAlbumBottom";
            // 
            // lblDragFolder
            // 
            this.lblDragFolder.AllowDrop = true;
            this.lblDragFolder.BackColor = System.Drawing.SystemColors.ControlLightLight;
            resources.ApplyResources(this.lblDragFolder, "lblDragFolder");
            this.lblDragFolder.ForeColor = System.Drawing.Color.DarkGray;
            this.lblDragFolder.Name = "lblDragFolder";
            this.lblDragFolder.DragDrop += new System.Windows.Forms.DragEventHandler(this.lvAlbum_DragDrop);
            this.lblDragFolder.DragEnter += new System.Windows.Forms.DragEventHandler(this.lvAlbum_DragEnter);
            // 
            // pnlAlbumBottomBorder
            // 
            this.pnlAlbumBottomBorder.BackColor = System.Drawing.SystemColors.ControlDark;
            resources.ApplyResources(this.pnlAlbumBottomBorder, "pnlAlbumBottomBorder");
            this.pnlAlbumBottomBorder.Name = "pnlAlbumBottomBorder";
            // 
            // pnlMediaMargin
            // 
            this.pnlMediaMargin.BackColor = System.Drawing.SystemColors.Window;
            resources.ApplyResources(this.pnlMediaMargin, "pnlMediaMargin");
            this.pnlMediaMargin.Name = "pnlMediaMargin";
            // 
            // pnlMediaBottom
            // 
            this.pnlMediaBottom.AllowDrop = true;
            this.pnlMediaBottom.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pnlMediaBottom.Controls.Add(this.pbLoading);
            this.pnlMediaBottom.Controls.Add(this.flpMediaBottom);
            this.pnlMediaBottom.Controls.Add(this.pnlMediaBottomBorder);
            resources.ApplyResources(this.pnlMediaBottom, "pnlMediaBottom");
            this.pnlMediaBottom.Name = "pnlMediaBottom";
            this.pnlMediaBottom.DragDrop += new System.Windows.Forms.DragEventHandler(this.lvMedia_DragDrop);
            this.pnlMediaBottom.DragEnter += new System.Windows.Forms.DragEventHandler(this.lvMedia_DragEnter);
            // 
            // flpMediaBottom
            // 
            this.flpMediaBottom.BackColor = System.Drawing.Color.Transparent;
            this.flpMediaBottom.Controls.Add(this.lblDragPicture);
            this.flpMediaBottom.Controls.Add(this.lblSelectMedia);
            resources.ApplyResources(this.flpMediaBottom, "flpMediaBottom");
            this.flpMediaBottom.Name = "flpMediaBottom";
            // 
            // lblDragPicture
            // 
            resources.ApplyResources(this.lblDragPicture, "lblDragPicture");
            this.lblDragPicture.ForeColor = System.Drawing.Color.DarkGray;
            this.lblDragPicture.Name = "lblDragPicture";
            // 
            // lblSelectMedia
            // 
            resources.ApplyResources(this.lblSelectMedia, "lblSelectMedia");
            this.lblSelectMedia.Name = "lblSelectMedia";
            this.lblSelectMedia.TabStop = true;
            this.lblSelectMedia.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblSelectMedia_LinkClicked);
            // 
            // pnlMediaBottomBorder
            // 
            this.pnlMediaBottomBorder.BackColor = System.Drawing.SystemColors.ControlDark;
            resources.ApplyResources(this.pnlMediaBottomBorder, "pnlMediaBottomBorder");
            this.pnlMediaBottomBorder.Name = "pnlMediaBottomBorder";
            // 
            // ilMedia
            // 
            this.ilMedia.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            resources.ApplyResources(this.ilMedia, "ilMedia");
            this.ilMedia.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // ilIcons
            // 
            this.ilIcons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ilIcons.ImageStream")));
            this.ilIcons.TransparentColor = System.Drawing.Color.Transparent;
            this.ilIcons.Images.SetKeyName(0, "Folder-New-icon.png");
            this.ilIcons.Images.SetKeyName(1, "down-icon.png");
            this.ilIcons.Images.SetKeyName(2, "Key-icon.png");
            // 
            // ofdMedia
            // 
            this.ofdMedia.Multiselect = true;
            resources.ApplyResources(this.ofdMedia, "ofdMedia");
            // 
            // fbdAlbum
            // 
            this.fbdAlbum.ShowNewFolderButton = false;
            // 
            // pnlContainer
            // 
            this.pnlContainer.Controls.Add(this.splitContainer1);
            this.pnlContainer.Controls.Add(this.pnlTop);
            resources.ApplyResources(this.pnlContainer, "pnlContainer");
            this.pnlContainer.Name = "pnlContainer";
            // 
            // pnlTop
            // 
            this.pnlTop.Controls.Add(this.pnlHeader2);
            this.pnlTop.Controls.Add(this.pnlHyvesFotos);
            this.pnlTop.Controls.Add(this.pnlHeader1);
            resources.ApplyResources(this.pnlTop, "pnlTop");
            this.pnlTop.Name = "pnlTop";
            // 
            // pbLoading
            // 
            resources.ApplyResources(this.pbLoading, "pbLoading");
            this.pbLoading.BackColor = System.Drawing.Color.Transparent;
            this.pbLoading.Name = "pbLoading";
            this.pbLoading.TabStop = false;
            // 
            // pnlHeader2
            // 
            resources.ApplyResources(this.pnlHeader2, "pnlHeader2");
            this.pnlHeader2.Controls.Add(this.lblFeedback);
            this.pnlHeader2.Name = "pnlHeader2";
            // 
            // lblFeedback
            // 
            resources.ApplyResources(this.lblFeedback, "lblFeedback");
            this.lblFeedback.BackColor = System.Drawing.Color.Transparent;
            this.lblFeedback.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblFeedback.LinkColor = System.Drawing.Color.SteelBlue;
            this.lblFeedback.Name = "lblFeedback";
            this.lblFeedback.TabStop = true;
            this.lblFeedback.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblFeedback_LinkClicked);
            // 
            // pnlHyvesFotos
            // 
            this.pnlHyvesFotos.BackgroundImage = global::Hyves.Desktop.Interface.Properties.Resources.header_left;
            resources.ApplyResources(this.pnlHyvesFotos, "pnlHyvesFotos");
            this.pnlHyvesFotos.Name = "pnlHyvesFotos";
            // 
            // pnlHeader1
            // 
            resources.ApplyResources(this.pnlHeader1, "pnlHeader1");
            this.pnlHeader1.Name = "pnlHeader1";
            // 
            // lvAlbum
            // 
            this.lvAlbum.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.lvAlbum.AllowDrop = true;
            this.lvAlbum.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvAlbum.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            resources.ApplyResources(this.lvAlbum, "lvAlbum");
            this.lvAlbum.LargeImageList = this.ilAlbum;
            this.lvAlbum.MultiSelect = false;
            this.lvAlbum.Name = "lvAlbum";
            this.lvAlbum.Processing = false;
            this.lvAlbum.ShowGroups = false;
            this.lvAlbum.UseCompatibleStateImageBehavior = false;
            this.lvAlbum.View = System.Windows.Forms.View.Tile;
            this.lvAlbum.ItemActivate += new System.EventHandler(this.lvAlbum_ItemActivate);
            this.lvAlbum.DragDrop += new System.Windows.Forms.DragEventHandler(this.lvAlbum_DragDrop);
            this.lvAlbum.DragEnter += new System.Windows.Forms.DragEventHandler(this.lvAlbum_DragEnter);
            this.lvAlbum.DragLeave += new System.EventHandler(this.lvAlbum_DragLeave);
            // 
            // columnHeader1
            // 
            resources.ApplyResources(this.columnHeader1, "columnHeader1");
            // 
            // columnHeader2
            // 
            resources.ApplyResources(this.columnHeader2, "columnHeader2");
            // 
            // lvMedia
            // 
            this.lvMedia.AllowDrop = true;
            this.lvMedia.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.lvMedia, "lvMedia");
            this.lvMedia.MultiSelect = false;
            this.lvMedia.Name = "lvMedia";
            this.lvMedia.Processing = false;
            this.lvMedia.ShowGroups = false;
            this.lvMedia.UseCompatibleStateImageBehavior = false;
            this.lvMedia.ItemActivate += new System.EventHandler(this.lvMedia_ItemActivate);
            this.lvMedia.DragDrop += new System.Windows.Forms.DragEventHandler(this.lvMedia_DragDrop);
            this.lvMedia.DragEnter += new System.Windows.Forms.DragEventHandler(this.lvMedia_DragEnter);
            this.lvMedia.DragLeave += new System.EventHandler(this.lvMedia_DragLeave);
            // 
            // AlbumForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlContainer);
            this.Name = "AlbumForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AlbumForm_FormClosed);
            this.Load += new System.EventHandler(this.ShowAlbums_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.pnlAlbumBottom.ResumeLayout(false);
            this.pnlMediaBottom.ResumeLayout(false);
            this.flpMediaBottom.ResumeLayout(false);
            this.flpMediaBottom.PerformLayout();
            this.pnlContainer.ResumeLayout(false);
            this.pnlTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbLoading)).EndInit();
            this.pnlHeader2.ResumeLayout(false);
            this.pnlHeader2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ImageList ilAlbum;
        private System.Windows.Forms.ImageList ilMedia;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ImageList ilIcons;
        private System.Windows.Forms.Panel pnlAlbumBottom;
        private System.Windows.Forms.OpenFileDialog ofdMedia;
        private System.Windows.Forms.FolderBrowserDialog fbdAlbum;
        private AlwaysSelectedListView lvAlbum;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Panel pnlContainer;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Panel pnlHeader2;
        private System.Windows.Forms.Panel pnlHeader1;
        private System.Windows.Forms.Panel pnlMediaMargin;
        private System.Windows.Forms.Label lblDragFolder;
        private System.Windows.Forms.LinkLabel lblSelectMedia;
        private System.Windows.Forms.Label lblDragPicture;
        private System.Windows.Forms.Panel pnlAlbumBottomBorder;
        private System.Windows.Forms.Panel pnlAlbumMarginTop;
        private System.Windows.Forms.Panel pnlAlbumMarginLeft;
        private System.Windows.Forms.Panel pnlHyvesFotos;
        private System.Windows.Forms.LinkLabel lblFeedback;
        private System.Windows.Forms.Panel pnlMediaBottom;
        private System.Windows.Forms.FlowLayoutPanel flpMediaBottom;
        private System.Windows.Forms.Panel pnlMediaBottomBorder;
        private AlwaysSelectedListView lvMedia;
        private System.Windows.Forms.PictureBox pbLoading;
    }
}