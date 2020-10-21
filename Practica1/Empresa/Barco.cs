using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1.Empresa
{
    class Barco : Herencia
    {
        int diasViaje = 0;
        double ValTranspAMuelle =0;
        double ValorMillasBarco = 0;
        int MillasBarco = 0;
        string TCamarote = "";

        public Barco(string destino, string nombre, double cedula,  int diasEsta, DateTime fechaViaje, double valorTransporte,
           int millas, double ValTranspAMuelle,int diasViaje, double valorMillasBarco,int millasBarco, string tCamarote) : base(destino, nombre, cedula,  diasEsta, fechaViaje, valorTransporte,millas)
        {
            this.MillasBarco = millasBarco;
            this.diasViaje = diasViaje;
            this.ValTranspAMuelle = ValTranspAMuelle;
            this.ValorMillasBarco = valorMillasBarco;
            this.TCamarote = tCamarote;
        }

        public Barco()
        {
        }




        #region GETTER AND SETTERS

        public void setTCamarote(string tCamarote)
        {
            this.TCamarote = tCamarote;
        }

        public string getTCamarote()
        {
            return TCamarote;
        }

       
        public void setMillasBarco(int millasBarco)
        {
            this.MillasBarco = millasBarco;
        }

        public int getMillasBarco()
        {
            return MillasBarco;
        }



        public void setValorMillasBarco(double valorMillasBarco)
        {
            this.ValorMillasBarco = valorMillasBarco;
        }

        public double getValorMillasBarco()
        {
            return ValorMillasBarco;
        }


        public void setDiasViaje(int diasViaje)
        {
            this.diasViaje = diasViaje;
        }

        public int getDiasViaje()
        {
            return diasViaje;
        }
       
        public void setValTranspAMuelle(double ValTranspAMuelle)
        {
            this.ValTranspAMuelle = ValTranspAMuelle;
        }

        public double getValTranspAMuelle()
        {
            return ValTranspAMuelle;
        }
        #endregion

    }

}
