using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Wallpaper_Changer
{
    public partial class Form1 : Form
    {
        public String file_location;
        public List<String> file_list = new List<string>();
        private Settings __settings = new Settings();

        public Form1()
        {

            InitializeComponent();

            file_location = __settings.fileLocation;

            String list;

            
            using (StreamReader stream = new StreamReader(file_location))
            {
                while((list = stream.ReadLine()) != null)
                {
                    file_list.Add(list);
                }
            }

            
            for (int i = 0; i < file_list.Count; i++)
            {
                list = file_list[i];
                items_to_use.Items.Add(list);
            }

            if (items_to_use.Items.Count == 0)
            {
                move_left.Enabled = false;
            }

            if (posible_items.Items.Count == 0)
            {
                move_right.Enabled = false;
            }
        }

        private void start_tray_Click(object sender, EventArgs e)
        {
            List<String> files = new List<string>();

            foreach (String i in items_to_use.Items)
            {
                files.Add(i);
            }

            SysTrayApp tray = new SysTrayApp(files, time_select.Value);
            this.Hide();
        }

        private void move_right_Click(object sender, EventArgs e)
        {
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
        }

        private void move_left_Click(object sender, EventArgs e)
        {
            if (items_to_use.SelectedItem != null)
            {
                posible_items.Items.Add(items_to_use.SelectedItem);
                items_to_use.Items.Remove(items_to_use.SelectedItem);
            }

            if (items_to_use.Items.Count == 0)
            {
                move_left.Enabled = false;
            }

            if (posible_items.Items.Count > 0)
            {
                move_right.Enabled = true;
            }

        }

        private void posible_items_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (posible_items.SelectedItem != null)
            {
                pictureBox1.ImageLocation = posible_items.SelectedItem.ToString();
            }

        }

        private void load_file_Click(object sender, EventArgs e)
        {
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
        }

        private void save_file_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // TODO - Add code to save current file list.
            }
        }
    }
}
