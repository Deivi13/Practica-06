using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1
{
    class Program
    {

        static void Main(string[] args)
        {
            Persona secomplico = new Persona() { Cedula = 40208889481, Nombre = "Deivi", Apellido = "Hernandez", Edad = 20 };
            Profesor complicadisimo = new Profesor() { Sueldo = 999999999 };
            
            secomplico.Imprimir();
            complicadisimo.PrintSueldo();


            Console.ReadKey(); 
        }

        class Persona
        {
            public long Cedula { get; set; }
            public string Nombre { get; set; }
            public string Apellido { get; set; }
            public int Edad { get; set; }

            public void Imprimir()
            {
                Console.WriteLine(" La Cedula es {0}, Nombre y apellido son: {1} {2}, y por ultimo tiene la edad de {3} Años", Cedula, Nombre, Apellido, Edad);
            }

        }

        class Profesor: Persona
        {
            public int Sueldo { get; set; }

            public void PrintSueldo()
            {
                Console.WriteLine(" El sueldo es {0}", Sueldo);
            }
        }
    }
}
