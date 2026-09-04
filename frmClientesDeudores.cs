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
    public partial class frmClientesDeudores : Form
    {
        public frmClientesDeudores()
        {
            InitializeComponent();
        }

        clsVector vector = new clsVector();

        private void grpConsulta_Enter(object sender, EventArgs e)
        {

        }

        private void frmClientesDeudores_Load(object sender, EventArgs e)
        {
            Decimal totalDeuda = 0;
            Int32 cantidadClientes = 0;
            Decimal promDeuda = 0;

            dgvDatos.Rows.Clear();

            // Si no hay clientes cargados, evitar división por cero
            if (clsVector.indice == 0)
            {
                lblDeuda.Text = 0.ToString("N2");
                lblCantCli.Text = "0";
                lblPromD.Text = 0.ToString("N2");
                return;
            }

            // Listar solo clientes con deuda > 0 (deudores)
            for (int i = 0; i < clsVector.indice; i++)
            {
                if (clsVector.clientes[i].deuda > 0)
                {
                    dgvDatos.Rows.Add(
                        clsVector.clientes[i].codigo,
                        clsVector.clientes[i].usuario,
                        clsVector.clientes[i].limite,
                        clsVector.clientes[i].deuda
                        );

                    totalDeuda += clsVector.clientes[i].deuda;
                    cantidadClientes++;
                }
            }

            if (cantidadClientes > 0)
            {
                promDeuda = totalDeuda / cantidadClientes;
            }

            lblDeuda.Text = totalDeuda.ToString("N2");
            lblCantCli.Text = cantidadClientes.ToString();
            lblPromD.Text = promDeuda.ToString("N2");
        }
    }
}
