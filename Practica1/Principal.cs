using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Practica1
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void nóminaProfesoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Nomina objNom = new Nomina();
            objNom.MdiParent = this;
            objNom.Show();
           
            
        }

        private void maquinaBancariaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Maquina objMaq = new Maquina();
            objMaq.MdiParent = this;
            objMaq.Show();

        }

        private void bibliotecaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Vista objVi = new Vista();
            objVi.MdiParent = this;
            objVi.Show();
        }

        private void Principal_Load(object sender, EventArgs e)
        {

        }

        private void empresaDeViajesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tours objTour = new Tours();
            objTour.MdiParent = this;
            objTour.Show();
        }
    }
}
