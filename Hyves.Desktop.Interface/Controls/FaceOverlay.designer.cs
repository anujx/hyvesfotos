namespace Hyves.Desktop.Interface.Controls
{
    partial class FaceOverlay
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cboFriend = new System.Windows.Forms.ComboBox();
            this.pbFace = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbFace)).BeginInit();
            this.SuspendLayout();
            // 
            // cboFriend
            // 
            this.cboFriend.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboFriend.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cboFriend.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFriend.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboFriend.FormattingEnabled = true;
            this.cboFriend.Location = new System.Drawing.Point(0, 83);
            this.cboFriend.Name = "cboFriend";
            this.cboFriend.Size = new System.Drawing.Size(108, 24);
            this.cboFriend.TabIndex = 0;
            this.cboFriend.DropDown += new System.EventHandler(this.cboFriend_DropDown);
            this.cboFriend.Click += new System.EventHandler(this.cboFriend_Click);
            // 
            // pbFace
            // 
            this.pbFace.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbFace.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbFace.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbFace.Location = new System.Drawing.Point(0, 0);
            this.pbFace.Name = "pbFace";
            this.pbFace.Size = new System.Drawing.Size(108, 83);
            this.pbFace.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFace.TabIndex = 1;
            this.pbFace.TabStop = false;
            this.pbFace.Click += new System.EventHandler(this.pbFace_Click);
            // 
            // FaceOverlay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.pbFace);
            this.Controls.Add(this.cboFriend);
            this.Name = "FaceOverlay";
            this.Size = new System.Drawing.Size(108, 107);
            this.Load += new System.EventHandler(this.FaceOverlay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbFace)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cboFriend;
        private System.Windows.Forms.PictureBox pbFace;
    }
}
