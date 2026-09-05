using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryManasseroRegistroVectores
{
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
        }

        private void agregarNuevosClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
           frmCargarClientes frmCargarClientes = new frmCargarClientes();
            frmCargarClientes.ShowDialog(); 
        }

        private void listadoDeTodosLosClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListadoClientes frmListadoClientes = new frmListadoClientes();
            frmListadoClientes.ShowDialog();
        }

        private void listadoDeClientesDeudoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmClientesDeudores frmClientesDeudores = new frmClientesDeudores();
            frmClientesDeudores.ShowDialog();
        }

        private void listadoDeClientesOrdenadosPorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGestion frmGestion = new frmGestion();
            frmGestion.ShowDialog();
        }

        private void frmInicio_Load(object sender, EventArgs e)
        {
            // Inicialización al cargar el formulario; no abrir el mismo formulario aquí.
        }

        private void cerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close(); // Cierra el formulario actual
        }
    }
}
