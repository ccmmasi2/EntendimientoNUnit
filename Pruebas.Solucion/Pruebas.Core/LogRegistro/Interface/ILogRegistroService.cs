using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pruebas.Core.LogRegistro.Interface
{
    public interface ILogRegistroService
    {
        void Mensaje(string mensaje);

        bool LogBaseDatos(string mensaje);

        bool LogBalanceDespuesRetiro(double balanceDespuesRetiro);

        string MensajeRetornaString(string mensaje);
    }
}
