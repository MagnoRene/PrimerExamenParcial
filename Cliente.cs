using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clientes
{
    class Cliente
    {
        public int Codigo { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Nit { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string NomVendedor { get; set; }
        public string TipoCliente { get; set; }
        public double TotalComprasClientes { get; set; }

        public Cliente(int codigo,string nombre,string apellidos,string nit,string direccion,string telefono,string vendedor,double totalcompras)
        {
            this.Codigo = codigo;
            this.Nombre = nombre;
            this.Apellidos = apellidos;
            this.Nit = nit;
            this.Direccion = direccion;
            this.Telefono = telefono;
            this.NomVendedor = vendedor;
            this.TotalComprasClientes = totalcompras;
            if (totalcompras<=1500)
            {
                this.TipoCliente = "Cliente Normal";
                
            }
            if (totalcompras>1501 && totalcompras<5000)
            {
                if (this .TipoCliente =="Cliente Normal")
                {
                    this.TipoCliente = "Cliente Normal";
                }
                else
                {
                    this.TipoCliente = "Cliente Especial";
                }
               
                
            }
            if (totalcompras >5001)
            {
                this.TipoCliente = "Cliente Mayorista";
                
            }
        }

        //-------------Metodo----------------
        public void Imprimir()
        {
            Console.WriteLine("Codigo: " + Codigo + " Nombre: " + Nombre + " Apellidos: " + Apellidos +" Nit: " + Nit + "\nDireccion: " + Direccion + " Telefono: " + Telefono + " Vendedor: " + NomVendedor +"\nTotal Compras:"+TotalComprasClientes+ " Tipo Cliente: " + TipoCliente);
            Console.WriteLine();
        }

    }
}
