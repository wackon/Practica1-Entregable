using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1
{
    class Books
    {
        
        string Codigo = "";
        string Nombre = "";
        string Autor = "";
        bool Disponible = true;

        public Books(string Codigo,string Nombre, string Autor,bool Disponible)
        {
            this.Codigo= Codigo;
            this.Nombre = Nombre;
            this.Autor = Autor ;
            this.Disponible= Disponible;

        }



        public string getCodigo()
        {
            return Codigo;
        }

        public void setCodigo(string Codigo)
        {
            this.Codigo = Codigo;
        }

        public string getNombre()
        {
            return Nombre;
        }

        public void setNombre(string Nombre)
        {
            this.Nombre = Nombre;
        }

        public string getAutor()
        {
            return Autor;
        }

        public void setAutor(string Autor)
        {
            this.Autor = Autor;
        }

        public void setDisponible(bool Disponible)
        {
            this.Disponible = Disponible;
        }

        public bool getDisponible()
        {
            return Disponible;
        }

       }
}
