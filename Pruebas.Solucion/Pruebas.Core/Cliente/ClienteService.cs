using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pruebas.Core.Cliente
{
    public class ClienteService
    {
        public string Saludo { get; set; }
        public int TotalCompras { get; set; }

        public ClienteTipo DetalleCliente()
        {
            if (TotalCompras < 100)
            {
                return new ClienteBasico();
            }
            return new ClientePlatino();
        }
    }
}
