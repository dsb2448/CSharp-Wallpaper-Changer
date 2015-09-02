namespace Wallpaper_Changer
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.start_tray = new System.Windows.Forms.Button();
            this.posible_items = new System.Windows.Forms.ListBox();
            this.items_to_use = new System.Windows.Forms.ListBox();
            this.move_right = new System.Windows.Forms.Button();
            this.move_left = new System.Windows.Forms.Button();
            this.load_file = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.save_file = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // start_tray
            // 
            this.start_tray.Location = new System.Drawing.Point(353, 445);
            this.start_tray.Name = "start_tray";
            this.start_tray.Size = new System.Drawing.Size(106, 38);
            this.start_tray.TabIndex = 0;
            this.start_tray.Text = "Start Tray";
            this.start_tray.UseVisualStyleBackColor = true;
            this.start_tray.Click += new System.EventHandler(this.button1_Click);
            // 
            // posible_items
            // 
            this.posible_items.FormattingEnabled = true;
            this.posible_items.Location = new System.Drawing.Point(12, 12);
            this.posible_items.Name = "posible_items";
            this.posible_items.Size = new System.Drawing.Size(333, 251);
            this.posible_items.TabIndex = 1;
            this.posible_items.SelectedIndexChanged += new System.EventHandler(this.posible_items_SelectedIndexChanged);
            // 
            // items_to_use
            // 
            this.items_to_use.FormattingEnabled = true;
            this.items_to_use.Location = new System.Drawing.Point(466, 11);
            this.items_to_use.Name = "items_to_use";
            this.items_to_use.Size = new System.Drawing.Size(333, 472);
            this.items_to_use.TabIndex = 2;
            // 
            // move_right
            // 
            this.move_right.Location = new System.Drawing.Point(353, 13);
            this.move_right.Name = "move_right";
            this.move_right.Size = new System.Drawing.Size(106, 137);
            this.move_right.TabIndex = 3;
            this.move_right.Text = "Move Right\r\n-->";
            this.move_right.UseVisualStyleBackColor = true;
            this.move_right.Click += new System.EventHandler(this.move_right_Click);
            // 
            // move_left
            // 
            this.move_left.Location = new System.Drawing.Point(353, 156);
            this.move_left.Name = "move_left";
            this.move_left.Size = new System.Drawing.Size(106, 137);
            this.move_left.TabIndex = 4;
            this.move_left.Text = "Move Left\r\n<--";
            this.move_left.UseVisualStyleBackColor = true;
            this.move_left.Click += new System.EventHandler(this.move_left_Click);
            // 
            // load_file
            // 
            this.load_file.Location = new System.Drawing.Point(353, 299);
            this.load_file.Name = "load_file";
            this.load_file.Size = new System.Drawing.Size(106, 48);
            this.load_file.TabIndex = 5;
            this.load_file.Text = "Load File";
            this.load_file.UseVisualStyleBackColor = true;
            this.load_file.Click += new System.EventHandler(this.load_file_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 269);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(332, 214);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // save_file
            // 
            this.save_file.Location = new System.Drawing.Point(353, 353);
            this.save_file.Name = "save_file";
            this.save_file.Size = new System.Drawing.Size(106, 48);
            this.save_file.TabIndex = 7;
            this.save_file.Text = "Save File";
            this.save_file.UseVisualStyleBackColor = true;
            this.save_file.Click += new System.EventHandler(this.save_file_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "wall";
            this.saveFileDialog1.Title = "Save Wallpaper Playlist";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 495);
            this.Controls.Add(this.save_file);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.load_file);
            this.Controls.Add(this.move_left);
            this.Controls.Add(this.move_right);
            this.Controls.Add(this.items_to_use);
            this.Controls.Add(this.posible_items);
            this.Controls.Add(this.start_tray);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button start_tray;
        private System.Windows.Forms.ListBox posible_items;
        private System.Windows.Forms.ListBox items_to_use;
        private System.Windows.Forms.Button move_right;
        private System.Windows.Forms.Button move_left;
        private System.Windows.Forms.Button load_file;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button save_file;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

