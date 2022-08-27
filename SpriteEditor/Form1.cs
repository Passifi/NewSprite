using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SpriteEditor
{
    public partial class Form1 : Form
    {
        ImageData image;
        public Form1()
        {
            
            InitializeComponent();
            int numOfPixels = 8;
            // Pixels 
            float pixelWidth = pictureBox1.Size.Width / numOfPixels;
            float pixelHeight = pictureBox1.Size.Height / numOfPixels;
            image = new ImageData(numOfPixels, numOfPixels, pixelWidth, pixelHeight);

        }

                

        private void pictureBox1_Paint(object sender, System.Windows.Forms.PaintEventArgs pe)
        {
            PixelDraw pxDraw = new PixelDraw(pictureBox1,image);
            Graphics g = pe.Graphics;

            
            pxDraw.DrawPixelGrid(g);
            pxDraw.DrawGrid(g);
            





        }

        private void pictureBox2_Paint(object sender, System.Windows.Forms.PaintEventArgs pe)
        {
            PixelDraw pxDraw = new PixelDraw(pictureBox2,image);
            Graphics g = pe.Graphics;


            pxDraw.DrawPixelGrid(g);

        }

        private void pictureBox1_hover(object sender, EventArgs ev)
        {
            
        }

        private void pictureBox1_MouseMove(object sender, EventArgs ev) 
        {
            var coordinates = pictureBox1.PointToClient(Cursor.Position);
            Console.WriteLine(coordinates.X);
            Console.WriteLine(coordinates.Y);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            var coordinates = pictureBox1.PointToClient(Cursor.Position);
            // Get Pixel Coordinates in grid 
            int x = (int)(coordinates.X / image.Width);
            int y = (int)(coordinates.Y / image.Height);
            ColorT c = new ColorT(123, 12, 12);
            image.SetPixel(x, y, c);
            pictureBox1.Invalidate();
            pictureBox2.Invalidate();
        }
    }
}
