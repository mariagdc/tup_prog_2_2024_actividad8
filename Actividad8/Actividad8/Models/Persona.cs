using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad8.Models
{
    internal class Persona
    {

        public int DNI { get; set; }
        public string Nombre { get; set; }
        int dni;
        string nombre;

        public Persona( int dni, string nombre) 
        {
            this.DNI = dni;
            this.Nombre = nombre;
        }

    }
}
