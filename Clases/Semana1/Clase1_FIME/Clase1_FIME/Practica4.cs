using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase1_FIME
{
    internal class Practica4
    {
        static void Main()
        {
            // Miguel Ruiz
            string op = "";
            int valor1, valor2, suma, resta, multiplicacion, division;
            double raiz;
            Console.WriteLine("Calculadora");
            Console.WriteLine("---------------------------------");

            Console.WriteLine("Dame valor 1");
            valor1 = Convert.ToInt32(Console.ReadLine()); 
            Console.WriteLine("Dame valor 2");
            valor2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("---------------------------------");
            Console.WriteLine("1. Suma");
            Console.WriteLine("2. Resta");
            Console.WriteLine("3. Multiplicacion");
            Console.WriteLine("4. Division");
            Console.WriteLine("5. Raiz");
            Console.WriteLine("6. Salir");
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Seleccione la opcion deseada:");
            op = Console.ReadLine().ToString();
            switch (op)
            {
                case "1":
                    Console.WriteLine("Seleccionaste suma");
                    suma = valor1 + valor2;
                    Console.WriteLine("La suma es " + suma);
                    break;
                case "2":
                    Console.WriteLine("Seleccionaste resta");
                    resta = valor1 - valor2;
                    Console.WriteLine("La resta es " + resta);
                    break;
                case "3":
                    Console.WriteLine("Seleccionaste multiplicacion");
                    multiplicacion = valor1 * valor2;
                    Console.WriteLine("La multiplicacion es " + multiplicacion);
                    break;
                case "4":
                    Console.WriteLine("Seleccionaste division");
                    if (valor2 != 0)
                    {
                        division = valor1 / valor2;
                        Console.WriteLine("La division es " + division);
                    } else
                    {
                        Console.WriteLine("No se puede dividir entre 0");
                    }
                    break;
                case "5":
                    Console.WriteLine("Seleccionaste raiz");
                    raiz = Math.Sqrt(valor1);
                    Console.WriteLine("La raiz del valor1 es " + raiz);  
                    raiz = Math.Sqrt(valor2);
                    Console.WriteLine("La raiz del valor2 es " + raiz);  
                    break;
                case "6":
                    Console.WriteLine("Seleccionaste salir");
                    break;
                default:
                    Console.WriteLine("No existe la opción seleccionada");
                    break;
            }


            Console.ReadKey();

        }
    }
}
