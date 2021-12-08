using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Numerics;

namespace Numeros
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool respuesta = false;
            int valor = 0;
            int i = 0;

            try
            {
                valor = Convert.ToInt32(TxtValor.Text.ToString());

                int[] arreglo = new int[valor];
                bool[] ArrRespuesta = new bool[valor];
                string[] texto = TxtLinea.Text.Split(",");

                if (valor < 33)
                {
                    double[] arreglos = Array.ConvertAll(texto, s => double.Parse(s));

                    foreach (double a in arreglos)
                    {

                        respuesta = numeroPerfecto(a);
                        ArrRespuesta[i] = respuesta;
                        i++;
                    }

                    TxtSalida.Text = string.Join(",", ArrRespuesta);
                }
                else
                {
                    MessageBox.Show("No se puede evaluar más de 33 números");
                }

            }

            catch (Exception ex)
            {
                TxtLinea.Text = "";
                TxtValor.Text = "";
                MessageBox.Show("Error: " + ex.ToString());
            }
            
                        
        }

        public bool numeroPerfecto(double valor)
        {
            bool respuesta = false;
            respuesta = EsPrimo(Math.Pow(2, valor)-1);

            return respuesta;
        }

        public bool EsPrimo(double valor)
        {
            if (valor == 0 || valor == 1)
            {
                return false;
            }
            else if(valor == 4)
            {
                return false;
            }
            else
            {
                for (int i = 2; i < valor / 2; i++)
                {                    
                    if (valor % i == 0)
                    {
                        return false;
                    }
                }
            }

            return true;
                
        }
    }

    
}
