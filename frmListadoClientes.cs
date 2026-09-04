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
    public partial class frmListadoClientes : Form
    {
        public frmListadoClientes()
        {
            InitializeComponent();
        }

        clsVector vector = new clsVector();

        private void grpConsulta_Enter(object sender, EventArgs e)
        {

        }

        private void frmListadoClientes_Load(object sender, EventArgs e)
        {
            Decimal totalDeuda = 0;
            Int32 Cantclientes = 0;
            Decimal promedioDeuda = 0;

            dgvDatos.Rows.Clear();
            for (int i = 0; i < clsVector.indice; i++)
            {
                dgvDatos.Rows.Add(
                    clsVector.clientes[i].codigo,
                    clsVector.clientes[i].usuario,
                    clsVector.clientes[i].limite,
                    clsVector.clientes[i].deuda
                    );

                totalDeuda = totalDeuda + clsVector.clientes[i].deuda;
            }

            promedioDeuda = totalDeuda / clsVector.indice;
            Cantclientes = clsVector.indice;

            lblDeuda.Text = totalDeuda.ToString();
            lblCant.Text = Cantclientes.ToString();
            lblPromedioDeuda.Text = promedioDeuda   .ToString();
        }

        private void txtCantidad_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
