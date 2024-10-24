using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad8.Models
{
    internal class Cuenta
    {

        public int Numero {  get; set; }
        private int numero;
        public double Saldo { get; set; }
        double saldo;
        DateTime fecha;



        public Cuenta (int numero, Persona titular)
        {
            this.Numero = numero;

        }
        public Cuenta (int numero, Persona titular, DateTime fecha, double saldo) 
        {
            this.Numero = numero;
            this.Saldo = saldo;
            this.fecha = fecha;     
        
        
        }
    }
}
