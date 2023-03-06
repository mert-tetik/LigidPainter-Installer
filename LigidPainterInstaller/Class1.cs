using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;
using System.Windows.Forms;

namespace LigidPainterInstaller
{
    public class BlendTxtr
    {
        private static void blendPictures(Bitmap bg, Bitmap front, int deltax, int deltay)
        {
            for (int y = 0; y < front.Height; y++)
            {

                for (int x = 0; x < front.Width; x++)
                {
                    if (front.GetPixel(x, y).A < 255)
                    {
                        Color newColor = bg.GetPixel(x + deltax, y + deltay);
                        front.SetPixel(x, y, newColor);
                    }

                }
            }
        }
        public static void blendPictures(PictureBox back, PictureBox front)
        {
            int leftDifference = Math.Abs(back.Left - front.Left);
            int topDifference = Math.Abs(back.Top - front.Top);
            blendPictures((Bitmap)back.Image, (Bitmap)front.Image, leftDifference, topDifference);
        }
    }
}
