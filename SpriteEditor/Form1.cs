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
        public Form1()
        {
            InitializeComponent();
            
        }

                

        private void pictureBox1_Paint(object sender, System.Windows.Forms.PaintEventArgs pe)
        {
            PixelDraw pxDraw = new PixelDraw(pictureBox1);
            Graphics g = pe.Graphics;

            pxDraw.DrawGrid(g);
            //int numOfPixels = 8;
            //// Pixels 
            //float pixelWidth = pictureBox1.Size.Width/numOfPixels;
            //float pixelHeight = pictureBox1.Size.Height/numOfPixels;

            //for (int i = 1; i <= numOfPixels; i++) {
            //    g.DrawLine(System.Drawing.Pens.Black,0, pixelHeight * i, pictureBox1.Size.Width,pixelHeight*i);
            //    g.DrawLine(System.Drawing.Pens.Black, pixelWidth*i, 0, pixelWidth*i, pictureBox1.Size.Height);
            //}

            




        }

        private void pictureBox1_hover(object sender, EventArgs ev){
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
            Console.WriteLine(MousePosition.X);
            Console.WriteLine(MousePosition.Y);
        }
    }
}
