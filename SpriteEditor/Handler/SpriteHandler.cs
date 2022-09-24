using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpriteEditor.Handler
{
    
    public class SpriteHandler
    {

        ImageData CurrentImage { get; set; }
        List<ImageData> Images { get; set; }

        public SpriteHandler(List<ImageData> initialImages = null) 
        {
            if(initialImages == null)
            {
                Images = new List<ImageData>();
            }
            else 
            {
                Images = initialImages;
            }
            CurrentImage = Images[0];


        }

        public void SelectImage(int index)
        {
        if(index < Images.Count)
            CurrentImage = Images[index];
        }

        public ImageData GetImage()
        {
            return CurrentImage;
        }





    }
}
