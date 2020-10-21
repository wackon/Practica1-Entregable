using Practica1.Empresa;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica1
{
    public partial class Tours : Form
    {

        Herencia objH = new Herencia();
        Avion objA = new Avion();
        Barco objB = new Barco();
        double Camarote = 0;
        double Habitacion = 0;
        double valor = 0;
        

        public Tours()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        public void validarDestino()
        {


        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (rbAvion.Checked)
            {
                btIngDestino.Enabled = true;
                gbInfo.Enabled = true;
                txDiasDViaje.Enabled = false;
                txNom.Enabled = false;
                txCed.Enabled = false;
                gbTranspB.Enabled = false;
                btCalcular.Enabled = false;
                btEnviar.Enabled = false;
                txSalidaFinal.Text = "";


                MessageBox.Show("A continuación adjunte el destino de Viaje");


            }
            else if (rbbarco.Checked)
            {
                btIngDestino.Enabled = true;
                gbInfo.Enabled = true;
                txNom.Enabled = false;
                txCed.Enabled = false;
                gbTransAv.Enabled = false;
                gbTranspB.Enabled = false;
                txDiasDViaje.Enabled = true;
                btCalcular.Enabled = false;
                btEnviar.Enabled = false;
                txSalidaFinal.Text = "";

                MessageBox.Show("A continuación adjunte el destino de Viaje");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            #region AVION


            if (rbAvion.Checked)
            {

                try
                {
                    //validando campos nulos


                    if (string.IsNullOrEmpty(txNom.Text) || string.IsNullOrEmpty(txCed.Text) || string.IsNullOrEmpty(txDest.Text)
                       || string.IsNullOrEmpty(txDiasEstadia.Text) || string.IsNullOrEmpty(txValMil.Text)
                       || string.IsNullOrEmpty(txTasaAero.Text) || string.IsNullOrEmpty(txTransAe.Text) ||
                       string.IsNullOrEmpty(txMillasCliente.Text) || string.IsNullOrEmpty(Convert.ToString(dateTimePicker1.Value)))
                    {
                        MessageBox.Show("Debe diligenciar todo el formulario");
                    }
                    else
                    {
                        //enviando a constructores

                        objH.setNombre(txNom.Text);

                        objH.setCedula(Convert.ToDouble(txCed.Text));

                        objH.setDestino(txDest.Text);

                        objH.setDiasEsta(Convert.ToInt32(txDiasEstadia.Text));

                        objH.setMillas(Convert.ToInt32(txMillasCliente.Text));

                        objA.setValMillas(Convert.ToInt32(txValMil.Text));

                        objA.setValTasaAer(Convert.ToDouble(txTasaAero.Text));

                        objA.setValTranspAero(Convert.ToDouble(txTransAe.Text));

                        objH.setFechaViaje(dateTimePicker1.Value);


                        //Validacion tipo de Habitacion

                        if (rbSuite.Checked == true)
                        {
                            objA.setTHabitacion("suite");
                        }

                        if (rbHabNorm.Checked == true)
                        {
                            objA.setTHabitacion("normal");
                        }

                    }
                }
                catch (FormatException fe)
                {
                    MessageBox.Show("El valor ingresado no es el esperado" + fe);
                }


                 if (objA.getTHabitacion() == "suite")
                {
                    Habitacion = Convert.ToDouble(objH.getDiasEsta() * 120000);
                    txSalidaFinal.Text = "El valor total por consepto de Habitacion es : " + Habitacion + "\r\n";

                }
                else if (objA.getTHabitacion() == "normal")
                {
                    Habitacion = Convert.ToDouble(objH.getDiasEsta() * 60000);
                    txSalidaFinal.Text = "El valor total por consepto de Habitacion es : " + Habitacion + "\r\n";
                }

                double VM = (objA.getValMillas() * Convert.ToDouble(objH.getMillas()));
                double VImp = (objA.getValTranspAero() + objA.getValTasaAer());
                double Total = (Habitacion + VImp + valor) - VM;
               



                txSalidaFinal.Text = "El servicio se reservara para el dia " +Convert.ToString(objH.getFechaViaje())+"\r\n" +
                    "El valor por servicio de habitacion es : $ " + Habitacion + "\r\n" +
                    "El cliente tiene un valor acumulado por millas de : $ " + VM + "\r\n" +
                    "Valores por tasa aeropuertuaria y transporte aeropuerto de : $" + VImp + "\r\n" +
                    "Con un valor de tiquete fijo de viaje de hacia : " + txDest.Text + " por un valor de : $ " + valor + "\r\n" +
                    "Realizados los descuentos por valor de millas al cliente, el valor a cancelar por este es de \r\n" +
                    " $ " + Total;


                txNom.Text = "";
                txCed.Text = "";
                txDest.Text = "";
                txDiasEstadia.Text = "";
                txDiasDViaje.Text = "";
                txMillasCliente.Text = "";
                txValMil.Text = "";
                txTasaAero.Text = "";
                txTransAe.Text = "";
                txTransMu.Text = "";
                txValor.Text = "";
                gbFecha.Enabled = false;
                gbTransAv.Enabled = false;
                gbTranspB.Enabled = false;
                gbInfo.Enabled = false;
                gbTipoCama.Enabled = false;
                gbTipoHab.Enabled = false;
                btEnviar.Enabled = true;

            }
            #endregion

            #region BARCO
            else if (rbbarco.Checked)
            {
                try
                {
                    //validando campos nulos


                    if (string.IsNullOrEmpty(txNom.Text) || string.IsNullOrEmpty(txCed.Text) || string.IsNullOrEmpty(txDest.Text)
                        || string.IsNullOrEmpty(txDiasDViaje.Text) || string.IsNullOrEmpty(txTransMu.Text)
                       || string.IsNullOrEmpty(txMillasBarco.Text) || string.IsNullOrEmpty(txValorMBarco.Text)
                       || string.IsNullOrEmpty(Convert.ToString(dateTimePicker1.Value)))
                    {
                        MessageBox.Show("Debe diligenciar todo el formulario");
                    }
                    else
                    {
                        //enviando a constructores

                        objH.setNombre(txNom.Text);

                        objH.setCedula(Convert.ToDouble(txCed.Text));

                        objH.setDestino(txDest.Text);

                        objB.setDiasViaje(Convert.ToInt32(txDiasDViaje.Text));

                        objB.setValorMillasBarco(Convert.ToDouble(txValorMBarco.Text));

                        objB.setMillasBarco(Convert.ToInt32(txMillasBarco.Text));

                        objB.setValTranspAMuelle(Convert.ToDouble(txTransMu.Text));

                        objH.setFechaViaje(dateTimePicker1.Value);


                        if (rbLujo.Checked == true)
                        {
                            objB.setTCamarote("lujo");
                                                    }

                        if (rbNormal.Checked == true)
                        {
                            objB.setTCamarote("normal");
                        }

                        if (rbEconomco.Checked == true)
                        {
                            objB.setTCamarote("economico");
                        }

                        
                    }
                }
                catch (FormatException fe)
                {
                    MessageBox.Show("El valor ingresado no es el esperado" + fe);
                }



                if (objB.getTCamarote() == "lujo")
                {
                    Camarote = Convert.ToDouble(objB.getDiasViaje() * 90000);
                    txSalidaFinal.Text = "El valor total por consepto de Camarote es : " + Camarote + "\r\n";

                }
                else if (objB.getTCamarote() == "normal")
                {
                    Camarote = Convert.ToDouble(objB.getDiasViaje() * 70000);
                    txSalidaFinal.Text = "El valor total por consepto de Camarote es : " + Camarote + "\r\n";
                }
                else if (objB.getTCamarote() == "economico")
                {
                    Camarote = Convert.ToDouble(objB.getDiasViaje() * 50000);
                    txSalidaFinal.Text = "El valor total por consepto de Camarote es : " + Camarote + "\r\n";
                }
               

                double VM = (objB.getValorMillasBarco() * Convert.ToDouble(objB.getMillasBarco()));
                double VImp = objB.getValTranspAMuelle();
                double Total = (Camarote + VImp + valor) - VM;




                txSalidaFinal.Text = "El servicio se reservara para el dia " + Convert.ToString(objH.getFechaViaje()) + "\r\n" +
                    "El valor por el servicio de Tipo de Camarote es : $ " + Camarote + "\r\n" +
                                     "El cliente tiene un valor acumulado por millas de: $ " + VM + "\r\n" +
                    "El valor de transporte al muelle es de un valor : $ " + VImp + "\r\n" +
                    "Con un valor de tiquete fijo de viaje de hacia " + txDest.Text + " por un valor de : $ " + valor + "\r\n" +
                    "Realizados los descuentos por valor de millas al cliente el valor a cancelar por este es de \r\n" +
                    " $ " + Total;


                txNom.Text = "";
                txCed.Text = "";
                txDest.Text = "";
                txDiasEstadia.Text = "";
                txDiasDViaje.Text = "";
                txValorMBarco.Text = "";
                txMillasBarco.Text = "";
                txTransMu.Text = "";
                txValor.Text = "";
                gbFecha.Enabled = false;
                gbTransAv.Enabled = false;
                gbTranspB.Enabled = false;
                gbInfo.Enabled = false;
                gbTipoCama.Enabled = false;
                gbTipoHab.Enabled = false;
                btEnviar.Enabled = true;

                #endregion
            }

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txDest.Text))
            {
                MessageBox.Show("Debe Seleccionar el lugar a Viajar para continuar");
                btEnviar.Enabled = true;

            }
            else if (!string.IsNullOrEmpty(txDest.Text))
            {


                if (rbAvion.Checked)
                {

                    
                    gbInfo.Enabled = true;
                    gbTipoCama.Enabled = false;
                    gbTipoHab.Enabled = true;
                    gbFecha.Enabled = true;
                    gbTransAv.Enabled = true;
                    txDiasDViaje.Enabled = false;
                    txNom.Enabled = true;
                    txCed.Enabled = true;
                    gbTranspB.Enabled = false;

                    btCalcular.Enabled = true;

                    if (txDest.Text == "Berlin")
                    {
                        valor = 5000000;
                        txValor.Text = Convert.ToString(valor);
                    }
                    if (txDest.Text == "Londres")
                    {
                        valor = 4000000;
                        txValor.Text = Convert.ToString(valor);

                    }
                    if (txDest.Text == "Praga")
                    {

                        valor = 6000000;
                        txValor.Text = Convert.ToString(valor);
                    }
                    if (txDest.Text == "Roma")
                    {

                        valor = 5500000;
                        txValor.Text = Convert.ToString(valor);

                    }
                }
                else if (rbbarco.Checked)
                {

                    gbInfo.Enabled = true;
                    gbTipoCama.Enabled = true;
                    gbTipoHab.Enabled = false;
                    gbFecha.Enabled = true;
                    gbTranspB.Enabled = true;
                    txNom.Enabled = true;
                    txCed.Enabled = true;
                    txDiasEstadia.Enabled = false;
                    gbTransAv.Enabled = false;
                    txDiasDViaje.Enabled = true;
                    btCalcular.Enabled = true;


                    if (txDest.Text == "Berlin")
                    {
                        valor = 4000000;
                        txValor.Text = Convert.ToString(valor);
                    }
                    if (txDest.Text == "Londres")
                    {
                        valor = 3000000;
                        txValor.Text = Convert.ToString(valor);

                    }
                    if (txDest.Text == "Praga")
                    {

                        valor = 7000000;
                        txValor.Text = Convert.ToString(valor);
                    }
                    if (txDest.Text == "Roma")
                    {

                        valor = 5500000;
                        txValor.Text = Convert.ToString(valor);

                    }
                }
            }

            txDest.Text = "";
            btIngDestino.Enabled = false;
        }

        private void txvalDiaBarco_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            
        }
    }


}





