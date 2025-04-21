using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO.Ports;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BobRoss
{
    internal class Layer
    {
        public Bitmap BmpL { get; set; }
        public Panel Canvas {  get; set; }
        public string Name { get; set; }
        public PictureBox newLayer = new PictureBox();
        
        

        public Layer(Panel LayerP, string name) {
            Canvas = LayerP;
            BmpL = new Bitmap(Canvas.Width, Canvas.Height, PixelFormat.Format32bppArgb);
            Name = name;
        }  

        
        public void Draw(Graphics grap)
        {


            ColorMatrix matrix = new ColorMatrix
            {
                Matrix33 = 100 // průhlednost
            };

            ImageAttributes attributes = new ImageAttributes();
            attributes.SetColorMatrix(matrix, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);

            grap.DrawImage(BmpL,
                new Rectangle(0, 0, BmpL.Width, BmpL.Height),
                0, 0, BmpL.Width, BmpL.Height,
                GraphicsUnit.Pixel, attributes);

        }

    }
}
