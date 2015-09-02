using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wallpaper_Changer
{
    public partial class Form1 : Form
    {

        public List<String> file_list = new List<string>();

        public Form1()
        {
            InitializeComponent();

            if (items_to_use.Items.Count == 0)
            {
                move_left.Enabled = false;
            }

            if (posible_items.Items.Count == 0)
                if (posible_items.Items.Count == 0)
                    if (posible_items.Items.Count == 0)
                        if (posible_items.Items.Count == 0)
            {
                move_right.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<String> files = new List<string>();

            for (int i = 0; i < items_to_use.Items.Count; i++)
            {
                files.Add(items_to_use.Items[i].ToString());
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
                System.IO.Stream file_location = openFileDialog1.OpenFile();

                using (System.IO.StreamReader file_stream = new System.IO.StreamReader(file_location))
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
            if(saveFileDialog1.ShowDialog() == DialogResult.OK)
            {

            }
        }
    }
}
