using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase1_FIME
{
    internal class Practica1
    {
        static void Main(string[] args)
        {
            // Miguel Ruiz
            Console.WriteLine("Hola Mundo");
            Console.WriteLine("-------------------------------------");
            
            Console.WriteLine("Practica Foreach");
            Console.WriteLine("-------------------------------------");
            List<string> lista = new List<string>();
            List<string> listaEliminar = new List<string>();

            lista.Add("Juana");
            lista.Add("Mary");
            lista.Add("Jose");
            lista.Add("Miguel");
            lista.Add("Esteban");
            lista.Add("Sebastian");
            lista.Add("Bernardo");
            lista.Add("Margoth");
            lista.Add("Nelly");
            lista.Add("Sarah");
            lista.Add("Noah");

            Console.WriteLine("\nLISTA COMPLETA");

            foreach (string name in lista)
            {
                Console.WriteLine(name.ToString());
            }

            Console.WriteLine("\nLISTA A ELIMINAR");
            foreach (string name in lista)
            {
                if ( name.Equals("Juana") || name.Equals("Sarah"))
                {
                    listaEliminar.Add(name);
                    Console.WriteLine(name.ToString());
                }
            }

            Console.WriteLine("\nLISTA FINAL");
            foreach (string name in listaEliminar)
            {
                lista.Remove(name);
            }

            foreach (string name in lista)
            {
                Console.WriteLine(name.ToString());
            }


            Console.ReadKey();
        }
    }
}
