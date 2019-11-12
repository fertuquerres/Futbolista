using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_Futbolista
{
    public class Futbolista
    {
        private string nombre;
        private string equipo;
        private int edad;
        private string nacionalidad;

        public Futbolista()
        {
            nombre = "";
            equipo = "";
            edad = 0;
            nacionalidad = "";
        }
        public Futbolista(string nnombre,string nequipo,int nedad,string nnacionalidad)
        {
            nombre = nnombre;
            equipo = nequipo;
            edad = nedad;
            nacionalidad = nnacionalidad;
        }
        public void SetNombre(string nnombre)
        {
            nombre = nnombre;
        }
        public string GetNombre()
        {
            return nombre;
        }
        public void SetEquipo(string nequipo)
        {
            equipo = nequipo;
        }
        public string GetEquipo()
        {
            return equipo;
        }
        public void SetEdad(int nedad)
        {
            edad = nedad;
        }
        public int GetEdad()
        {
            return edad;
        }
        public void SetNacionalidad(string nnacionalidad)
        {
            nacionalidad = nnacionalidad;
        }
        public string GetNacionalidad()
        {
            return nacionalidad;
        }
        public void ComprobarEdad()
        {
            if (edad%2==0)
            {
                Console.WriteLine("La edad del futbolista es par.");
            }
            else
            {
                Console.WriteLine("La edad del futbolista es impar.");
            }
        }
    }
}
