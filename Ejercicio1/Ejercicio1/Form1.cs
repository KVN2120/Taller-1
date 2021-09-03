using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a = Double.Parse(v1.Text);
            double b = Double.Parse(v2.Text);
            double c = Double.Parse(v3.Text);

            double valor1, valor2, f;
            f = Math.Pow(b, 2);
            valor1 = (-b + (Math.Sqrt(f - 4 * a * c))) / (2 * a);
            valor2 = (-b - (Math.Sqrt(f - 4 * a * c))) / (2 * a);
            this.x1.Text = valor1.ToString();
            this.x2.Text = valor2.ToString();



        }
    }
}
