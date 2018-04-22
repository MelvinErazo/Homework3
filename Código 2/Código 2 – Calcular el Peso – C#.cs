using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            double gvd=9.8;
            double f,m;
            Console.WriteLine("Calculador de peso Maquina Del Tiempo.\n");
            Console.WriteLine("¿Ingrese la fuerza en NEWTON a la cual es sometida la maquina del tiempo?\n");
            f = Convert.ToDouble(Console.ReadLine());
            m = f / gvd;
            Console.WriteLine("\n El peso en la maquina de tiempo es de: "+ Math.Round(m,2)+"kg");
            Console.ReadKey();

        }
    }
}
