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

        Color[] pixelGrid;

        public ImageData(int pixelsX, int pixelsY, float width, float height)
        {
            this.pixelsX = pixelsX;
            this.pixelsY = pixelsY;
            this.width = width;
            this.height = height;
            pixelGrid = new Color[pixelsX*pixelsX];

        }

        public int X { get { return pixelsX; } set { pixelsX = value; } }
        public int Y { get { return pixelsY; } set { pixelsY = value; } }
        public Color[] PixelGrid { get { return pixelGrid; }  }
        public float Width { get { return width; } set { width = value; } }
        public float Height { get { return height; } set { height = value; } }


        
    }
}
