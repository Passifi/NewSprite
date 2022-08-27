using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SpriteEditor
{
    internal class ImageData
    {

        int pixelsX, pixelsY;
        float width, height;

        ColorT[] pixelGrid;

        public ImageData(int pixelsX, int pixelsY, float width, float height)
        {
            this.pixelsX = pixelsX;
            this.pixelsY = pixelsY;
            this.width = width;
            this.height = height;
            pixelGrid = new ColorT[pixelsX * pixelsX];
            byte r, g, b;
            r = 0;
            g = 0;
            b = 0;
            Random rnd = new Random();
            ColorT white = new ColorT(0xff, 0xff, 0xff);
            ColorT black = new ColorT(0, 0, 0);
            for (int y = 0; y < pixelsX * pixelsX; y++)
            {

                r = (byte)rnd.Next(255);
                g = (byte)rnd.Next(255);
                b = (byte)rnd.Next(255);
                pixelGrid[y] = new ColorT(r, g, b);
            }

        }

        public void SetPixel(int x, int y, ColorT c ) {

            pixelGrid[x + y * pixelsX] = c;
        
        }


        public int X { get { return pixelsX; } set { pixelsX = value; } }
        public int Y { get { return pixelsY; } set { pixelsY = value; } }
        public ColorT[] PixelGrid { get { return pixelGrid; }  }
        public float Width { get { return width; } set { width = value; } }
        public float Height { get { return height; } set { height = value; } }


        
    }
}
