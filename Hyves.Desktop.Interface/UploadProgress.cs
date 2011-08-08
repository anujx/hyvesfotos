using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Hyves.Desktop.Interface
{
    public partial class UploadProgress : Form
    {
        public UploadProgress()
        {
            InitializeComponent();
        }

        public int Completed 
        {
            set { pbUpload.Value = value;
            lblCompleted.Text = string.Format("Completed {0}/{1}", pbUpload.Value, pbUpload.Maximum);
            }
        }
        public int Total 
        {
            set { 
                pbUpload.Maximum = value;
                lblCompleted.Text = string.Format("Completed {0}/{1}", pbUpload.Value, pbUpload.Maximum);
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Util.LocalizedText("UploadCancel"), "Hyves Fotos");
        }
    }
}
