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
            pixelGrid = new ColorT[pixelsX*pixelsX];
            byte r, g, b;
            r = 0;
            g = 0;
            b = 0;
            Random rnd = new Random();
            for (int y = 0; y < pixelsX*pixelsX; y++)
            {
                if (y % 1 == 0)
                    r += 1;
                else if (y % 2 == 0)
                    b += 1;
                else if (y % 3 == 0)
                    g += 1;

                pixelGrid[y] = new ColorT(r,g,b);
            }

        }

        public int X { get { return pixelsX; } set { pixelsX = value; } }
        public int Y { get { return pixelsY; } set { pixelsY = value; } }
        public ColorT[] PixelGrid { get { return pixelGrid; }  }
        public float Width { get { return width; } set { width = value; } }
        public float Height { get { return height; } set { height = value; } }


        
    }
}
