using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio7
{
    class Program
    {
        static void Main(string[] args)
        {
            // 7. Solicite al usuario el ingreso de su nombre y presente el mensaje "Hola [nombre]"
            Console.WriteLine("Por favor, ingrese su nombre");
            string nombre = Console.ReadLine();
            Console.WriteLine($"Hola {nombre.ToUpper()}");
            Console.WriteLine("Ingrese una tecla para salir");          
            Console.ReadKey();
        }
    }
}
