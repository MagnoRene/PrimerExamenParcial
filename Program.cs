using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clientes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("==============================Cliente 1==============================");
            Cliente Cliente1 = new Cliente(1, "Manuel Enrique", "Hernandez Ceballos", "4547878545", "Mazatenango", "45457852", "Luis Paz", 1500);
            Cliente1.Imprimir();
            Console.WriteLine("==============================Cliente 2==============================");
            Cliente Cliente2 = new Cliente(3, "Jose Manuel", "Valle Garcia", "4547878545", "Mazatenango", "45457852", "Luis Paz", 1600);
            Cliente2.Imprimir();
            Console.WriteLine("==============================Cliente 3==============================");
            Cliente Cliente3 = new Cliente(4, "Luis Rodrigo", "Hernandez Ceballos", "4547878545", "Mazatenango", "45457852", "Luis Paz", 6000);
            Cliente3.Imprimir();
            Console.ReadKey();
        }
    }
}
