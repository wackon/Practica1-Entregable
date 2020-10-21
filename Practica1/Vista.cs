using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Practica1
{
    public partial class Vista : Form
    {

        static int contador = 0;
        bool Disponible;

        Books[] vector = new Books[30];

        public Vista()
        {
            InitializeComponent();

        }

        private void btIngresar_Click(object sender, EventArgs e)
        {

            try
            {

                if (string.IsNullOrEmpty(txIngCod.Text) || string.IsNullOrEmpty(txIngNom.Text) || string.IsNullOrEmpty(txIngAut.Text))
                {

                    MessageBox.Show("Digite todos los campos");
                }
                else
                {

                    string Codigo = txIngCod.Text;
                    string Nombre = txIngNom.Text;
                    string Autor = txIngAut.Text;



                    if (rbDisponible.Checked == true)
                    {
                        Disponible = true;
                    }
                    else
                    {
                        Disponible = false;
                    }


                    vector[contador] = new Books(Codigo, Nombre, Autor, Disponible);



                    txIngCod.Text = "";
                    txIngNom.Text = "";
                    txIngAut.Text = "";
                    contador += 1;
                    gbConsultar.Enabled = true;

                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception caught.", ex);
            }
        }



        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txBusCod.Text))
            {
                System.Windows.Forms.MessageBox.Show("Ingrese un valor para la busqueda");
            }
            else
            {
                string cod = txBusCod.Text;
                int aux = 0;

                foreach (Books vec in vector)
                {

                    if (vec.getCodigo() == cod)
                    {
                        txBusNombre.Text = vec.getNombre();
                        txBusAut.Text = vec.getAutor();
                        txBusDisp.Text = Convert.ToString(vec.getDisponible());
                        break;

                    }
                    else
                    {
                        aux = aux + 1;
                        if (aux == contador)
                        {
                            MessageBox.Show("El código ingresado no se encuentra en nuestro sistema");
                            txBusNombre.Text = "";
                            txBusCod.Text = "";
                            txBusAut.Text = "";
                            txBusDisp.Text = "";
                            break;
                        }
                    }


                }

                gbGestionar.Enabled = true;
                gbEliminar.Enabled = true;




                /*

                if (contador == 0)
                {
                    System.Windows.Forms.MessageBox.Show("No existen Libros ingresados");

                }
                else if (string.IsNullOrEmpty(txBusCod.Text))
                {

                    System.Windows.Forms.MessageBox.Show("Ingrese un valor para la busqueda");

                }
                else
                {
                    string cod = txBusCod.Text;


                    for (int i = 0; i < vector.Length; i++)

                    {
                        if (cod == vector[i].getCodigo())
                        {

                            txBusNombre.Text = vector[i].getNombre();
                            txBusAut.Text = vector[i].getAutor();
                            txBusDisp.Text = Convert.ToString(vector[i].getDisponible());


                        }

                    }
                    gbGestionar.Enabled = true;
                    gbEliminar.Enabled = true;
                }*/
            }
        }



        private void txBusNom_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txBusNombre.Text))
            {
                System.Windows.Forms.MessageBox.Show("Ingrese un valor para la busqueda");
            }
            else
            {
                string nombre = txBusNombre.Text;
                int aux = 0;

                for (int i = 0; i <= vector.Length; i++)
                {


                    if (vector[i].getAutor() == nombre)
                    {
                        txBusCod.Text = vector[i].getCodigo();
                        txBusAut.Text = vector[i].getAutor();
                        txBusDisp.Text = Convert.ToString(vector[i].getDisponible());
                        break;
                    }
                    else
                    {
                        aux = aux + 1;
                        if (aux == contador)
                        {
                            MessageBox.Show("No se encontro un autor registrado con el nombre ingresado");
                            txBusNombre.Text = "";
                            txBusCod.Text = "";
                            txBusAut.Text = "";
                            txBusDisp.Text = "";
                            break;
                        }
                    }
                }

                gbGestionar.Enabled = true;
                gbEliminar.Enabled = true;



                /* if (string.IsNullOrEmpty(txBusNombre.Text))
                 {

                     System.Windows.Forms.MessageBox.Show("Ingrese un valor para la busqueda");

                 }
                 else
                 {
                     string nombre = txBusNombre.Text;


                     for (int i = 0; i < vector.Length; i++)

                     {
                         if (nombre == vector[i].getNombre())
                         {

                             txBusCod.Text = vector[i].getCodigo();
                             txBusAut.Text = vector[i].getAutor();
                             txBusDisp.Text = Convert.ToString(vector[i].getDisponible());


                         }

                     }
                     gbGestionar.Enabled = true;
                     gbEliminar.Enabled = true;
                 }*/
            }
        }

        private void txBusAu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txBusAut.Text))
            {
                System.Windows.Forms.MessageBox.Show("Ingrese un valor para la busqueda");
            }
            else
            {
                string autor = txBusAut.Text;
                int aux = 0;

                foreach (Books vec in vector)
                {

                    if (vec.getAutor() == autor)
                    {
                        txBusCod.Text = vec.getCodigo();
                        txBusNombre.Text = vec.getNombre();
                        txBusDisp.Text = Convert.ToString(vec.getDisponible());
                        break;
                    }
                    else
                    {
                        aux = aux + 1;
                        if (aux == contador)
                        {
                            MessageBox.Show("El autor buscado no esta registrador en nuestra biblioteca");
                            txBusNombre.Text = "";
                            txBusCod.Text = "";
                            txBusAut.Text = "";
                            txBusDisp.Text = "";
                            break;
                        }
                    }
                }

            }
            gbGestionar.Enabled = true;
            gbEliminar.Enabled = true;




            /*
            if (string.IsNullOrEmpty(txBusAut.Text))
            {

                System.Windows.Forms.MessageBox.Show("Ingrese un valor para la busqueda");

            }
            else
            {
                string autor = txBusAut.Text;


                for (int i = 0; i < vector.Length; i++)

                {
                    if (autor == vector[i].getAutor())
                    {

                        txBusCod.Text = vector[i].getCodigo();
                        txBusNombre.Text = vector[i].getNombre();
                        txBusDisp.Text = Convert.ToString(vector[i].getDisponible());


                    }

                }
                gbGestionar.Enabled = true;
                gbEliminar.Enabled = true;
            }*/
        }


        private void txBusDis_Click(object sender, EventArgs e)

        {
            string salida = "";

            for (int i = 0; i <= contador; i++)

            {
                if (vector[i] == null)
                {

                    break;
                }
                else if ("True" == Convert.ToString(vector[i].getDisponible()))
                {

                    salida += "Los libros disponibles en la actualidad son : \r\n" +
                    "Codigo : " + vector[i].getCodigo() + "\r\n" +
                    "Nombre : " + vector[i].getNombre() + "\r\n" +
                    "Autor : " + vector[i].getAutor() + "\r\n\r\n";

                }
                txSalidaConsulta.Text = salida;
            }


            gbGestionar.Enabled = true;
            gbEliminar.Enabled = true;




            /* foreach (Books vec in vector){

                 if ("True" == Convert.ToString(vec.getDisponible())){

                     salida += "Los libros disponibles en la actualidad son : \r\n" +
                     "Codigo : " + vec.getCodigo() + "\r\n" +
                     "Nombre : " + vec.getNombre() + "\r\n" +
                     "Autor : " + vec.getAutor() + "\r\n\r\n";
                 }

             }
             txSalidaConsulta.Text = salida;
             gbGestionar.Enabled = true;
             gbEliminar.Enabled = true;
             txSalidaConsulta.Text = salida;
             */
        }






        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txIngCod_TextChanged(object sender, EventArgs e)
        {

        }

        private void rbDisponible_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            /* if (string.IsNullOrEmpty(txEliminar.Text))
             {
                 System.Windows.Forms.MessageBox.Show("Ingrese un valor para la busqueda");
             }
             else
             {
                 string eliminar = txEliminar.Text;


                 for (int i =0; i<= vector.Length;i++)
                 {
                     if (vector[i].getCodigo().Equals (eliminar))
                     {
                         int j = i;
                         vector[j] = vector[j + 1];
                     }
                     else
                     {
                         txEliminar.Text = "El valor ingresado no esta asignado";
                     }

                 }
             }*/



            if (string.IsNullOrEmpty(txEliminar.Text))
            {
                System.Windows.Forms.MessageBox.Show("Ingrese el código del libro a eliminar");

            }
            else
            {
                string cod = txEliminar.Text;

                for (int i = 0; i <= vector.Length; i++)
                {
                    try
                    {
                        if (cod == vector[i].getCodigo())
                        {
                            contador -= 1;

                            for (int j = i; j < vector.Length - 1; j++)
                            {
                                vector[j] = vector[j + 1];

                            }
                            i = 0;
                            MessageBox.Show("el elemento ha sido borrado");
                            break;

                        }
                    }
                    catch (IOException ex)
                    {

                    }

                }
                txBusCod.Text = "";
                txBusAut.Text = "";
                txBusNombre.Text = "";
                txBusDisp.Text = "";
                txEliminar.Text = "";
                txSalidaConsulta.Text = "";
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txPrestar.Text))
            {
                System.Windows.Forms.MessageBox.Show("Ingrese el código del libro a Entregar");

            }
            else
            {

                string cod = txPrestar.Text;

                for (int i = 0; i < vector.Length; i++)
                {
                    if (vector[i] == null)
                    {

                        break;
                    }

                        if (cod == vector[i].getCodigo())
                    {
                        vector[i].setDisponible(false);

                    }

                }
                txBusAut.Text = "";
                txBusNombre.Text = "";
                txBusCod.Text = "";
                txBusDisp.Text = "";
                txPrestar.Text = "";
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txEntregar.Text))
            {
                System.Windows.Forms.MessageBox.Show("Ingrese el código del libro a Entregar");

            }
            else
            {
               
                    string cod = txEntregar.Text;

                for (int i = 0; i <= contador; i++)
                {
                    if (vector[i] == null)
                    {

                        break;
                    }
                    else if (cod == vector[i].getCodigo())
                    {
                        vector[i].setDisponible(true);
                        
                    }

                    
                }
                txBusAut.Text = "";
                txBusNombre.Text = "";
                txBusCod.Text = "";
                txBusDisp.Text = "";
                txEntregar.Text = "";
                }
            }

            private void txEntregar_TextChanged(object sender, EventArgs e)
            {

            }


        }
    }



