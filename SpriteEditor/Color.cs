using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpriteEditor
{
    internal class Color
    {

        int red;
        int green;
        int blue;
        
        public int Red { get { return red; } set { red = value; } }
        public int Green { get { return green; } set { green = value; } }
        public int Blue { get { return blue; } set { blue = value; } }

        public Color(int red, int green, int blue)
        {
            Red = red;
            Green = green;
            Blue = blue;
        }
    }
}
