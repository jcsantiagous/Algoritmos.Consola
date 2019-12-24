using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmos.Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            string linea;
            Console.Write("INGRESA UN NUMERO: ");
            linea = Console.ReadLine();

            num = int.Parse(linea);

            if (num > 0)
            {
                for (int r = 1; r <= num; r++)
                {
                    for (int c = 1; c <= r; c++)
                    {
                        Console.Write("{0} ", c);
                    }
                    Console.Write(Environment.NewLine);
                }

                for (int r = num -1 ; r > 0; r--)
                {
                    for (int c = 1; c <= r; c++)
                    {
                        Console.Write("{0} ", c);
                    }
                    Console.Write(Environment.NewLine);
                }

            }

            Console.Read();
        }
    }
}
