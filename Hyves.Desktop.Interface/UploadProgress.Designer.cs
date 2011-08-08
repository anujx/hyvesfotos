namespace Hyves.Desktop.Interface
{
    partial class UploadProgress
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UploadProgress));
            this.pbUpload = new System.Windows.Forms.ProgressBar();
            this.btnCancel = new System.Windows.Forms.Button();
            this.pbHyves = new System.Windows.Forms.PictureBox();
            this.pbCopying = new System.Windows.Forms.PictureBox();
            this.lblCompleted = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbHyves)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCopying)).BeginInit();
            this.SuspendLayout();
            // 
            // pbUpload
            // 
            this.pbUpload.Location = new System.Drawing.Point(12, 68);
            this.pbUpload.Name = "pbUpload";
            this.pbUpload.Size = new System.Drawing.Size(275, 20);
            this.pbUpload.TabIndex = 0;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(212, 93);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // pbHyves
            // 
            this.pbHyves.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pbHyves.Image = global::Hyves.Desktop.Interface.Properties.Resources.Hyves;
            this.pbHyves.Location = new System.Drawing.Point(243, 18);
            this.pbHyves.Name = "pbHyves";
            this.pbHyves.Size = new System.Drawing.Size(34, 36);
            this.pbHyves.TabIndex = 3;
            this.pbHyves.TabStop = false;
            // 
            // pbCopying
            // 
            this.pbCopying.Image = ((System.Drawing.Image)(resources.GetObject("pbCopying.Image")));
            this.pbCopying.Location = new System.Drawing.Point(12, -1);
            this.pbCopying.Name = "pbCopying";
            this.pbCopying.Size = new System.Drawing.Size(275, 63);
            this.pbCopying.TabIndex = 1;
            this.pbCopying.TabStop = false;
            // 
            // lblCompleted
            // 
            this.lblCompleted.AutoSize = true;
            this.lblCompleted.Location = new System.Drawing.Point(12, 98);
            this.lblCompleted.Name = "lblCompleted";
            this.lblCompleted.Size = new System.Drawing.Size(57, 13);
            this.lblCompleted.TabIndex = 4;
            this.lblCompleted.Text = "Completed";
            // 
            // UploadProgress
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(294, 122);
            this.ControlBox = false;
            this.Controls.Add(this.lblCompleted);
            this.Controls.Add(this.pbHyves);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.pbUpload);
            this.Controls.Add(this.pbCopying);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UploadProgress";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Uploading...";
            ((System.ComponentModel.ISupportInitialize)(this.pbHyves)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCopying)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar pbUpload;
        private System.Windows.Forms.PictureBox pbCopying;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.PictureBox pbHyves;
        private System.Windows.Forms.Label lblCompleted;
    }
}