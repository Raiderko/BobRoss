using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace BobRoss
{
    internal class Graph_axis
    {

        public Pen pen = new Pen(Color.Black);
        
        

        public void Initialize(PictureBox pictureBox1, Graphics g, int k)
        {
            g.DrawLine(pen, pictureBox1.Width / 2, 0, pictureBox1.Width / 2, pictureBox1.Height);
            g.DrawLine(pen, 0, pictureBox1.Height / 2, pictureBox1.Width, pictureBox1.Height / 2);
            for (int i = 0; i < k; i++)
            {

                Pen pen2 = new Pen(Color.LightGray);
                g.DrawLine(pen2, (float)(pictureBox1.Width / k) * i, 0, (float)(pictureBox1.Width / k) * i, pictureBox1.Height);
                g.DrawLine(pen2, 0, (pictureBox1.Height / k) * i, pictureBox1.Width, (pictureBox1.Height / k) * i);
            }
        }

        public void Clear( Graphics gr)
        {
            gr.Clear(Color.Transparent);

        }
    }
    
}
