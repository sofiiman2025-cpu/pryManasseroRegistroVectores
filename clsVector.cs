using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryManasseroRegistroVectores
{
    internal class clsVector
    {
        public string nombreAr = "../../Archivos/Clientes.csv";
        public struct RegCliente
        {
            public string usuario;
            public int codigo;
            public decimal limite;
            public decimal deuda;
        };
        public static RegCliente[] clientes = new RegCliente[5];

        public static int indice = 0;


        private void CargarVector()
        {
            string DatosLeidos = "";
            string[] vcDatos = new string[4];
            StreamReader ad = new StreamReader(nombreAr);
            DatosLeidos = ad.ReadLine();
            while (DatosLeidos != null)
            {
                vcDatos = DatosLeidos.Split(';');
                clientes[indice].codigo = Convert.ToInt32(vcDatos[0]);
                clientes[indice].usuario = vcDatos[1];
                clientes[indice].deuda = Convert.ToDecimal(vcDatos[2]);
                clientes[indice].limite = Convert.ToDecimal(vcDatos[3]);
                indice++;
                DatosLeidos = ad.ReadLine();
            }
            ad.Close();
            ad.Dispose();
        }

        private void OrdenarVector()
        {
            RegCliente Aux;

            for (Int32 c = 0; c < indice - 1; c++)
            {
                for (Int32 i = 0; i < indice - 1; i++)
                {
                    if (clientes[i].codigo > clientes[i + 1].codigo)
                    {
                        Aux = clientes[i];
                        clientes[i] = clientes[i + 1];
                        clientes[i + 1] = Aux;

                    }
                }
            }

        }

        private void ReescribirArchivo()
        {
            StreamWriter ad = new StreamWriter(nombreAr, false);
            for (Int32 i = 0; i < indice; i++)
            {
                ad.Write(clientes[i].codigo);
                ad.Write(";");
                ad.Write(clientes[i].usuario);
                ad.Write(";");
                ad.Write(clientes[i].deuda);
                ad.Write(";");
                ad.WriteLine(clientes[i].limite);
            }
            ad.Close();
            ad.Dispose();
        }

        public void OrdenarArchivo()
        {
            CargarVector();
            OrdenarVector();
            ReescribirArchivo();
        }

        // Métodos de ordenamiento utilizados por frmGestion
        public void OrdenarCodigoAscendente()
        {
            Array.Sort(clientes, 0, indice, Comparer<RegCliente>.Create((a, b) => a.codigo.CompareTo(b.codigo)));
        }

        public void OrdenarCodigoDescendente()
        {
            Array.Sort(clientes, 0, indice, Comparer<RegCliente>.Create((a, b) => b.codigo.CompareTo(a.codigo)));
        }

        public void OrdenarNombreAscendente()
        {
            Array.Sort(clientes, 0, indice, Comparer<RegCliente>.Create((a, b) => string.Compare(a.usuario, b.usuario)));
        }

        public void OrdenarNombreDescendente()
        {
            Array.Sort(clientes, 0, indice, Comparer<RegCliente>.Create((a, b) => string.Compare(b.usuario, a.usuario)));
        }

        public void OrdenarDeudaAscendente()
        {
            Array.Sort(clientes, 0, indice, Comparer<RegCliente>.Create((a, b) => a.deuda.CompareTo(b.deuda)));
        }

        public void OrdenarDeudaDescendente()
        {
            Array.Sort(clientes, 0, indice, Comparer<RegCliente>.Create((a, b) => b.deuda.CompareTo(a.deuda)));
        }

        public void OrdenarLimiteAscendente()
        {
            Array.Sort(clientes, 0, indice, Comparer<RegCliente>.Create((a, b) => a.limite.CompareTo(b.limite)));
        }

        public void OrdenarLimiteDescendente()
        {
            Array.Sort(clientes, 0, indice, Comparer<RegCliente>.Create((a, b) => b.limite.CompareTo(a.limite)));
        }

        public void Grabar(string cod, string deu, string nom, string lim)
        {
            StreamWriter ad = new StreamWriter(nombreAr, true);

            ad.Write(cod);
            ad.Write(";");
            ad.Write(nom);
            ad.Write(";");
            ad.Write(deu);
            ad.Write(";");
            ad.WriteLine(lim);

            ad.Close();
            ad.Dispose();

        }


        public void Listar(DataGridView Grilla)
        {
            string DatosLeidos = "";
            string[] vcDatos = new string[4];
            MessageBox.Show(Path.GetFullPath(nombreAr));
            StreamReader ad = new StreamReader(nombreAr);


            DatosLeidos = ad.ReadLine();

            while (DatosLeidos != null)
            {
                vcDatos = DatosLeidos.Split(';');
                Grilla.Rows.Add(vcDatos[0], vcDatos[1], vcDatos[2], vcDatos[3]);
                DatosLeidos = ad.ReadLine();
            }


            ad.Close();

        }

        public int CantClientes()
        {
            int c = 0;

            string DatosLeidos = "";

            StreamReader ad = new StreamReader(nombreAr);

            DatosLeidos = ad.ReadLine();


            while (DatosLeidos != null)
            {
                c++;
                DatosLeidos = ad.ReadLine();
            }
            ad.Close();
            ad.Dispose();
            return c;
        }
        public decimal Tdeuda()
        {
            decimal total = 0;
            string DatosLeidos = "";
            string[] vcDatos = new string[4];

            StreamReader ad = new StreamReader(nombreAr);

            DatosLeidos = ad.ReadLine();

            while (DatosLeidos != null)
            {
                vcDatos = DatosLeidos.Split(';');

                total = total + Convert.ToDecimal(vcDatos[2]);

                DatosLeidos = ad.ReadLine();
            }
            ad.Close();
            ad.Dispose();

            return total;
        }
        public decimal Promedio()
        {
            decimal total = 0;
            string DatosLeidos = "";
            string[] vcDatos = new string[4];
            Int32 c = 0;


            StreamReader ad = new StreamReader(nombreAr);

            DatosLeidos = ad.ReadLine();

            while (DatosLeidos != null)
            {
                vcDatos = DatosLeidos.Split(';');
                c++;

                total = total + Convert.ToDecimal(vcDatos[2]);

                DatosLeidos = ad.ReadLine();
            }

            ad.Close();
            ad.Dispose();

            return total / c;

        }
        public void ListarDeudores(DataGridView Grilla)
        {
            string DatosLeidos = "";
            string[] vcDatos = new string[4];

            StreamReader ad = new StreamReader(nombreAr);

            DatosLeidos = ad.ReadLine();

            while (DatosLeidos != null)
            {
                vcDatos = DatosLeidos.Split(';');
                if (Convert.ToDecimal(vcDatos[2]) > 0)
                {
                    Grilla.Rows.Add(vcDatos[0], vcDatos[1], vcDatos[2], vcDatos[3]);
                }

                DatosLeidos = ad.ReadLine();
            }


            ad.Close();
            ad.Dispose();

        }
        public decimal CantidadDeudores()
        {

            string DatosLeidos = "";
            string[] vcDatos = new string[4];
            Int32 c = 0;


            StreamReader ad = new StreamReader(nombreAr);

            DatosLeidos = ad.ReadLine();

            while (DatosLeidos != null)
            {
                vcDatos = DatosLeidos.Split(';');
                if (Convert.ToDecimal(vcDatos[2]) > 0)
                {
                    c++;
                }

                DatosLeidos = ad.ReadLine();

            }

            ad.Close();
            ad.Dispose();

            return c;
        }
        public decimal PromedioDeudores()
        {
            decimal total = 0;
            string DatosLeidos = "";
            string[] vcDatos = new string[4];
            Int32 c = 0;


            StreamReader ad = new StreamReader(nombreAr);

            DatosLeidos = ad.ReadLine();

            while (DatosLeidos != null)
            {
                vcDatos = DatosLeidos.Split(';');
                if (Convert.ToDecimal(vcDatos[2]) > 0)
                {
                    total = total + Convert.ToDecimal(vcDatos[2]);
                    c++;
                }

                DatosLeidos = ad.ReadLine();
            }

            ad.Close();
            ad.Dispose();

            return total / c;

        }

        public void Reporte()
        {
            string DatosLeidos = "";
            string[] vcDatos = new string[4];

            Int32 cant = 0;
            Decimal total = 0;

            StreamWriter reporte = new StreamWriter("../../Archivo/Reporte.csv", false, Encoding.UTF8);
            StreamReader ad = new StreamReader(nombreAr);

            reporte.WriteLine("Listado de Clientes");
            reporte.WriteLine("");
            reporte.WriteLine("Codigo;Nombre;Deuda;Limite");

            DatosLeidos = ad.ReadLine();

            while (DatosLeidos != null)
            {
                vcDatos = DatosLeidos.Split(';');
                reporte.Write(vcDatos[0] + ";");
                reporte.Write(vcDatos[1] + ";");
                reporte.Write(vcDatos[2] + ";");
                reporte.WriteLine(vcDatos[3] + ";");
                cant++;
                total = total + Convert.ToDecimal(vcDatos[2]);
                DatosLeidos = ad.ReadLine();
            }

            ad.Close();
            ad.Dispose();
            reporte.WriteLine("");
            reporte.Write("Total de deuda: ;;");
            reporte.WriteLine(total);
            reporte.Write("Cantidad de clientes:;;");
            reporte.WriteLine(cant);
            reporte.Write("Promedio de deuda:;;");
            reporte.WriteLine(total / cant);
            reporte.Close();
            reporte.Dispose();
        }

        public void OrdenarCodigoAscendente(DataGridView Grilla)
        {
            string DatosLeidos = "";
            string[] vcDatos = new string[4];
            StreamReader ad = new StreamReader(nombreAr);
            DatosLeidos = ad.ReadLine();

            RegCliente Aux;
            Int32 i = 0;
            Int32 c = 0;
            while (DatosLeidos != null)
            {
                vcDatos = DatosLeidos.Split(';');

                clientes[indice].codigo = Convert.ToInt32(vcDatos[0]);
                clientes[indice].usuario= vcDatos[1];
                clientes[indice].deuda = Convert.ToDecimal(vcDatos[2]);
                clientes[indice].limite = Convert.ToDecimal(vcDatos[3]);
                indice++;

                DatosLeidos = ad.ReadLine();

            }
            while (i < indice - 1)
            {
                c = 0;
                while (c < indice - 1)
                {
                    if (clientes[c].codigo > clientes[c + 1].codigo)
                    {
                        Aux = clientes[c];
                        clientes[c] = clientes[c + 1];
                        clientes[c + 1] = Aux;
                    }
                    c++;
                }
                i++;
            }
            for (Int32 z = 0; z < indice; z++)
            {
                Grilla.Rows.Add(clientes[z].codigo, clientes[z].usuario
                    , clientes[z].deuda, clientes[z].limite);
            }
            ad.Close();
            ad.Dispose();
        }
    }
}
    

