using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
namespace SpriteEditor
{
    internal class PixelDraw
    {
        PictureBox pictureBox;
        ImageData imageData;
        public PixelDraw(PictureBox pictureBox) 
        {
            int numOfPixels = 8;
            // Pixels 
            float pixelWidth = pictureBox.Size.Width / numOfPixels;
            float pixelHeight = pictureBox.Size.Height / numOfPixels;
            this.pictureBox = pictureBox;
            this.imageData = new ImageData(numOfPixels, numOfPixels, pixelWidth, pixelHeight);
        }
        public void DrawGrid(Graphics g) {
            int numOfPixels = 8;
            // Pixels 
            float pixelWidth = pictureBox.Size.Width / numOfPixels;
            float pixelHeight = pictureBox.Size.Height / numOfPixels;

            for (int i = 1; i <= numOfPixels; i++)
            {
                g.DrawLine(System.Drawing.Pens.Black, 0, pixelHeight * i, pictureBox.Size.Width, pixelHeight * i);
                g.DrawLine(System.Drawing.Pens.Black, pixelWidth * i, 0, pixelWidth * i, pictureBox.Size.Height);
            }
        }

        public void DrawPixelGrid(Graphics g) {
            
        }

    }
}
