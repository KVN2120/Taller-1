using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio2._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Declaracion de variables
            double votos, candidato1, candidato2, candidato3, candidato4;

            int porcentaje1, porcentaje2, porcentaje3, porcentaje4;

            if (txtnumero.Text != "")
            {
                //inicializamos variables
                string txt = txtnumero.Text;
                candidato1 = 0;
                candidato2 = 0;
                candidato3 = 0;
                candidato4 = 0;

                //Uso del metodo Split, para poder separar el txtNumero y guardar cada valor dentro del arreglo datos
                string[] datos = txt.Split(',');

                //Uso del ciclo for para recorrer todos los votos
                for (int i = 0; i < datos.Length; i++)
                {
                    

                    if( datos[i] == "1" || datos[i] == " 1")
                    {
                        candidato1++; //aumentamos en 1 la variable para candidato 1
                    }else if (datos[i] == "2" || datos[i] == " 2")
                    {
                        candidato2++;
                    }
                    else if (datos[i] == "3" || datos[i] == " 3")
                    {
                        candidato3++;
                    }
                    else if (datos[i] == "4" || datos[i] == " 4")
                    {
                        candidato4++;
                    }
                    else
                    {
                        MessageBox.Show( "Voto Nulo: " + datos[i]);
                    }


                }

                //Sumamos todos los votos validos
                votos = candidato1 + candidato2 + candidato3 + candidato4;

                txtVotos.Text = votos.ToString();

                //Calculamos los porcentajes que obtuvo cada candidato
                porcentaje1 = (int)Math.Round((double)(100 * candidato1) / votos);
                porcentaje2 = (int)Math.Round((double)(100 * candidato2) / votos);
                porcentaje3 = (int)Math.Round((double)(100 * candidato3) / votos);
                porcentaje4 = (int)Math.Round((double)(100 * candidato4) / votos);

                //Imprimimos los valores en los textbox para cada candidato
                txtcandidato1.Text = "Votos: " + candidato1.ToString() + "- Porcentaje: " + porcentaje1.ToString() + " %";
                txtcandidato2.Text = "Votos: " + candidato2.ToString() + "- Porcentaje: " + porcentaje2.ToString() + " %";
                txtcandidato3.Text = "Votos: " + candidato3.ToString() + "- Porcentaje: " + porcentaje3.ToString() + " %";
                txtcandidato4.Text = "Votos: " + candidato4.ToString() + "- Porcentaje: " + porcentaje4.ToString() + " %";

            }
            else
            {
                MessageBox.Show(" Por favor, ingresa un dato" );
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtnumero.Clear();
            txtVotos.Clear();
            txtcandidato1.Clear();
            txtcandidato2.Clear();
            txtcandidato3.Clear();
            txtcandidato4.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

      
        }

        
    }

