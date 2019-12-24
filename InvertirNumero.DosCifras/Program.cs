using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvertirNumero.DosCifras
{
    class Program
    {
        static void Main(string[] args)
        {
            int NUM, AUX, DEC, UNI;
            string linea;
            Console.WriteLine("INGRESE NÚMERO DE DOS CIFRAS :");
            linea = Console.ReadLine();
            NUM = int.Parse(linea);
            DEC = NUM / 10;
            UNI = NUM % 10;
            AUX = (UNI * 10) + DEC;
            Console.WriteLine("NÚMERO INVERTIDO ES: " + AUX);
            Console.WriteLine("Pulse una Tecla:"); Console.ReadLine();
        }
    }
}
