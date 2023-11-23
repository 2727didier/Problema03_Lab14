using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema03_Lab14
{
    internal class Program
    {
        private static readonly int totalEncuestados;
        private static readonly object edades;

        public static object seHaVacunado { get; private set; }

        static void Main(string[] args, object seHaVacunado)
        {
            Console.WriteLine("===================================");
            Console.WriteLine("Datos de la encuesta");
            Console.WriteLine("===================================");
            Console.WriteLine("ID    | Edad | Vacunado");
            Console.WriteLine("=======================");

            for (int i = 0; i < totalEncuestados; i++)
            {
                Console.WriteLine(value: $"{i:D4}  |  {"edades"[i],-3}  |   {((bool)seHaVacunado ? "No" : "Si")}");
            }

            Console.WriteLine("===================================");
            Console.WriteLine("Presione una tecla para regresar ...");
            Console.ReadKey();
        }

    }
}

