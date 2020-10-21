using System;
using System.Windows.Forms;

namespace Practica1
{
    public partial class Nomina : Form
    {
        double nominaT = 0;
        double retencionT = 0;
        double segS = 0;
        int contador = 0;

        public Nomina()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double mes1 = 0;
            double mes2 = 0;
            double mes3 = 0;
            double mes4 = 0;
            double mes5 = 0;
            double mes6 = 0;

            

            try
            {

                if (string.IsNullOrEmpty(txHoras1.Text))
                {
                    MessageBox.Show("no ha ingresado la cantidad de horas para el mes 1");
                }
                else
                {
                    mes1 = Double.Parse(txHoras1.Text);
                }

                if (string.IsNullOrEmpty(txHoras2.Text))
                {
                    MessageBox.Show("no ha ingresado la cantidad de horas para el mes 2");
                }
                else
                {
                    mes2 = Double.Parse(txHoras2.Text);
                }

                if (string.IsNullOrEmpty(txHoras3.Text))
                {
                    MessageBox.Show("no ha ingresado la cantidad de horas para el mes 3");
                }

                else
                {
                    mes3 = Double.Parse(txHoras3.Text);
                }

                if (string.IsNullOrEmpty(txHoras4.Text))
                {
                    MessageBox.Show("no ha ingresado la cantidad de horas para el mes 4");
                }
                else
                {
                    mes4 = Double.Parse(txHoras4.Text);
                }

                if (string.IsNullOrEmpty(txHoras5.Text))
                {
                    MessageBox.Show("no ha ingresado la cantidad de horas para el mes 5");
                }
                else
                {
                    mes5 = Double.Parse(txHoras5.Text);
                }

                if (string.IsNullOrEmpty(txHoras6.Text))
                {
                    MessageBox.Show("no ha ingresado la cantidad de horas para el mes 6");
                }
                else
                {
                    mes6 = Double.Parse(txHoras6.Text);
                }

                               

                if (rbA.Checked == true)
                {

                    double Valor = (mes1 + mes2 + mes3 + mes4 + mes5+ mes6) * 24000;
                    double dctoRTF = (Valor * 0.1);
                    double dctoSS= (Valor * 0.09);
                    double ValorRtF = Valor - dctoRTF;
                    double ValorSS = Valor - dctoSS;
                    nominaT = nominaT + Valor;
                    retencionT += ValorRtF;
                    segS += ValorSS;
                    contador += 1;
                    txSalida.Text = "El valor pagado al profesor por el semestre es " + Valor + " Con un descuento de " + dctoRTF + "" +
                        " por concepto de retencion y un descuento de " + dctoSS + " por concepto de Seguridad Social";


                } else if (rbB.Checked == true)
                {

                    double Valor = (mes1 + mes2 + mes3 + mes4 + mes5 + mes6) * 18200;
                    double dctoRTF = (Valor * 0.1);
                    double dctoSS = (Valor * 0.09);
                    double ValorRtF = Valor - dctoRTF;
                    double ValorSS = Valor - dctoSS;
                    nominaT = nominaT + Valor;
                    retencionT += ValorRtF;
                    segS += ValorSS;
                    contador += 1;
                    txSalida.Text = "El valor pagado al profesor por el semestre es " + Valor + " Con un descuento de " + dctoRTF + "" +
                       " por concepto de retencion y un descuento de " + dctoSS + " por concepto de Seguridad Social";

                } else if (rbC.Checked == true) {

                    double Valor = (mes1 + mes2 + mes3 + mes4 + mes5 + mes6) * 15000;
                    double dctoRTF = (Valor * 0.1);
                    double dctoSS = (Valor * 0.09);
                    double ValorRtF = Valor - dctoRTF;
                    double ValorSS = Valor - dctoSS;
                    nominaT = nominaT + Valor;
                    retencionT += ValorRtF;
                    segS += ValorSS;
                    contador += 1;
                    txSalida.Text = "El valor pagado al profesor por el semestre es " + Valor + " Con un descuento de " + dctoRTF + "" +
                        " por concepto de retencion y un descuento de " + dctoSS + " por concepto de Seguridad Social";

                } else if (rbD.Checked == true)
                {

                    double Valor = (mes1 + mes2 + mes3 + mes4 + mes5 + mes6) * 12500;
                    double dctoRTF = (Valor * 0.1);
                    double dctoSS = (Valor * 0.09);
                    double ValorRtF = Valor - dctoRTF;
                    double ValorSS = Valor - dctoSS;
                    nominaT = nominaT + Valor;
                    retencionT += ValorRtF;
                    segS += ValorSS;
                    contador += 1;
                    txSalida.Text = "El valor pagado al profesor por el semestre es " + Valor + " Con un descuento de " + dctoRTF + "" +
                        " por concepto de retencion y un descuento de " + dctoSS + " por concepto de Seguridad Social";

                } 
            }
            catch (Exception)
            {
                MessageBox.Show("Ingrese solo valores númericos");
            }
            btCalcular.Enabled = false;
            gbresultado.Visible = true;

           
        }



        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            txSalida.Clear();
            btCalcular.Enabled = true;
        }

        private void txCategoria_TextChanged(object sender, EventArgs e)
        {

        }

        private void txSalida_TextChanged(object sender, EventArgs e)
        {

        }

        private void btTerminar_Click(object sender, EventArgs e)
        {
            gbresultado.Visible = true;
            txSalida.Text = "Total empleados procesados : " + contador + "\r\n" + "Total dinero de nomina : "+nominaT+ "\r\n"
                +"Total dinero recogido de retención en la fuente " +retencionT;;
            gbHoras.Enabled = false;
            


        }

        

        private void btSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}

