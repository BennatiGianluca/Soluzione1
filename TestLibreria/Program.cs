using LibraryES1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestLibreria;

namespace TestLibreria
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inserisci un numero");
            int n = int.Parse(Console.ReadLine());
            bool risposta = Calcoli.QuadratoP(n);
            if (risposta)
            {
                Console.WriteLine("Il numero è un quadrato perfetto");
            }
            else
            {
                Console.WriteLine("Il numero non è un numero perfetto");
            }
            Console.ReadLine();
        }
    }
}
