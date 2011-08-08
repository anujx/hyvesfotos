namespace Hyves.Desktop.Interface
{
    partial class FaceForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FaceForm));
            this.pnlPicture = new System.Windows.Forms.PictureBox();
            this.flpFaces = new System.Windows.Forms.FlowLayoutPanel();
            this.scFacesForm = new System.Windows.Forms.SplitContainer();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.pnlHeader2 = new System.Windows.Forms.Panel();
            this.pnlHeader1 = new System.Windows.Forms.Panel();
            this.pnlMediaBottom = new System.Windows.Forms.Panel();
            this.pbLoading = new System.Windows.Forms.PictureBox();
            this.pnlMediaBottomBorder = new System.Windows.Forms.Panel();
            this.pnlHyvesFotos = new System.Windows.Forms.Panel();
            this.btnSpot = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pnlPicture)).BeginInit();
            this.scFacesForm.Panel1.SuspendLayout();
            this.scFacesForm.Panel2.SuspendLayout();
            this.scFacesForm.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.pnlMediaBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLoading)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlPicture
            // 
            this.pnlPicture.BackColor = System.Drawing.SystemColors.Window;
            this.pnlPicture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPicture.Location = new System.Drawing.Point(0, 0);
            this.pnlPicture.Name = "pnlPicture";
            this.pnlPicture.Size = new System.Drawing.Size(626, 467);
            this.pnlPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pnlPicture.TabIndex = 0;
            this.pnlPicture.TabStop = false;
            // 
            // flpFaces
            // 
            this.flpFaces.AutoScroll = true;
            this.flpFaces.BackColor = System.Drawing.SystemColors.Window;
            this.flpFaces.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpFaces.Location = new System.Drawing.Point(0, 0);
            this.flpFaces.Name = "flpFaces";
            this.flpFaces.Size = new System.Drawing.Size(134, 467);
            this.flpFaces.TabIndex = 1;
            // 
            // scFacesForm
            // 
            this.scFacesForm.BackColor = System.Drawing.SystemColors.Control;
            this.scFacesForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scFacesForm.Location = new System.Drawing.Point(0, 41);
            this.scFacesForm.Name = "scFacesForm";
            // 
            // scFacesForm.Panel1
            // 
            this.scFacesForm.Panel1.Controls.Add(this.flpFaces);
            // 
            // scFacesForm.Panel2
            // 
            this.scFacesForm.Panel2.Controls.Add(this.pnlPicture);
            this.scFacesForm.Size = new System.Drawing.Size(764, 467);
            this.scFacesForm.SplitterDistance = 134;
            this.scFacesForm.TabIndex = 2;
            // 
            // pnlTop
            // 
            this.pnlTop.Controls.Add(this.pnlHeader2);
            this.pnlTop.Controls.Add(this.pnlHyvesFotos);
            this.pnlTop.Controls.Add(this.pnlHeader1);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(764, 41);
            this.pnlTop.TabIndex = 7;
            // 
            // pnlHeader2
            // 
            this.pnlHeader2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlHeader2.BackgroundImage")));
            this.pnlHeader2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlHeader2.Location = new System.Drawing.Point(99, 0);
            this.pnlHeader2.Name = "pnlHeader2";
            this.pnlHeader2.Size = new System.Drawing.Size(595, 41);
            this.pnlHeader2.TabIndex = 1;
            // 
            // pnlHeader1
            // 
            this.pnlHeader1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlHeader1.BackgroundImage")));
            this.pnlHeader1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnlHeader1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlHeader1.Location = new System.Drawing.Point(694, 0);
            this.pnlHeader1.Name = "pnlHeader1";
            this.pnlHeader1.Size = new System.Drawing.Size(70, 41);
            this.pnlHeader1.TabIndex = 0;
            // 
            // pnlMediaBottom
            // 
            this.pnlMediaBottom.AllowDrop = true;
            this.pnlMediaBottom.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pnlMediaBottom.Controls.Add(this.btnCancel);
            this.pnlMediaBottom.Controls.Add(this.btnSpot);
            this.pnlMediaBottom.Controls.Add(this.pbLoading);
            this.pnlMediaBottom.Controls.Add(this.pnlMediaBottomBorder);
            this.pnlMediaBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlMediaBottom.Location = new System.Drawing.Point(0, 508);
            this.pnlMediaBottom.Name = "pnlMediaBottom";
            this.pnlMediaBottom.Size = new System.Drawing.Size(764, 54);
            this.pnlMediaBottom.TabIndex = 8;
            // 
            // pbLoading
            // 
            this.pbLoading.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbLoading.BackColor = System.Drawing.Color.Transparent;
            this.pbLoading.Image = ((System.Drawing.Image)(resources.GetObject("pbLoading.Image")));
            this.pbLoading.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pbLoading.Location = new System.Drawing.Point(12, 10);
            this.pbLoading.Name = "pbLoading";
            this.pbLoading.Size = new System.Drawing.Size(36, 35);
            this.pbLoading.TabIndex = 6;
            this.pbLoading.TabStop = false;
            this.pbLoading.Visible = false;
            // 
            // pnlMediaBottomBorder
            // 
            this.pnlMediaBottomBorder.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pnlMediaBottomBorder.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMediaBottomBorder.Location = new System.Drawing.Point(0, 0);
            this.pnlMediaBottomBorder.Name = "pnlMediaBottomBorder";
            this.pnlMediaBottomBorder.Size = new System.Drawing.Size(764, 1);
            this.pnlMediaBottomBorder.TabIndex = 5;
            // 
            // pnlHyvesFotos
            // 
            this.pnlHyvesFotos.BackgroundImage = global::Hyves.Desktop.Interface.Properties.Resources.hyves_uploader_windows_header_left;
            this.pnlHyvesFotos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnlHyvesFotos.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlHyvesFotos.Location = new System.Drawing.Point(0, 0);
            this.pnlHyvesFotos.Name = "pnlHyvesFotos";
            this.pnlHyvesFotos.Size = new System.Drawing.Size(99, 41);
            this.pnlHyvesFotos.TabIndex = 4;
            // 
            // btnSpot
            // 
            this.btnSpot.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSpot.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSpot.Location = new System.Drawing.Point(677, 9);
            this.btnSpot.Name = "btnSpot";
            this.btnSpot.Size = new System.Drawing.Size(75, 36);
            this.btnSpot.TabIndex = 7;
            this.btnSpot.Text = "Spot";
            this.btnSpot.UseVisualStyleBackColor = true;
            this.btnSpot.Click += new System.EventHandler(this.btnSpot_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(596, 9);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 36);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // FaceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 562);
            this.Controls.Add(this.scFacesForm);
            this.Controls.Add(this.pnlMediaBottom);
            this.Controls.Add(this.pnlTop);
            this.Name = "FaceForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Spot your friends";
            this.Load += new System.EventHandler(this.Faces_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pnlPicture)).EndInit();
            this.scFacesForm.Panel1.ResumeLayout(false);
            this.scFacesForm.Panel2.ResumeLayout(false);
            this.scFacesForm.ResumeLayout(false);
            this.pnlTop.ResumeLayout(false);
            this.pnlMediaBottom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbLoading)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pnlPicture;
        private System.Windows.Forms.FlowLayoutPanel flpFaces;
        private System.Windows.Forms.SplitContainer scFacesForm;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Panel pnlHeader2;
        private System.Windows.Forms.Panel pnlHeader1;
        private System.Windows.Forms.Panel pnlMediaBottom;
        private System.Windows.Forms.PictureBox pbLoading;
        private System.Windows.Forms.Panel pnlMediaBottomBorder;
        private System.Windows.Forms.Panel pnlHyvesFotos;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSpot;
    }
}