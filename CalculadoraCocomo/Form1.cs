using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraCocomo
{
    public partial class Form1 : Form
    {
        double a, b, c, d;

        public Form1()
        {
            InitializeComponent();
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int temp = 0;

            if (int.TryParse(txtLineasCod.Text, out temp))
            {
                if (int.TryParse(txtEntradaFlu.Text, out temp))
                {
                    if (int.TryParse(txtSalidasFlu.Text, out temp))
                    {
                        if (int.TryParse(txtchm.Text, out temp))
                        {
                            dataCocomo.Rows.Clear();
                            calcular(Convert.ToInt32(txtLineasCod.Text), Convert.ToInt32(txtEntradaFlu.Text),
                                Convert.ToInt32(txtSalidasFlu.Text), Convert.ToInt32(txtchm.Text));
                        }
                    }
                    else
                    {
                        MessageBox.Show("Introduzca un Número entero", "Flujo de Salidas");
                    }
                }
                else
                {
                    MessageBox.Show("Introduzca un Número entero", "Flujo de Entradas");
                }
            }
            else
            {
                MessageBox.Show("Introduzca un Número entero","Lineas de Codigo");
            }



        }

        public void calcular(int L, int fde, int fds, int chm)
        {
            //calculo de LCD
            
            double lcd = L*(fde+fds);
            double mlcd = lcd/1000;
            lcd = Math.Round(lcd, 2);
            this.dataCocomo.Rows.Insert(0, "Estimación de la Calidad de Instrucción",
                "LDC = L * FD E/S", lcd,"MLCD = "+mlcd  );

            if(mlcd  < 50){
                a = 3.2;
                b = 1.05;
                c = 2.5;
                d = 0.38;
            }
            if(mlcd  < 300 && mlcd  > 50){
                
                a = 3.0;
                b = 1.12;
                c = 2.5;
                d = 0.35;
            }
            if (mlcd  > 300)
            {
                a = 2.8;
                b = 1.20;
                c = 2.5;
                d = 0.32;
            }

            //Estimación de esfuerzo
            double esf = a * Math.Pow(mlcd, b);
            esf = Math.Round(esf, 2);
            this.dataCocomo.Rows.Insert(1, "Estimación del Esfuerzo",
                "LDC = a*MLCD^b", esf, "ESF = " + Math.Ceiling(esf) + " Persona/mes");

            //Estimación del tiempo de desarrolllo

            double tdes = c * Math.Pow(esf, d);
            tdes = Math.Round(tdes, 2);
            this.dataCocomo.Rows.Insert(2, "Estimación del Tiempo de Desarrollo",
                "TDES = c*ESF^d", tdes, "TDES = " + Math.Ceiling(tdes) + " Meses");

            //Estimación del personal necesario

            double cp = esf / tdes;
            cp = Math.Round(cp, 2);
            this.dataCocomo.Rows.Insert(3, "Estimación del Personal Necesario",
                "CP = ESF / TDES", cp , "CP = " + Math.Ceiling(cp) + " Personas");
            
            //Estimación de productividad
            double p = lcd / esf;
            p = Math.Round(p, 2);

            this.dataCocomo.Rows.Insert(4, "Estimación de Productividad",
                "P = LCD / ESF", p, "P = " + Math.Ceiling(p) + " Instrucciones / Personas_mes");

            //Estimación de Costo
            double cos = esf * chm;
            cos = Math.Round(cos, 2);
            this.dataCocomo.Rows.Insert(5, "Estimación de Costo",
                "COSTO = ESF * CHM", cos, "COSTO = " + cos + " Bs.");


        }
    }

}
