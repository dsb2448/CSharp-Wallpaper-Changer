using System;
using System.Windows.Forms;
using System.Drawing;

namespace Wallpaper_Changer
{
    class Image_Button : Button
    {
        public String image_location { get; set; }

        /// <summary>
        /// Sets the Name, Width, Height, Image, and Click action of the Image_Button.
        /// </summary>
        /// <param name="file_location">The Image to show on the button</param>
        public Image_Button(String file_location)
        {
            this.image_location = file_location;
            this.Name = image_location;
            this.Width = 144;
            this.Height = 91;
            this.Image = resizeImage(Image.FromFile(image_location), new Size(this.Width, this.Height));
        }

        /// <summary>
        /// Resize an image to a specified size
        /// </summary>
        /// <param name="imgToResize">The image you want to resize</param>
        /// <param name="size">The size you want the image to be</param>
        /// <returns>The resized image</returns>
        public Image resizeImage(Image imgToResize, Size size)
        {
            return (Image)(new Bitmap(imgToResize, size));
        }
    }
}
