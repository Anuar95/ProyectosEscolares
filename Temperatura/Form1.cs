using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Temperatura
{
    public partial class Form1 : Form
    {

        double celsius,kelvin;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
        private void label3_Click(object sender, EventArgs e)
        {
            double convertir = Convert.ToDouble(textBox1.Text);
            celsius = 0.5555555556 * (convertir - 32);
            label3.Text = celsius.ToString();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            double convertir = Convert.ToDouble(textBox1.Text);
            kelvin = celsius + 273.15;
            label5.Text = kelvin.ToString();
            
        }
    }
}
