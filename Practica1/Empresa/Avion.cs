using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1.Empresa
{
    class Avion : Herencia
    {
        string THabitacion = "";
        double ValMillas = 0;
        double ValTasaAer = 0;
        double ValTranspAero=0;

        public Avion(string destino, string nombre, double cedula, int diasEsta, DateTime fechaViaje, double valorTransporte,
            int millas, double valMillas, double valTasaAer, double valTranspAero, string THabitacion) : base(destino, nombre, cedula, diasEsta, fechaViaje, valorTransporte, millas)

        {
            this.THabitacion = THabitacion;
            this.ValMillas = valMillas;
            this.ValTasaAer = valTasaAer;
            this.ValTranspAero = valTranspAero;

        }

        public Avion()
        {

        }

        #region GETTER AND SETTERS

        public void setTHabitacion(string tHabitacion)
        {
            this.THabitacion = tHabitacion;
        }

        public string getTHabitacion()
        {
            return THabitacion;
        }

        public void setValTasaAer(double valTasaAer)
        {
            this.ValTasaAer = valTasaAer;
        }
        public double getValTasaAer()
        {
            return ValTasaAer;
        }


        public void setValTranspAero(double valTranspAero)
        {
            this.ValTranspAero = valTranspAero;
        }

        public double getValTranspAero()
        { 
            return ValTranspAero;
        }
        


        public void setValMillas(double valMillas)
        {
            this.ValMillas = valMillas;
        }

        public double getValMillas()
        {
            return ValMillas;
        }


#endregion   
    }


}
