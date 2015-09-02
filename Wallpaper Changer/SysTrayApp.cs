using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Threading;
using System.IO;

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
         * files: List of files to select from when changing the wallpaper.
         * trayIcon: The image to use on the system tray.
         * trayMenu: Creates a system tray menu.
         */

        private List<String> files;
        private NotifyIcon trayIcon;
        private ContextMenu trayMenu;

        // Thread to run the setWallpaper function.
        Thread othread;

        /// <summary>
        /// Constructor that creates the system tray icon and menu.
        /// </summary>
        /// <param name="file">List of strings that contains the files to use when changing the wallpaper</param>
        public SysTrayApp(List<String> file)
        {
            files = new List<string>();
            this.files = file;

            // Create a simple tray menu with only one item.
            trayMenu = new ContextMenu();
            trayMenu.MenuItems.Add("Exit", OnExit);
            trayMenu.MenuItems.Add("Start", wallpaper);
            trayMenu.MenuItems.Add("Stop", stopWall);
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
        }

        private void readFiles()
        {
            string line;
            System.IO.StreamReader file = new System.IO.StreamReader("C:\\Users\\Scott\\Pictures\\Pic.txt");

            while ((line = file.ReadLine()) != null)
            {
                this.files.Add(line);
            }
        }

        protected override void OnLoad(EventArgs e)
        {
            Visible       = false; // Hide form window.
            ShowInTaskbar = false; // Remove from taskbar.
 
            base.OnLoad(e);
        }
 
        private void OnExit(object sender, EventArgs e)
        {
            othread.Abort();
            Application.Exit();
        }

        private void wallpaper(object sender, EventArgs e)
        {
            
            othread = new Thread(new ThreadStart(setWallpaper));
            othread.Start();
            trayMenu.MenuItems[1].Enabled = false;
            trayMenu.MenuItems[2].Enabled = true;
        }

        private void setWallpaper()
        {
            Random rand = new Random();
            int num, num2 = 0;
            while(true)
            {
                num = rand.Next(this.files.Count);

                while (num == num2)
                {
                    num = rand.Next(files.Count);
                }

                String file = files[num];
                SystemParametersInfo(SPI_SETDESKWALLPAPER, 0, file, SPIF_UPDATEINIFILE | SPIF_SENDWININICHANGE);
                System.Threading.Thread.Sleep(5000);
                num2 = num;
            }
            
        }
    
        private void stopWall(object sender, EventArgs e)
        {
            stopWallpaper();
        }

        private void stopWallpaper()
        {
            othread.Abort();
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
