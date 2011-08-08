using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Hyves.Api.Model;

namespace Hyves.Desktop.Interface.Controls
{
    public delegate void OnClickDelegate(Media media);
    public partial class FaceOverlay : UserControl
    {
        public List<User> UserList { get; set; }
        public User User { get { return (User)cboFriend.SelectedItem; } }

        public event OnClickDelegate OnClick;

        public Media Media { get; set; }
        public FaceOverlay()
        {
            InitializeComponent();
        }

        public Image Image
        {
            set { pbFace.Image = value; }
        }

        private void pbFace_Click(object sender, EventArgs e)
        {
            if (OnClick != null)
            {
                OnClick(Media);
            }
        }

        private void FaceOverlay_Load(object sender, EventArgs e)
        {
            cboFriend.SuspendLayout();
            cboFriend.Items.Add(new User() { userid = string.Empty, firstname = "Who is?" });
            foreach (User user in UserList)
            {
                cboFriend.Items.Add(user);
            }
            cboFriend.ResumeLayout();
            if (cboFriend.Items.Count > 0) { cboFriend.SelectedIndex = 0; }
        }

        private void cboFriend_DropDown(object sender, EventArgs e)
        {

            ComboBox senderComboBox = (ComboBox)sender;
            int width = senderComboBox.DropDownWidth;
            Graphics g = senderComboBox.CreateGraphics();
            Font font = senderComboBox.Font;
            int vertScrollBarWidth = (senderComboBox.Items.Count > senderComboBox.MaxDropDownItems) ? SystemInformation.VerticalScrollBarWidth : 0;
            int newWidth;
            foreach (User user in ((ComboBox)sender).Items)
            {
                string s = user.ToString();
                newWidth = (int)g.MeasureString(s, font).Width
                    + vertScrollBarWidth;
                if (width < newWidth)
                {
                    width = newWidth;
                }
            }
            senderComboBox.DropDownWidth = width;
        }

        private void cboFriend_Click(object sender, EventArgs e)
        {
            if (OnClick != null)
            {
                OnClick(Media);
            }
        }
    }
}
