using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvFi
{
    class Program
    {
        
        static void Main(string[] args)
        {
            
            sumvector sum = new sumvector(new List<int> { 1, 2, 3 });
            sumvector su = new sumvector(new List<int> { 4,5, 6 });
            sumvector mo1 = su.Suma(sum);
            Console.WriteLine("Suma");
            foreach (var item in mo1.Componentes)
            {
                Console.WriteLine(item);
            }

            sumvector mo2 = su.Resta(sum);
            Console.WriteLine("Resta");
            foreach (var item in mo2.Componentes)
            {
                Console.WriteLine(item);
            }

            sumvector mo3 = su.Multiplicar(sum);
            Console.WriteLine("Multiplicacion");
            foreach (var item in mo3.Componentes)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}



