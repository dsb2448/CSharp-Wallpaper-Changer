using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Wallpaper_Changer
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// The current selected image in one of the panels
        /// </summary>
        public static Control selected_control = null;

        public List<Control> file_list = new List<Control>();
        private Settings __settings = new Settings();

        public Form1()
        {
            // AUTO GENERATED
            InitializeComponent();

            populatePanel(possible_pics_panel ,__settings.file_location);
        }

        /// <summary>
        /// Takes the file path specified and adds all pictures to the specified FlowLayoutPanel.
        /// </summary>
        /// <param name="panel">The FlowLayoutPanel to add the items to</param>
        /// <param name="file_to_use">The file that contains the image path to the pictures you want to use</param>
        private void populatePanel(FlowLayoutPanel panel, String file_to_use)
        {
            panel.Controls.Clear();

            String[] pic_button_path = System.IO.File.ReadAllLines(file_to_use);
            Image_Button[] pic_button = new Image_Button[pic_button_path.Length];

            for (int i = 0; i < pic_button.Length; i++)
            {
                pic_button[i] = new Image_Button(pic_button_path[i]);
                Control current = pic_button[i];
                pic_button[i].Click += (s, e) => { selected_control = current; };
                panel.Controls.Add(pic_button[i]);
            }
        }

        private void populatePanel(String[] files)
        {
            possible_pics_panel.Controls.Clear();

            String file_location = __settings.file_location;
            String[] pic_button_path = files;
            Image_Button[] pic_button = new Image_Button[pic_button_path.Length];

            for (int i = 0; i < pic_button.Length; i++)
            {
                pic_button[i] = new Image_Button(pic_button_path[i]);
                Control current = pic_button[i];
                pic_button[i].Click += (s, e) => { selected_control = current; };
                possible_pics_panel.Controls.Add(pic_button[i]);
            }
        }

        private void startTrayClick(object sender, EventArgs e)
        {
            List<String> files = new List<string>();

            foreach (Image_Button con in file_list)
            {
                files.Add(con.image_location);
            }

            SysTrayApp tray = new SysTrayApp(files, time_select.Value);
            this.Hide();
        }
        
        /* 
         * Moves the selected file from the possible_pics_panel to the pics_to_use_panel
         * */
        private void moveRightClick(object sender, EventArgs e)
        {
            // If a image is selected from the possible_pics_panel remove it.
            if (selected_control != null && selected_control.Parent.Name == "possible_pics_panel")
            {
                pics_to_use_panel.Controls.Add(selected_control);
                possible_pics_panel.Controls.Remove(selected_control);
                file_list.Add(selected_control);
            }
        }

        /// <summary>
        /// Moves the selected file from the pics_to_use_panel to the possible_pics_panel
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">EventArgs</param>
        private void moveLeftClick(object sender, EventArgs e)
        {
            // If a image is selected from the pics_to_use_panel remove it.
            if (selected_control != null && selected_control.Parent.Name == "pics_to_use_panel")
            {
                possible_pics_panel.Controls.Add(selected_control);
                pics_to_use_panel.Controls.Remove(selected_control);
                file_list.Remove(selected_control);
            }
        }

        private void loadFileClick(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = @"C:\Users\" + Environment.UserName + @"\Wallpaper Changer\Playlist";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pics_to_use_panel.Controls.Clear();

                populatePanel(pics_to_use_panel, openFileDialog1.FileName);
                 
            }
        }

        private void saveFileClick(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // TODO - Add code to save current file list.
            }
        }

        private void change_dir_button_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                __settings.file_location = folderBrowserDialog1.SelectedPath;
                populatePanel(Directory.GetFiles(folderBrowserDialog1.SelectedPath, "*.jpg", SearchOption.TopDirectoryOnly));
                
            }
        }
        
    }
}
