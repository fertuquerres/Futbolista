using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_Futbolista
{
    class Program
    {
        static void Main(string[] args)
        {
            Futbolista miFutbolista = new Futbolista();
            Console.WriteLine("----------------------");
            Console.WriteLine("Objeto 1.");
            Console.WriteLine("----------------------");
            Console.Write("Ingrese el nombre del futbolista: ");
            miFutbolista.SetNombre(Console.ReadLine());
            Console.Write("Ingrese el equipo del futbolista: ");
            miFutbolista.SetEquipo(Console.ReadLine());
            Console.Write("Ingrese la edad del futbolista: ");
            miFutbolista.SetEdad(Convert.ToInt32(Console.ReadLine()));
            Console.Write("Ingrese la nacionalidad del futbolista: ");
            miFutbolista.SetNacionalidad(Console.ReadLine());
            Console.WriteLine("----------------------");
            Console.WriteLine("Nombre: " + miFutbolista.GetNombre());
            Console.WriteLine("Equipo: " + miFutbolista.GetEquipo());
            Console.WriteLine("Edad: " + miFutbolista.GetEdad());
            Console.WriteLine("Nacionalidad: " + miFutbolista.GetNacionalidad());
            miFutbolista.ComprobarEdad();
            Console.WriteLine("----------------------");
            Console.WriteLine("Objeto 2");
            Console.WriteLine("----------------------");
            Futbolista miFutbolista1 = new Futbolista("Alberto Ordoñez", "Delfin FC", 33, "Ecuatoriana");
            Console.WriteLine("Nombre: " + miFutbolista1.GetNombre());
            Console.WriteLine("Equipo: " + miFutbolista1.GetEquipo());
            Console.WriteLine("Edad: " + miFutbolista1.GetEdad());
            Console.WriteLine("Nacionalidad: " + miFutbolista1.GetNacionalidad());
            miFutbolista1.ComprobarEdad();
            Console.ReadKey();
        }
    }
}
