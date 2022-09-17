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
        const int noOfSprites = 24;
        ImageData image;
        ImageData[] spriteImages;
        bool clicked = false;
        PictureBox selectedBox = null;
        public Form1()
        {
            
            InitializeComponent();
            this.DrawArea.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_Click);
            this.DrawArea.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            this.DrawArea.MouseHover += new System.EventHandler(this.pictureBox1_hover);
            this.DrawArea.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.DrawArea.MouseUp += new System.Windows.Forms.MouseEventHandler((p, s) => clicked = false);
            this.SpritePreview1.Click += new System.EventHandler(SpriteSelect);
            this.SpritePreview2.Click += new System.EventHandler(SpriteSelect);
            this.SpritePreview4.Click += new System.EventHandler(SpriteSelect);
            this.SpritePreview3.Click += new System.EventHandler(SpriteSelect);
            this.pictureBox6.Click += new System.EventHandler(SpriteSelect);          
            this.pictureBox7.Click    += new System.EventHandler(SpriteSelect);          
            this.pictureBox8.Click    += new System.EventHandler(SpriteSelect);          
            this.pictureBox9.Click += new System.EventHandler(SpriteSelect);          
            this.pictureBox10.Click   += new System.EventHandler(SpriteSelect);
            this.pictureBox11.Click   += new System.EventHandler(SpriteSelect);
            this.pictureBox12.Click += new System.EventHandler(SpriteSelect);
            this.pictureBox13.Click   += new System.EventHandler(SpriteSelect);
            this.pictureBox14.Click   += new System.EventHandler(SpriteSelect);
            this.pictureBox15.Click += new System.EventHandler(SpriteSelect);
            this.pictureBox16.Click += new System.EventHandler(SpriteSelect);
            this.pictureBox17.Click += new System.EventHandler(SpriteSelect);
            this.SpritePreview6.Click += new System.EventHandler(SpriteSelect);
            this.SpritePreview5.Click += new System.EventHandler(SpriteSelect);
            this.pictureBox20.Click += new System.EventHandler(SpriteSelect);
            this.pictureBox21.Click += new System.EventHandler(SpriteSelect);
            this.pictureBox22.Click += new System.EventHandler(SpriteSelect);
            this.pictureBox23.Click += new System.EventHandler(SpriteSelect);
            this.pictureBox24.Click += new System.EventHandler(SpriteSelect);
            this.pictureBox25.Click += new System.EventHandler(SpriteSelect);
            int numOfPixels = 8;
            // Pixels 
            float pixelWidth = DrawArea.Size.Width / numOfPixels;
            float pixelHeight = DrawArea.Size.Height / numOfPixels;
            image = new ImageData(numOfPixels, numOfPixels, pixelWidth, pixelHeight);
            spriteImages = new ImageData[noOfSprites];
            selectedBox = SpritePreview1;
            for(int i=0; i < noOfSprites; i++)  
            {
                spriteImages[i] = new ImageData(numOfPixels, numOfPixels, pixelWidth, pixelHeight);
            }


        }

                

        private void pictureBox1_Paint(object sender, System.Windows.Forms.PaintEventArgs pe)
        {
            PixelDraw pxDraw = new PixelDraw(DrawArea,image);
            Graphics g = pe.Graphics;

            
            pxDraw.DrawPixelGrid(g);
            pxDraw.DrawGrid(g);
            





        }

        private void pictureBox2_Paint(object sender, System.Windows.Forms.PaintEventArgs pe)
        {
            PixelDraw pxDraw = new PixelDraw(SpritePreview1,image);
            Graphics g = pe.Graphics;


            pxDraw.DrawPixelGrid(g);

        }

        private void pictureBox1_hover(object sender, EventArgs ev)
        {
            
        }

        private void SpriteSelect(object sender, EventArgs ev) {
            selectedBox.Paint -= new System.Windows.Forms.PaintEventHandler(pictureBox2_Paint);
            image = spriteImages[3];
            selectedBox = ((PictureBox)sender);

            DrawArea.Invalidate();

           
        }

        private void pictureBox1_MouseMove(object sender, EventArgs ev) 
        {
            if (clicked) 
            {
                var coordinates = DrawArea.PointToClient(Cursor.Position);
                int x = (int)(coordinates.X / image.Width);
                int y = (int)(coordinates.Y / image.Height);
                ColorT c = new ColorT(123, 12, 12);
                image.SetPixel(x, y, c);
                DrawArea.Invalidate();
                SpritePreview1.Invalidate();
                selectedBox.Paint += new System.Windows.Forms.PaintEventHandler(pictureBox2_Paint);
                selectedBox.Invalidate();
                // There are two ways I can think of doing this 
                // Either keep updating selectedBox Paints like this or attach an Image File to the sprite box 
                // the later one makes more sense given what I plan to do so this should be the way however
                // that would require extended picturebox or creating a child class of PictureBox ... 

            }
                
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            clicked = true;
            var coordinates = DrawArea.PointToClient(Cursor.Position);
            // Get Pixel Coordinates in grid 
            int x = (int)(coordinates.X / image.Width);
            int y = (int)(coordinates.Y / image.Height);
            ColorT c = new ColorT(123, 12, 12);
            image.SetPixel(x, y, c);
            DrawArea.Invalidate();
            SpritePreview1.Invalidate();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
