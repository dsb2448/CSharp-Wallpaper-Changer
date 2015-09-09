using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Wallpaper_Changer
{   
    public class SysTrayApp : Form
    {
        // Import the user32.dll to allow the SystemParametersInfo function to change the desktop wallpaper
        [DllImport("user32.dll", EntryPoint = "SystemParametersInfo")]
        public static extern bool SystemParametersInfo(int uiAction, int uiParam, String pvParam, int fWinIni);

        // Parameters needed for the SystemParametersInfo function.
        const int SPI_SETDESKWALLPAPER = 20;
        const int SPIF_UPDATEINIFILE = 0x01;
        const int SPIF_SENDWININICHANGE = 0x02;

        /*
         * setting_items: List of setting_items to select from when changing the wallpaper.
         * trayIcon: The image to use on the system tray.
         * trayMenu: Creates a system tray menu.
         */

        private List<String> files;
        private NotifyIcon trayIcon;
        private ContextMenu trayMenu;
        private int time_interval;

        // Thread to run the setWallpaper function.
        BackgroundWorker bw;

        /// <summary>
        /// Constructor that creates the system tray icon and menu.
        /// </summary>
        /// <param name="file">List of strings that contains the setting_items to use when changing the wallpaper</param>

        public SysTrayApp(List<String> file, decimal time)
        {
            time_interval = (int)(time * 1000);
            files = new List<string>();
            this.files = file;

            // Create a simple tray menu with only one item.
            trayMenu = new ContextMenu();
            trayMenu.MenuItems.Add("Exit", OnExit);
            trayMenu.MenuItems.Add("Start", bw_wallpaper);
            trayMenu.MenuItems.Add("Stop", bw_stopWallpaper);
            trayMenu.MenuItems[2].Enabled = false;

            // Create a tray icon. In this example we use a
            // standard system icon for simplicity, but you
            // can of course use your own custom icon too.
            trayIcon = new NotifyIcon();
            trayIcon.Text = "MyTrayApp";
            trayIcon.Icon = new Icon(SystemIcons.Application, 40, 40);

            // Add menu to tray icon and show it.
            trayIcon.ContextMenu = trayMenu;
            trayIcon.Visible = true;

            bw = new BackgroundWorker();
            bw.WorkerSupportsCancellation = true;
            bw.DoWork += new DoWorkEventHandler(setWallpaper);
            bw.RunWorkerCompleted += new RunWorkerCompletedEventHandler(bw_stopWallpaper);
        }

        protected override void OnLoad(EventArgs e)
        {
            Visible       = false; // Hide form window.
            ShowInTaskbar = false; // Remove from task bar.
 
            base.OnLoad(e);
        }
 
        private void OnExit(object sender, EventArgs e)
        {
            bw.CancelAsync();
            Application.Exit();
        }

        private void bw_wallpaper(object sender, EventArgs e)
        {
            bw.RunWorkerAsync();
            trayMenu.MenuItems[1].Enabled = false;
            trayMenu.MenuItems[2].Enabled = true;
        }

        private void setWallpaper(object sender, DoWorkEventArgs e)
        {
            Random rand = new Random();
            int num = 0, num2 = -1;

            while (true)
            {
                if (bw.CancellationPending)
                {
                    e.Cancel = true;
                    break;
                }
                else
                {
                    num = rand.Next(this.files.Count);

                    while (num == num2)
                    {
                        num = rand.Next(files.Count);
                    }
                    num2 = num;
                    SystemParametersInfo(SPI_SETDESKWALLPAPER, 0, this.files[num], SPIF_UPDATEINIFILE | SPIF_SENDWININICHANGE);
                    System.Threading.Thread.Sleep(time_interval);
                }
            }
        }

        private void bw_stopWallpaper(object sender, EventArgs e)
        {
            bw.CancelAsync();
            trayMenu.MenuItems[1].Enabled = true;
            trayMenu.MenuItems[2].Enabled = false;
        }

        protected override void Dispose(bool isDisposing)
        {
            if (isDisposing)
            {
                // Release the icon resource.
                trayIcon.Dispose();
            }
 
            base.Dispose(isDisposing);
        }
    }
}
