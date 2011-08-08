using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Hyves.Api;
using System.IO;

namespace Hyves.Desktop.Interface
{
    public partial class UploadErrorForm : Form
    {
        private Dictionary<HyvesUploadRequest, bool> hyvesUploadRequestList;
        public UploadErrorForm(Dictionary<HyvesUploadRequest, bool> hyvesUploadRequestList)
        {
            InitializeComponent();
            this.hyvesUploadRequestList = hyvesUploadRequestList;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UploadErrorForm_Load(object sender, EventArgs e)
        {
            grdError.SuspendLayout();
            foreach (KeyValuePair<HyvesUploadRequest, bool> hyvesUploadRequest in hyvesUploadRequestList)
            {
                if (hyvesUploadRequest.Key.ServiceResult.IsError)
                {
                    grdError.Rows.Add();
                    UpdateGrid(grdError.Rows[grdError.Rows.Count-1], hyvesUploadRequest.Key);
                }
            }
            grdError.ResumeLayout();
        }
        private void UpdateGrid(DataGridViewRow row, HyvesUploadRequest hyvesUploadRequest) 
        {

            ((DataGridViewImageCell)row.Cells["colStatus"]).Value = ilIcon.Images[0];
            row.Cells["colFileName"].Value = Path.GetFileName(hyvesUploadRequest.FilePath);
            row.Cells["colMessage"].Value = hyvesUploadRequest.ServiceResult.Message;
        }
    }
}
