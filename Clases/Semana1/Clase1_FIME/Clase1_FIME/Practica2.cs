using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase1_FIME
{
    internal class Practica2
    {
        static void Main(string[] args)
        {
            // Miguel Ruiz
            Console.WriteLine("ALTA DE FORMULARIO");
            Console.WriteLine("-------------------------------------");

            Console.WriteLine("Cual es tu nombre");
            var nombre = Console.ReadLine();
            Console.WriteLine("Cual es tu fecha de nacimiento");
            var fecha = Console.ReadLine();
            Console.WriteLine("Cual es tu correo");
            var correo = Console.ReadLine();
            Console.WriteLine("Cual es tu telefono");
            var telefono = Console.ReadLine();
            Console.WriteLine("Genera Contraseña");
            string clave1 = Console.ReadLine().ToString();
            Console.WriteLine("Confirma Contraseña");
            string clave2 = Console.ReadLine().ToString();

            while( clave1 != clave2 )
            {
                Console.WriteLine("Claves no son iguales");
                Console.WriteLine("Genera Contraseña");
                clave1 = Console.ReadLine().ToString();
                Console.WriteLine("Confirma Contraseña");
                clave2 = Console.ReadLine().ToString();
            }

            Console.Clear();

            string resp = "";
            Console.WriteLine("Ingresa tu contraseña");
            resp = Console.ReadLine();
            while ( resp != clave1)
            {
                Console.WriteLine("La contraseña es incorrecta");
                Console.WriteLine("Ingresa tu contraseña: ");
                resp = Console.ReadLine();
            }

            Console.Clear();

            Console.WriteLine("BIENVENIDOS AL CURSO");

            Console.WriteLine("El usuario es " + nombre);
            Console.WriteLine("Su fecha de nacimiento es " + fecha);
            Console.WriteLine("Su correo es " + correo);
            Console.WriteLine("Su telefono es " + telefono);

            Console.WriteLine(nombre + " Su fecha de nacimiento es " + fecha);

            Console.ReadKey();

        }
    }
}
