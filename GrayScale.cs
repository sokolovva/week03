using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace HackBulgaria3
{
    class GrayScale
    {
        static void Main(string[] args)
        {
          

            Bitmap bmp = (Bitmap)Image.FromFile("wow.bmp");
            for (int i = 0; i < bmp.Width; i++)
            {
                for (int j = 0; j < bmp.Height; j++)
                {
                  
                    Color pixel = bmp.GetPixel(i, j);
                    double gray = 0.2126 * pixel.R + 0.7152 * pixel.G + 0.0722 * pixel.B; 
                    bmp.SetPixel(i, j, Color.FromArgb(Convert.ToInt32(gray), Convert.ToInt32(gray), Convert.ToInt32(gray)));

                }
            }
            bmp.Save("newWow.bmp");
            
        }
    }
}
