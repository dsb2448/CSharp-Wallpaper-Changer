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
            this.move_right = new System.Windows.Forms.Button();
            this.move_left = new System.Windows.Forms.Button();
            this.load_file = new System.Windows.Forms.Button();
            this.save_file = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.time_select = new System.Windows.Forms.NumericUpDown();
            this.possible_pics_panel = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.pics_to_use_panel = new System.Windows.Forms.FlowLayoutPanel();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.change_dir_button = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.time_select)).BeginInit();
            this.SuspendLayout();
            // 
            // start_tray
            // 
            this.start_tray.Location = new System.Drawing.Point(353, 507);
            this.start_tray.Name = "start_tray";
            this.start_tray.Size = new System.Drawing.Size(106, 38);
            this.start_tray.TabIndex = 0;
            this.start_tray.Text = "Start Tray";
            this.start_tray.UseVisualStyleBackColor = true;
            this.start_tray.Click += new System.EventHandler(this.startTrayClick);
            // 
            // move_right
            // 
            this.move_right.Location = new System.Drawing.Point(353, 29);
            this.move_right.Name = "move_right";
            this.move_right.Size = new System.Drawing.Size(106, 121);
            this.move_right.TabIndex = 3;
            this.move_right.Text = "Move Right\r\n-->";
            this.move_right.UseVisualStyleBackColor = true;
            this.move_right.Click += new System.EventHandler(this.moveRightClick);
            // 
            // move_left
            // 
            this.move_left.Location = new System.Drawing.Point(353, 161);
            this.move_left.Name = "move_left";
            this.move_left.Size = new System.Drawing.Size(106, 137);
            this.move_left.TabIndex = 4;
            this.move_left.Text = "Move Left\r\n<--";
            this.move_left.UseVisualStyleBackColor = true;
            this.move_left.Click += new System.EventHandler(this.moveLeftClick);
            // 
            // load_file
            // 
            this.load_file.Location = new System.Drawing.Point(353, 309);
            this.load_file.Name = "load_file";
            this.load_file.Size = new System.Drawing.Size(106, 48);
            this.load_file.TabIndex = 5;
            this.load_file.Text = "Load File";
            this.load_file.UseVisualStyleBackColor = true;
            this.load_file.Click += new System.EventHandler(this.loadFileClick);
            // 
            // save_file
            // 
            this.save_file.Location = new System.Drawing.Point(353, 368);
            this.save_file.Name = "save_file";
            this.save_file.Size = new System.Drawing.Size(106, 48);
            this.save_file.TabIndex = 7;
            this.save_file.Text = "Save File";
            this.save_file.UseVisualStyleBackColor = true;
            this.save_file.Click += new System.EventHandler(this.saveFileClick);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "wall";
            this.saveFileDialog1.Filter = "Wall File|*.wall";
            this.saveFileDialog1.Title = "Save Wallpaper Playlist";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(356, 427);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Time Interval in Sec";
            // 
            // time_select
            // 
            this.time_select.Location = new System.Drawing.Point(353, 451);
            this.time_select.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.time_select.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.time_select.Name = "time_select";
            this.time_select.Size = new System.Drawing.Size(106, 20);
            this.time_select.TabIndex = 9;
            this.time_select.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // possible_pics_panel
            // 
            this.possible_pics_panel.AutoScroll = true;
            this.possible_pics_panel.BackColor = System.Drawing.SystemColors.Window;
            this.possible_pics_panel.Location = new System.Drawing.Point(12, 29);
            this.possible_pics_panel.Name = "possible_pics_panel";
            this.possible_pics_panel.Size = new System.Drawing.Size(333, 516);
            this.possible_pics_panel.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Pics";
            // 
            // pics_to_use_panel
            // 
            this.pics_to_use_panel.AutoScroll = true;
            this.pics_to_use_panel.BackColor = System.Drawing.SystemColors.Window;
            this.pics_to_use_panel.Location = new System.Drawing.Point(466, 29);
            this.pics_to_use_panel.Name = "pics_to_use_panel";
            this.pics_to_use_panel.Size = new System.Drawing.Size(333, 516);
            this.pics_to_use_panel.TabIndex = 11;
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.Description = "Select the folder to get pictures from.";
            this.folderBrowserDialog1.ShowNewFolderButton = false;
            // 
            // change_dir_button
            // 
            this.change_dir_button.Location = new System.Drawing.Point(46, 3);
            this.change_dir_button.Name = "change_dir_button";
            this.change_dir_button.Size = new System.Drawing.Size(299, 23);
            this.change_dir_button.TabIndex = 13;
            this.change_dir_button.Text = "Change Dir";
            this.change_dir_button.UseVisualStyleBackColor = true;
            this.change_dir_button.Click += new System.EventHandler(this.change_dir_button_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Wall File|*.wall";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 557);
            this.Controls.Add(this.change_dir_button);
            this.Controls.Add(this.pics_to_use_panel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.possible_pics_panel);
            this.Controls.Add(this.time_select);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.save_file);
            this.Controls.Add(this.load_file);
            this.Controls.Add(this.move_left);
            this.Controls.Add(this.move_right);
            this.Controls.Add(this.start_tray);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.time_select)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button start_tray;
        private System.Windows.Forms.Button move_right;
        private System.Windows.Forms.Button move_left;
        private System.Windows.Forms.Button load_file;
        private System.Windows.Forms.Button save_file;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown time_select;
        private System.Windows.Forms.FlowLayoutPanel possible_pics_panel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FlowLayoutPanel pics_to_use_panel;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button change_dir_button;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

