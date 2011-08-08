using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Hyves.Api;
using System.Runtime.InteropServices;
using System.Threading;
using System.Diagnostics;
namespace Hyves.Desktop.Interface
{
    static class Program
    {
        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool SetForegroundWindow(IntPtr hWnd);
        [STAThread]
        static void Main()
        {
            bool createdNew = true;
            using (Mutex mutex = new Mutex(true, "HyvesFotos", out createdNew))
            {
                if (createdNew)
                {
                    StartApplication();
                }
                else
                {
                    Process current = Process.GetCurrentProcess();
                    foreach (Process process in Process.GetProcessesByName(current.ProcessName))
                    {
                        if (process.Id != current.Id)
                        {
                            SetForegroundWindow(process.MainWindowHandle);
                            break;
                        }
                    }
                }
            }
        }

        public static void StartApplication(){
            HyvesApplication hyvesApplication = HyvesApplication.GetInstance();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("nl-Nl");
            try
            {
                Hyves.Api.LoginForm loginForm = new Api.LoginForm();
                if (loginForm.ShowDialog() == DialogResult.OK) {
                    Application.Run(new AlbumForm());
                }   
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
