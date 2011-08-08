using System;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;

namespace Hyves.Desktop.Interface
{
    public class AlwaysSelectedListView : ListView
    {
        public bool Processing { get; set; }
        public AlwaysSelectedListView()
        {
            //Activate double buffering
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.AllPaintingInWmPaint, true);

            //Enable the OnNotifyMessage event so we get a chance to filter out 
            // Windows messages before they get to the form's WndProc
            this.SetStyle(ControlStyles.EnableNotifyMessage, true);
            Processing = false;
        }

        protected override void OnNotifyMessage(Message m)
        {
            //Filter out the WM_ERASEBKGND message
            if (m.Msg != 0x14)
            {
                base.OnNotifyMessage(m);
            }
        }

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x201 || m.Msg == 0x203 || m.Msg == 0x204 || m.Msg == 0x206 )
            {
                if (Processing) { return; }
                // Trap WM_LBUTTONDOWN + WM_LBUTTONDBLCLK + WM_RBUTTONDOWN + WM_RBUTTONDBLCLK
                var pos = new Point(m.LParam.ToInt32() & 0xffff, m.LParam.ToInt32() >> 16);
                var loc = this.HitTest(pos);
                switch (loc.Location)
                {
                    case ListViewHitTestLocations.None:
                    case ListViewHitTestLocations.AboveClientArea:
                    case ListViewHitTestLocations.BelowClientArea:
                    case ListViewHitTestLocations.LeftOfClientArea:
                    case ListViewHitTestLocations.RightOfClientArea:
                        return;  // Don't let the native control see it
                }
            }
            base.WndProc(ref m);
        }
    }
}
