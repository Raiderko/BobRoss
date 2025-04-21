using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BobRoss
{
    public partial class SineConstructor : Form
    {
        public double Angle {  get; set; }
        public double Freq { get; set; }
        public double Amp { get; set; }
        public Form1 ParentForm {  get; set; }
        public SineConstructor()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Angle = Convert.ToDouble(AngBox.Text);
                Freq = Convert.ToDouble(FreqBox.Text);
                Amp = Convert.ToDouble(AmpBox.Text);
                ParentForm.button3.PerformClick();
                this.Close();
                
                
            }
            catch (Exception ex) { MessageBox.Show("Please put a value in double!", ex.Message); }
        }
    }
}
