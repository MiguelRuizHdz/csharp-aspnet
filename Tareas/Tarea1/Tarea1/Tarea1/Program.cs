using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Tarea1
{
    internal class Program
    {
        /*
         * Autor: Miguel Ruiz
         * Realiza una consola donde pidas 3 calificaciones de 3 niños e indiques cuál de ellos se cataloga su calificación
         * 100 excelente​ 
         * 90 bueno​
         * 80 - 70 regular​
         * <60 malo
         */
        static void Main(string[] args)
        {
            List<int> listaCalificaciones = new List<int>();

            Console.WriteLine("Ingresa la calificación del niño 1");
            listaCalificaciones.Add( int.Parse(Console.ReadLine()) );
            Console.WriteLine("Ingresa la calificación del niño 2");
            listaCalificaciones.Add( int.Parse(Console.ReadLine()) );
            Console.WriteLine("Ingresa la calificación del niño 3");
            listaCalificaciones.Add( int.Parse(Console.ReadLine()) );

            Console.WriteLine("\n");
            for (int i = 1; i <= listaCalificaciones.Count; i++)
            {
                var calif = listaCalificaciones[i - 1];
                if (calif == 100)
                {
                    Console.WriteLine("La calificación del niño " + i + " es EXCELENTE");
                } 
                else if (calif == 90)
                {
                    Console.WriteLine("La calificación del niño " + i + " es BUENA");
                }
                else if (calif <= 80 && calif >= 70)
                {
                    Console.WriteLine("La calificación del niño " + i + " es REGULAR");
                }
                else if (calif <= 60 )
                {
                    Console.WriteLine("La calificación del niño " + i + " es MALA");
                }
            }
            Console.ReadKey();
        }
    }
}
