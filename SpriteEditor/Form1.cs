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

            
            pxDraw.DrawPixelGrid(g);
            pxDraw.DrawGrid(g);
            





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
