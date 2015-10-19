using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Wallpaper_Changer
{
    public partial class Form1 : Form
    {
        // Accessed in Image_Button class
        public static Control selected_control = null;


        public List<String> file_list = new List<String>();
        private Settings __settings = new Settings();

        
        public Form1()
        {// START Form1
            // AUTO GENERATED
            InitializeComponent();

            // Location of .wall file to use
            String file_location = __settings.fileLocation;

            String list;
            
            using (StreamReader stream = new StreamReader(file_location))
            {
                while((list = stream.ReadLine()) != null)
                {
                    file_list.Add(list);
                }
            }

            Image_Button[] pic_button = new Image_Button[file_list.Count];

            for (int i = 0; i < pic_button.Length; i++)
            {
                pic_button[i] = new Image_Button();
                pic_button[i].setParemeters(file_list[i]);
                possible_pics_panel.Controls.Add(pic_button[i]);
            }
        } // END Form1

        

        
        private void startTrayClick(object sender, EventArgs e)
        {// START startTrayClick
            List<String> files = new List<string>();

            foreach (String i in items_to_use.Items)
            {
                files.Add(i);
            }

            SysTrayApp tray = new SysTrayApp(files, time_select.Value);
            this.Hide();
        }// END startTrayClick



        
        /* 
         * Moves the selected file from the possible_pics_panel to the pics_to_use_panel
         * */
        private void moveRightClick(object sender, EventArgs e)
        {// START moveRightClick
            if (posible_items.SelectedItem != null)
            {
                items_to_use.Items.Add(posible_items.SelectedItem);
                posible_items.Items.Remove(posible_items.SelectedItem);
            }

            if (posible_items.Items.Count == 0)
            {
                move_right.Enabled = false;
            }

            if (items_to_use.Items.Count > 0)
            {
                move_left.Enabled = true;
            }
        }// END moveRightClick


        
        
        /*
         * Moves the selected file from the pics_to_use_panel to the possible_pics_panel
         * */
        private void moveLeftClick(object sender, EventArgs e)
        {// START moveLeftClick
            // If a button is selected from the possible_pics_panel remove it.
            if (selected_control != null && selected_control.Parent.Name == "possible_pics_panel")
            {
                pics_to_use_panel.Controls.Add(selected_control);
                possible_pics_panel.Controls.Remove(selected_control);
            }
        }// END moveLeftClick



        
        private void loadFileClick(object sender, EventArgs e)
        {// START loadFileClick
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Stream file = openFileDialog1.OpenFile();

                __settings.fileLocation = openFileDialog1.FileName;

                file_list.Clear();

                using (StreamReader file_stream = new StreamReader(file))
                {
                    string line;
                    while ((line = file_stream.ReadLine()) != null)
                    {
                        file_list.Add(line);
                    }
                }
            }

            posible_items.Items.Clear();

            for (int i = 0; i < file_list.Count; i++)
            {
                posible_items.Items.Add(file_list[i]);
            }

            if (posible_items.Items.Count > 0)
            {
                move_right.Enabled = true;
            }
        }// END loadFileClick



        
        private void saveFileClick(object sender, EventArgs e)
        {// START saveFileClick
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // TODO - Add code to save current file list.
            }
        }// END saveFileClick



        
        public static Image resizeImage(Image imgToResize, Size size)
        {// START resizeImage
            return (Image)(new Bitmap(imgToResize, size));
        }// END resizeImage
    }
}
