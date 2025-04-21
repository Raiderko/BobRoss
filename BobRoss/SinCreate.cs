using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BobRoss
{
    internal class SinCreate
    {
       
        public SinCreate() 
        {
            
        }

        public void Initialize(double angle, double freq, double t, Graphics g,Panel pan, Pen p)
        {
            double delta = 0.1;
            

            int Ycen = pan.Height / 2;
            int xP = 0;
            int yP = Ycen + (int)(Math.Sin(angle * freq) * t);  

            for(int x = 0; x < pan.Width; x++)
            {
                angle += delta;
                int y = Ycen +(int)(Math.Sin(angle * freq) * t);


                g.DrawLine(p, xP, yP, x, y);

                yP = y;
                xP = x;
            }
        }
    }
}
