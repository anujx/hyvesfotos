using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Hyves.Api.Model;
using Hyves.Api;

namespace Hyves.Desktop.Interface
{
    public partial class CreateAlbum : Form
    {
        public string AlbumName { get { return txtAlbumName.Text; } set { txtAlbumName.Text = value; } }
        public Visibility Visibility { get { return ((VisibilityItem)cboVisibility.SelectedItem).Visibility; } }

        public CreateAlbum()
        {
            InitializeComponent();
            List<int> visibilityList = EnumHelper.GetValues<Visibility, int>();
            VisibilityItem selectedVisibility = null;
            foreach (int visibility in visibilityList) 
            {
                 VisibilityItem  visibilityItem = new VisibilityItem((Visibility) visibility);
                cboVisibility.Items.Add(visibilityItem);
                if(((Visibility) visibility) == Visibility.Friend)
                {
                    selectedVisibility = visibilityItem;
                }
            }
            if (selectedVisibility != null)
            {
                cboVisibility.SelectedItem = selectedVisibility;
            }
        }
    }
}
