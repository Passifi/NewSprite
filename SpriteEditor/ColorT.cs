using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpriteEditor
{
    public class ColorT
    {

        byte red;
        byte green;
        byte blue;
        
        public byte Red { get { return red; } set { red = value; } }
        public byte Green { get { return green; } set { green = value; } }
        public byte Blue { get { return blue; } set { blue = value; } }

        public ColorT(byte red=0xff, byte green=0x00, byte blue=0x00)
        {
            Red = red;
            Green = green;
            Blue = blue;
        }
    }
}
