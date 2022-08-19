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
            for (int y = 0; y < imageData.Y; y++) {
                for (int x =0; x<imageData.X; x++)
                {
                    byte r, gr, b;
                    r = imageData.PixelGrid[x + y * imageData.X].Red;
                    b = imageData.PixelGrid[x + y * imageData.X].Blue;
                    gr = imageData.PixelGrid[x + y * imageData.X].Green;

                    Color c = Color.FromArgb(255, r, gr, b);

                    System.Drawing.SolidBrush myBrush = new System.Drawing.SolidBrush(c);
                    int x1, x2, y1, y2;
                    x1 = x * (int)imageData.Width;
                    y1 = y * (int)imageData.Height;
                    x2 = x1+ (int)imageData.Width;
                    y2 = y1+ (int)imageData.Height;
                    Console.WriteLine($"{x1}, {y1}, {x2}, {y2}");
                    g.FillRectangle(myBrush, new Rectangle(x,y1,x2,y2));
                    myBrush.Dispose();
                    
                }
            }
            
        }

    }
}
