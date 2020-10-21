using System;
using System.Windows.Forms;

namespace Practica1
{
    public partial class Maquina : Form
    {
        double saldo = 0;
        double ValorIngresado = 0;

        public Maquina()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txValorRetiro_TextChanged(object sender, EventArgs e)
        {

        }

        private void btCalcular_Click(object sender, EventArgs e)
        {
            double sobrante = 0;
            double cantidad1 = 0;
            double cantidad2 = 0;
            double cantidad3 = 0;
            double cantidad4 = 0;



            ValorIngresado = double.Parse(txValorRetiro.Text);
            if (saldo <= 0)
            {
                btCalcular.Enabled = false;
            }

            if (saldo < ValorIngresado)
            {
                MessageBox.Show("El Valor del saldo es insuficiente para el retiro");
               
                


            }else if (ValorIngresado > 400000)
            {
                MessageBox.Show("No esta permitido este valor de retiro");
            }

            else if (ValorIngresado >= 50000 && ValorIngresado <= 400000)
            {


                sobrante = ValorIngresado % 50000;
                cantidad1 = Math.Floor(ValorIngresado / 50000);

                if (sobrante >= 20000)
                {
                    cantidad2 = Math.Floor(sobrante / 20000);
                    sobrante = sobrante % 20000;

                    if (sobrante >= 10000)
                    {
                        cantidad3 = Math.Floor(sobrante / 10000);
                        sobrante = sobrante % 10000;

                        if (sobrante >= 5000)
                        {
                            cantidad4 = Math.Floor(sobrante / 5000);
                            sobrante = sobrante % 5000;


                        }


                    }


                }

                if (sobrante >= 10000 && sobrante < 20000)
                {
                    cantidad3 = Math.Floor(sobrante / 10000);
                    sobrante = sobrante % 10000;

                    if (sobrante >= 5000)
                    {
                        cantidad4 = Math.Floor(sobrante / 5000);
                        sobrante = sobrante % 5000;


                    }


                }


                if (sobrante >= 5000 && sobrante < 10000)
                {
                    cantidad4 = Math.Floor(sobrante / 5000);
                    sobrante = sobrante % 5000;


                }

                if (sobrante >= 2500 && sobrante < 5000)
                {
                    cantidad4 += 1;
                }





                gbResultado.Enabled = true;
                btIngresar.Enabled = false;

                txSalida.Text = "La cantidad de billetes de $50000 es : " + cantidad1 + "\r\n" +
                            "La cantidad de billetes de $20000 es : " + cantidad2 + "\r\n" +
                            "La cantidad de billetes de $10000 es : " + cantidad3 + "\r\n" +
                            "La cantidad de billetes de $5000 es : " + cantidad4 + "\r\n\r\n";

                saldo = saldo - ValorIngresado;
                txSaldo.Text = Convert.ToString(saldo);
                MessageBox.Show("Su saldo actual es : " + saldo);

            }




            #region 20000
            if (ValorIngresado >= 20000 && ValorIngresado < 50000)
            {
                cantidad2 = Math.Floor(ValorIngresado / 20000);
                sobrante = ValorIngresado % 20000;

                if (sobrante >= 10000)
                {
                    cantidad3 = Math.Floor(sobrante / 10000);
                    sobrante = sobrante % 10000;

                    if (sobrante >= 5000)
                    {
                        cantidad4 = Math.Floor(sobrante / 5000);
                        sobrante = sobrante % 5000;

                    }
                }

                if (sobrante >= 5000)
                {
                    cantidad4 = Math.Floor(sobrante / 5000);
                    sobrante = sobrante % 5000;

                }

                if (sobrante >= 2500 && sobrante < 5000)
                {
                    cantidad4 += 1;
                }


                gbResultado.Enabled = true;

                txSalida.Text = "La cantidad de billetes de $20000 es : " + cantidad2 + "\r\n" +
                            "La cantidad de billetes de $10000 es : " + cantidad3 + "\r\n" +
                            "La cantidad de billetes de $5000 es : " + cantidad4 + "\r\n\r\n";

                saldo = saldo - ValorIngresado;
                txSaldo.Text = Convert.ToString(saldo);
                MessageBox.Show("Su saldo actual es : " + saldo);


            }

            #endregion

            #region 10000
            if (ValorIngresado >= 10000 && ValorIngresado < 20000)
            {
                cantidad3 = Math.Floor(ValorIngresado / 10000);
                sobrante = ValorIngresado % 10000;

                if (sobrante >= 5000)
                {
                    cantidad4 = Math.Floor(sobrante / 5000);
                    sobrante = sobrante % 5000;

                }

                if (sobrante >= 2500 && sobrante < 5000)
                {
                    cantidad4 += 1;
                }

                gbResultado.Enabled = true;

                txSalida.Text = "La cantidad de billetes de $10000 es : " + cantidad3 + "\r\n" +
                                "La cantidad de billetes de $5000 es : " + cantidad4 + "\r\n\r\n";

                saldo = saldo - ValorIngresado;
                txSaldo.Text = Convert.ToString(saldo);
                MessageBox.Show("Su saldo actual es : " + saldo);


            }

            #endregion

            #region 5000
            if (ValorIngresado >= 5000 && ValorIngresado < 10000)
            {
                cantidad4 = Math.Floor(ValorIngresado / 5000);
                sobrante = ValorIngresado % 5000;

                if (sobrante >= 2500 && sobrante < 5000)
                {
                    cantidad4 += 1;
                }


                gbResultado.Enabled = true;
                txSalida.Text = "La cantidad de billetes de $5000 es : " + cantidad4 + "\r\n";

                saldo = saldo - ValorIngresado;
                txSaldo.Text = Convert.ToString(saldo);
                MessageBox.Show("Su saldo actual es : " + saldo);

            }


            #endregion

            
            if (ValorIngresado >= 0 && ValorIngresado < 5000)
            {


                if (ValorIngresado >= 2500 &&   Convert.ToDouble(ValorIngresado)< 5000)
                {
                    cantidad4 += 1;
                } else 
                {
                    cantidad4 = 0;
                }


                gbResultado.Enabled = true;
                txSalida.Text = "La cantidad de billetes de $5000 es : " + cantidad4 + "\r\n";

                saldo = saldo - ValorIngresado;
                txSaldo.Text = Convert.ToString(saldo);
                MessageBox.Show("Su saldo actual es : " + saldo);

            }


        } 

        private void btIngresar_Click(object sender, EventArgs e)
        {
          
            saldo = double.Parse(txSaldo.Text);
            btCalcular.Enabled = true;
            txSaldo.Text = "";
            txSaldo.ReadOnly = true;
        }
    }
}
