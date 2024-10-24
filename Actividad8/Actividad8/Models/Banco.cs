using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace Actividad8.Models
{
    internal class Banco
    {
        public int CantidadClientes { get { return clientes.Count; } }

        int CantidadCuentas;
        public List<Cuenta> cuentas;
        public List<Persona> clientes;

        public Cuenta this[int idx]
        {
            get
            {
                if (idx >= 0 && idx < CantidadCuentas)
                    return cuentas[idx];
                return null;
            }
        }

        public Cuenta AgregarCuenta(int numeroCuenta, int dni, string nombre, Persona titular)
        {
            Persona c = VerClientePorDNI(dni);
            if (c == null)
            {
                Persona p = new Persona(dni, nombre);
                clientes.Add(p);

            }

            Cuenta cuenta = VerCuentaPorNumero(numeroCuenta);
            if (cuenta == null)
            {
                cuenta = new Cuenta(numeroCuenta, titular);
                cuentas.Add(cuenta);

            }
            return cuenta;


        }

        public Persona VerClientePorDNI(int dni) //busca el cliente
        {
            foreach (Persona p in clientes)
            {
                if (clientes.DNI == dni)
                {
                    return p;
                }

            }
            return null;

        }

        public Cuenta VerCuentaPorNumero(int numero)// busca la cuenta 
        {

            foreach (Cuenta c in cuentas)
            {
                if (cuentas.Numero == numero)
                {
                    return c;
                }

            }
            return null;

            public bool RestaurarCuenta(int numero, int saldo, DateTime fecha, Persona p)
            {
                if
            }


        }

    } 
}

