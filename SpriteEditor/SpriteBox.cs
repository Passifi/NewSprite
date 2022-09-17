using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace SpriteEditor
{
    public class SpriteBox : PictureBox
    {
        public ImageData Image;
       
        public void SetImage(ImageData img) {
            Image = img;
        }
        
    }
}
