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

namespace Ejercicio3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        String datos = "", num="";
        int mayor = 0, menor = 0;

        
        private void button4_Click(object sender, EventArgs e)
        {
            datos = Interaction.InputBox("Numeros que va a ingresar", "Numeros");

            for (int x = 0; x < Convert.ToInt16(datos); x++)
            {

                num = Interaction.InputBox("Ingrese el numero" + (x + 1));
                if (Convert.ToInt16(num) <= 0)
                {
                    MessageBox.Show("Debe ingresar un numero valido", "Error");

                    return;
                }

                    if (Convert.ToUInt16(num) >=200)
                {
                    MessageBox.Show("Debe ingresar un numero valido", "Error");

                    return;
                }
                    if (Convert.ToInt16(mayor) < 50)
                    {
                        menor = Convert.ToInt16(num)-5;
                    }

                    if (Convert.ToInt16(menor) > 10)
                    {
                        mayor = Convert.ToInt16(num) + 10;
                    }
                if (x == 0)
                {
                    mayor = Convert.ToInt16(num);
                    menor = Convert.ToInt16(num);
                }
                   

                else
                {
                    //Mayor numero obtener
                    if (Convert.ToInt16(num) > mayor) 
                    {
                        mayor = Convert.ToInt16(num);
                    }


                    //Menor numero 
                    if (Convert.ToInt16(num) < menor) 
                    {
                        menor = Convert.ToInt16(num);
                    }

                    
                   
                
                }
                lstelementos.Items.Add(num);
            }
            
       }

        private void button1_Click(object sender, EventArgs e)
        {
            txtmenor.Text = Convert.ToString(menor);
            txtmayor.Text = Convert.ToString(mayor);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtmayor.Text = String.Empty;
            txtmenor.Text = String.Empty;
            lstelementos.Items.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    
       
    }

}
