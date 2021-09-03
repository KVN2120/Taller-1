using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;


namespace Ejercicio_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cargo;
            int car;
            double  horastrabjadas,gerente, horasextra, impuesto, salariobase, salarioneto,  secretaria, asistente, empleado;
            try
            { 
                car=0;
                cargo = "";
                horastrabjadas = 9.75;
                horasextra = 11.50;
                gerente=0;
                horastrabjadas = Convert.ToDouble(txthorast.Text);
                horasextra = Convert.ToDouble(txthorasex.Text);
                salariobase = horastrabjadas * 9.75;
                
                
                impuesto = 22.1 % -salariobase;

                gerente = salariobase * 0.10;
                secretaria = salariobase * 0.3;
                asistente = salariobase * 0.5;

               
                

                if(horastrabjadas<=0)
                {
                    MessageBox.Show("Ingrese un numero de horas valido", "Error");
                    return;
                }

                if(horastrabjadas>=165)
                {
                    
                }
               

                salarioneto= salariobase - impuesto;
                txtsueldob.Text = salariobase.ToString();
                txtdes.Text = impuesto.ToString();
                txtsueldoliq.Text = salarioneto.ToString();
            }
            catch(Exception error)
            {
                MessageBox.Show("Error");
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach(Control datos in this.groupBox1.Controls)
            {
                if (datos is TextBox)
                    datos.Text = String.Empty;
            }
            foreach(Control res in this.groupBox2.Controls)
            {
                if(res is TextBox)
                {
                    res.Text = String.Empty;
                }
            }
            txtnombre.Focus();

        
        }

        private void button3_Click(object sender, EventArgs e)
        {

            Application.Exit();
        }

       
        
    }

    }

