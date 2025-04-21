using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BobRoss
{
    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }
        List<Layer> layers = new List<Layer>();
        Pen pen;
        Graphics gr;
        Graphics G_l1;
        Brush brush;
        Layer layer;
        bool MouseDown;
        private void Form1_Load(object sender, EventArgs e)
        {
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            
            colorDialog.Color = Color.Black;
            pen = new Pen(colorDialog.Color);
            brush = new SolidBrush(colorDialog.Color);
            gr = pictureBox1.CreateGraphics();
            button1.BackColor = colorDialog.Color;
            gr.DrawLine(pen, pictureBox1.Width / 2, 20, pictureBox1.Width / 2, pictureBox1.Height);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            colorDialog.ShowDialog();

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            Graph_axis graph = new Graph_axis();
            Layer newLayer = new Layer(panel1, "Graph");
            
            if (checkBox1.Checked)
            {
                 
                layers.Add(newLayer);
                
                if (listBox1.Items.Contains(newLayer.Name))
                {
                    listBox1.Items.Add(newLayer.Name + $"{listBox1.Items.Count}");
                }
                else
                {
                    listBox1.Items.Add(newLayer.Name);

                }

                Graphics g = Graphics.FromImage(newLayer.BmpL);
                
                    graph.Initialize(pictureBox1,g , 8);
                    pictureBox1.Image = MergeLayers(panel1.Width, panel1.Height);
                
                
                
                
            } else
            {
                try
                {
                    
                    foreach (Layer Layer in layers)
                    {
                        if (Layer.Name == "Graph")
                        {
                            Graphics grep = Graphics.FromImage(Layer.BmpL);
                            graph.Clear(grep);
                            pictureBox1.Image = MergeLayers(panel1.Width, panel1.Height);
                            listBox1.Items.Remove("Graph");
                            layers.Remove(Layer);

                            updateListB();
                        }
                    }
                    
                }
                catch (Exception ex) { }
            }
        }

       public void updateListB()
        {
            listBox1.Items.Clear();
            foreach(Layer layer in layers)
            {
                listBox1.Items.Add(layer.Name);
            }
        }
        public void ChangeColorPen (Color c)
        {
            pen = new Pen(c);
            ChangeWidthPen(PenWidthBar.Value);
            brush = new SolidBrush(colorDialog.Color);
            button1.BackColor = colorDialog.Color;
        }

        public void ChangeWidthPen(int wid)
        {
            pen.Width = wid;
            brush = new SolidBrush(colorDialog.Color);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ChangeColorPen(colorDialog.Color);
        }

        private void PenWidthBar_Scroll(object sender, EventArgs e)
        {
            ChangeWidthPen(PenWidthBar.Value);
        }

        private void modeDraw_CheckedChanged(object sender, EventArgs e)
        {
            /**if (modeDraw.Checked)
            {

                 layer = new Layer(pictureBox1);
                
                layer.Create(listBox1, $"Layer {listBox1.Items.Count + 1}");
                this.Controls.Add(layer.newLayer);
                layer.newLayer.BringToFront();


                layer.newLayer.MouseDown += pictureBox2_MouseDown;
                layer.newLayer.MouseMove += pictureBox2_MouseMove;
                layer.newLayer.MouseUp += pictureBox2_MouseUp;
            }*/
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gr.Clear(Color.White);
        }

        private void pictureBox_MouseDown(object sender, MouseEventArgs e)
        {

            MouseDown = true;
        }

        private void pictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (MouseDown && modeDraw.Checked)
            {
                int index = listBox1.SelectedIndex;
                if (index < 0) return;
                Layer activeL = layers[index];
                
                Graphics grep = Graphics.FromImage(activeL.BmpL);
                grep.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                grep.FillEllipse(brush, e.X, e.Y, pen.Width, pen.Width);
                pictureBox1.Image = MergeLayers(panel1.Width, panel1.Height);

            }
        }

        private void pictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            MouseDown = false;  
        }

        private void newLayerButton_Click(object sender, EventArgs e)
        {
            newLayer("New Layer");
        }

        public void newLayer(string Name)
        {
            Layer newLayer = new Layer(panel1, Name);
            layers.Add(newLayer);
            if (listBox1.Items.Contains(newLayer.Name))
            {
                listBox1.Items.Add(newLayer.Name + $"{listBox1.Items.Count}");
            }
            else
            {
                listBox1.Items.Add(newLayer.Name);
            }

            pictureBox1.Image = MergeLayers(panel1.Width, panel1.Height);
        }
        public Bitmap MergeLayers(int width, int height)
        {
            Bitmap finalImage = new Bitmap(width, height);
            using (Graphics g = Graphics.FromImage(finalImage))
            {
                g.Clear(Color.Transparent);

                foreach (Layer layer in layers)
                {
                    layer.Draw(g);
                }
            }

            return finalImage;
        }

        private void DeleteLayerButton_Click(object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex;
            if (index < 0) return;
            Layer activeL = layers[index];

            Graphics grep = Graphics.FromImage(activeL.BmpL);
            grep.Clear(Color.Transparent);  
            pictureBox1.Image = MergeLayers(panel1.Width, panel1.Height);
            listBox1.Items.Remove(index);
            
            layers.Remove(activeL);
            updateListB();
        }

        private void clearToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex;
            if (index < 0) return;
            Layer activeL = layers[index];

            Graphics grep = Graphics.FromImage(activeL.BmpL);
            grep.Clear(Color.Transparent);
            pictureBox1.Image = MergeLayers(panel1.Width, panel1.Height);
        }

        private void exportToolStripMenuItem_Click(object sender, EventArgs e)
        {

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = @"PNG|*.png";
            DialogResult res = saveFileDialog.ShowDialog();
            if (res == DialogResult.OK)
            {
                String fileName = saveFileDialog.FileName;
                pictureBox1.Image.Save(fileName);
            }
            }
        bool controlP = false;
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && Keys.Control == Keys.S)
            {
                exportToolStripMenuItem.PerformClick();
            }
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void SineButton_Click(object sender, EventArgs e)
        {
            Layer newLayer = new Layer(panel1, "Sine");
            layers.Add(newLayer);
            if (listBox1.Items.Contains(newLayer.Name))
            {
                listBox1.Items.Add(newLayer.Name + $"{listBox1.Items.Count}");
            }
            else
            {
                listBox1.Items.Add(newLayer.Name);
            }
            Graphics gr = Graphics.FromImage(newLayer.BmpL);
            
            SinCreate sin = new SinCreate();
            sin.Initialize(0.0, 50, 10, gr, panel1, pen);
                pictureBox1.Image = MergeLayers(panel1.Width, panel1.Height);
        }
    }
}
