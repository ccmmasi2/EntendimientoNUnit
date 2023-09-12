using Pruebas.Core.LogRegistro.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pruebas.Core.LogRegistro.Implementacion
{
    public class LogRegistroService : ILogRegistroService
    {
        public void Mensaje(string mensaje)
        {
            Console.WriteLine(mensaje);
        }

        public bool LogBaseDatos(string mensaje)
        {
            Console.WriteLine(mensaje);
            return true;
        }

        public bool LogBalanceDespuesRetiro(double balanceDespuesRetiro)
        {
            if (balanceDespuesRetiro >= 0)
            {
                Console.WriteLine("Exitoso");
                return true;
            }
            Console.WriteLine("Fallo");
            return false;
        }

        public string MensajeRetornaString(string mensaje)
        {
            Console.WriteLine(mensaje);
            return mensaje.ToLower();
        }
    }
}
