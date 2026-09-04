using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryManasseroRegistroVectores
{
    internal class clsVector
    {
        
        public struct RegCliente
        {
            public string usuario;
            public int codigo;
            public decimal limite;
            public decimal deuda;
        };
        public static RegCliente[] clientes = new RegCliente[5];

        public static int indice = 0;

        public static void Precarga()
        {
            clsVector.clientes[clsVector.indice].codigo = 1;
            clsVector.clientes[clsVector.indice].usuario = "Sofia";
            clsVector.clientes[clsVector.indice].limite = 100;
            clsVector.clientes[clsVector.indice].deuda = 700;
            clsVector.indice++;
            clsVector.clientes[clsVector.indice].codigo = 2;
            clsVector.clientes[clsVector.indice].usuario = "Martina";
            clsVector.clientes[clsVector.indice].limite = 200;
            clsVector.clientes[clsVector.indice].deuda = 800;
            clsVector.indice++;
            clsVector.clientes[clsVector.indice].codigo = 3;
            clsVector.clientes[clsVector.indice].usuario = "Lara";
            clsVector.clientes[clsVector.indice].limite = 300;
            clsVector.clientes[clsVector.indice].deuda = 1500;
            clsVector.indice++;
            clsVector.clientes[clsVector.indice].codigo = 4;
            clsVector.clientes[clsVector.indice].usuario = "Tomás";
            clsVector.clientes[clsVector.indice].limite = 400;
            clsVector.clientes[clsVector.indice].deuda = 2000;
            clsVector.indice++;
        }

        public void Agregar(string cod, string deu, string usu, string lim)
        {
            if (indice < clientes.Length)
            {
               
                Int32 i = 0;
                while (i < indice && clientes[i].codigo != Convert.ToInt32(cod))
                {
                    i++;
                }

                if (indice == i)
                {
                    clientes[indice].codigo = Convert.ToInt32(cod);
                    clientes[indice].deuda = Convert.ToDecimal(deu);
                    clientes[indice].usuario = usu;
                    clientes[indice].limite = Convert.ToDecimal(lim);
                    indice++;
                }
                else
                {
                    MessageBox.Show("El código propuesto ya es existente", "Aviso", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("Se ha alcanzado el límite de clientes", "aviso", MessageBoxButtons.OK);
            }
        }

        public void OrdenarCodigoAscendente()
        {
            RegCliente aux;
            Int32 i = 0;
            Int32 c = 0;


            while (i < indice - 1)
            {
                c = 0;

                while (c < indice - 1)
                {
                    if (clientes[c].codigo > clientes[c + 1].codigo)
                    {
                        aux = clientes[c];
                        clientes[c] = clientes[c + 1];
                        clientes[c + 1] = aux;

                    }
                    c++;
                }
                i++;
            }
        }

        public void OrdenarCodigoDescendente()
        {
            RegCliente aux;
            Int32 i = 0;
            Int32 c = 0;


            while (i < indice - 1)
            {
                c = 0;

                while (c < indice - 1)
                {
                    if (clientes[c].codigo < clientes[c + 1].codigo)
                    {
                        aux = clientes[c];
                        clientes[c] = clientes[c + 1];
                        clientes[c + 1] = aux;

                    }
                    c++;
                }
                i++;
            }
        }

        public void OrdenarNombreAscendente()
        {
            RegCliente aux;

            for (int i = 0; i < indice - 1; i++)
            {
                for (int j = 0; j < indice - 1; j++)
                {
                    if (string.Compare(clientes[j].usuario, clientes[j + 1].usuario) > 0)
                    {
                        aux = clientes[j];
                        clientes[j] = clientes[j + 1];
                        clientes[j + 1] = aux;
                    }
                }
            }
        }

        public void OrdenarNombreDescendente()
        {
                        RegCliente aux;

            for (int i = 0; i < indice - 1; i++)
            {
                for (int j = 0; j < indice - 1; j++)
                {                     if (string.Compare(clientes[j].usuario, clientes[j + 1].usuario) < 0)
                    {
                        aux = clientes[j];
                        clientes[j] = clientes[j + 1];
                        clientes[j + 1] = aux;
                    }
                }

            }

        }

        public void OrdenarDeudaAscendente()
        {
                        RegCliente aux;

            for (int i = 0; i < indice - 1; i++)
            {
                for (int j = 0; j < indice - 1; j++) 
                {
                if (clientes[j].deuda > clientes[j + 1].deuda)
                    {
                        aux = clientes[j];
                        clientes[j] = clientes[j + 1];
                        clientes[j + 1] = aux;
                    }

                }
            
            }

        }

        public void OrdenarDeudaDescendente()
        {
            RegCliente aux;
            for(int i = 0;i < indice - 1;i++)
            {
                for(int j = 0;j < indice - 1;j++)
                {
                    if(clientes[j].deuda < clientes[j + 1].deuda)
                    {
                        aux = clientes[j];
                        clientes[j] = clientes[j + 1];
                        clientes[j + 1] = aux;
                    }
                }
            }
        }
        public void OrdenarLimiteAscendente()
        {
            RegCliente aux;

            for (int i = 0; i < indice - 1; i++)
            {
                for (int j = 0; j < indice - 1; j++)
                {
                    if (clientes[j].limite > clientes[j + 1].limite)
                    {
                        aux = clientes[j];
                        clientes[j] = clientes[j + 1];
                        clientes[j + 1] = aux;
                    }
                }
            }

        }

        public void OrdenarLimiteDescendente()
        { 
            RegCliente aux;
            for(int i = 0;i < indice - 1;i++)
            {
                for(int j = 0;j < indice - 1;j++)
                {
                    if(clientes[j].limite < clientes[j + 1].limite)
                    {
                        aux = clientes[j];
                        clientes[j] = clientes[j + 1];
                        clientes[j + 1] = aux;
                    }
                }
            }
        }
    
    }
}
