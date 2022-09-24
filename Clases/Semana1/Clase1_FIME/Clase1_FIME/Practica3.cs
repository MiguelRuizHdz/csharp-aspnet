using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase1_FIME
{
    internal class Practica3
    {
        static void Main()
        {
            // Miguel Ruiz
            int respuesta;
            Console.WriteLine("Dame valor 1");
            int valor1 = Convert.ToInt32(Console.ReadLine()); 
            Console.WriteLine("Dame valor 2");
            int valor2 = Convert.ToInt32(Console.ReadLine());
            respuesta = valor1 + valor2;
            Console.WriteLine("La suma de los dos valores es " + respuesta);
            
            Console.WriteLine("\n");
            // if
            if (valor1 > valor2)
            {
                Console.WriteLine("Es mayor el valor 1 = " + valor1);
            } else
            {
                Console.WriteLine("Es mayor el valor 2 = " + valor2);
            }
            
            Console.WriteLine("\n");
            // tabla multiplicar
            int n;
            string linea;
            Console.WriteLine("Ingresa el numero multiplicador");
            linea = Console.ReadLine();
            n = int.Parse(linea);

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(n + " x " + i + " = " + n*i);
            }

            Console.ReadKey();
        }
    }
}
