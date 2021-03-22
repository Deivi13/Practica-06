using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    class ProbarContacto
    {
        static void Main(string[] args)
        {
            Contacto compli = new Contacto();
            compli.SetContacto("Deivi", "Hernandez", "8291231234", "Calle 9, Ensanche La vega");
            compli.Saludar();

            Console.ReadKey();

        }
    }

    class Contacto
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }

        public void SetContacto(string _Nombre, string _Apellido, string _Telefono, string _Direccion)
        {
            Nombre = _Nombre;
            Apellido = _Apellido;
            Telefono = _Telefono;
            Direccion = _Direccion;
        }

        public void Saludar()
        {
            Console.WriteLine("Hola soy {0} {1}, Mi numero de telefono es {2} y mi direccion es {3}", Nombre, Apellido, Telefono, Direccion);
        }

    }
}
