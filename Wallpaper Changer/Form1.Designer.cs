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
            this.items_to_use = new System.Windows.Forms.ListBox();
            this.move_right = new System.Windows.Forms.Button();
            this.move_left = new System.Windows.Forms.Button();
            this.load_file = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.save_file = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.time_select = new System.Windows.Forms.NumericUpDown();
            this.possible_pics_panel = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.posible_items = new System.Windows.Forms.ListBox();
            this.pics_to_use_panel = new System.Windows.Forms.FlowLayoutPanel();
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
            // items_to_use
            // 
            this.items_to_use.FormattingEnabled = true;
            this.items_to_use.Location = new System.Drawing.Point(466, 51);
            this.items_to_use.Name = "items_to_use";
            this.items_to_use.Size = new System.Drawing.Size(333, 537);
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
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.InitialDirectory = "C:\\Apps\\Wallpaper Changer\\Files";
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
            this.time_select.DecimalPlaces = 1;
            this.time_select.Location = new System.Drawing.Point(353, 451);
            this.time_select.Maximum = new decimal(new int[] {
            1000,
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
            this.possible_pics_panel.Size = new System.Drawing.Size(333, 213);
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
            // posible_items
            // 
            this.posible_items.FormattingEnabled = true;
            this.posible_items.Location = new System.Drawing.Point(587, -50);
            this.posible_items.Name = "posible_items";
            this.posible_items.Size = new System.Drawing.Size(120, 95);
            this.posible_items.TabIndex = 12;
            // 
            // pics_to_use_panel
            // 
            this.pics_to_use_panel.AutoScroll = true;
            this.pics_to_use_panel.BackColor = System.Drawing.SystemColors.Window;
            this.pics_to_use_panel.Location = new System.Drawing.Point(12, 258);
            this.pics_to_use_panel.Name = "pics_to_use_panel";
            this.pics_to_use_panel.Size = new System.Drawing.Size(333, 287);
            this.pics_to_use_panel.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 557);
            this.Controls.Add(this.pics_to_use_panel);
            this.Controls.Add(this.posible_items);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.possible_pics_panel);
            this.Controls.Add(this.time_select);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.save_file);
            this.Controls.Add(this.load_file);
            this.Controls.Add(this.move_left);
            this.Controls.Add(this.move_right);
            this.Controls.Add(this.items_to_use);
            this.Controls.Add(this.start_tray);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.time_select)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button start_tray;
        private System.Windows.Forms.ListBox items_to_use;
        private System.Windows.Forms.Button move_right;
        private System.Windows.Forms.Button move_left;
        private System.Windows.Forms.Button load_file;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button save_file;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown time_select;
        private System.Windows.Forms.FlowLayoutPanel possible_pics_panel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox posible_items;
        private System.Windows.Forms.FlowLayoutPanel pics_to_use_panel;
    }
}

