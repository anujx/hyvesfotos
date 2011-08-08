using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Hyves.Api;
using System.Diagnostics;
using Hyves.Api.Model;

namespace Hyves.Desktop.Interface
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            this.BackColor = Color.FromArgb(255, 229, 163);

            // Localization
            lblUsername.Text = Util.LocalizedText("HyvesUsername");
            lblPassword.Text = Util.LocalizedText("Password");
            lblForgetPassword.Text = Util.LocalizedText("ForgotPassword");

        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close();

        }

        private void LoginCallback(ServiceResult<bool> serviceResult)
        {
            HyvesServicesCallback<bool> loginCallbackDelegate = new HyvesServicesCallback<bool>(UpdateAfterLogin);
            Storage.Write(StorageData.HyvesApplication, HyvesApplication.GetInstance());
            this.BeginInvoke(loginCallbackDelegate, serviceResult);
        }

        private void UpdateAfterLogin(ServiceResult<bool> serviceResult)
        {
            this.Cursor = Cursors.Default;
            if (serviceResult.IsError)
            {
                MessageBox.Show(Util.LocalizedText("LoginFail"), "Hyves Fotos", MessageBoxButtons.OK);
                return;
            }
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            AlbumForm showAlbum = new AlbumForm();
            showAlbum.Show();
            this.Hide();
        }

        private void pnlLoginButton_MouseClick(object sender, MouseEventArgs e)
        {
            Login();
        }

        private void Login()
        {
            HyvesApplication hyvesApplication = HyvesApplication.GetInstance();
            hyvesApplication.LoginIn(txtUsername.Text, txtPassword.Text, new HyvesServicesCallback<bool>(LoginCallback));
            this.Cursor = Cursors.WaitCursor;
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Login();
                e.Handled = true;
            }
        }

        private void lblForgetPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(@"http://www.hyves.nl/wachtwoordvergeten/");
        }
    }
}
