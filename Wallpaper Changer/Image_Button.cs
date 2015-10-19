using System;
using System.Windows.Forms;
using System.Drawing;

namespace Wallpaper_Changer
{
    class Image_Button : Button
    {
        private String image_location;

        public String image_locataion
        {
            get { return image_location; }
            set { image_location = value; }
        }

        /// <summary>
        /// Sets the Name, Width, Height, Image, and Click action of the Image_Button.
        /// </summary>
        /// <param name="file_location">The Image to show on the button</param>
        public void setParemeters(String file_location)
        {
            this.image_locataion = file_location;
            this.Name = image_locataion;
            this.Width = 144;
            this.Height = 91;
            this.Click += (s, e) =>
            {
                Form1.selected_control = this;
            };

            Image pic_to_use = Image.FromFile(this.image_locataion);
            pic_to_use = Form1.resizeImage(pic_to_use, new Size(this.Width, this.Height));
            this.Image = pic_to_use;
        }
    }
}
