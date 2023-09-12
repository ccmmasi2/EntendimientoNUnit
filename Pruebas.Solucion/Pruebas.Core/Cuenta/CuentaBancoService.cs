using Pruebas.Core.LogRegistro.Interface;

namespace Pruebas.Core.Cuenta
{
    public class CuentaBancoService
    {
        public double Balance { get; set; }
        private readonly ILogRegistroService _logRegistro;

        public CuentaBancoService(ILogRegistroService logRegistro)
        {
            _logRegistro = logRegistro;
            Balance = 0.0;
        }

        public bool Deposito(double monto)
        {
            Balance += monto;
            _logRegistro.Mensaje("Deposito Realizado");
            return true;
        }

        public bool Retiro(double monto)
        {
            if (monto <= Balance)
            {
                _logRegistro.LogBaseDatos($"Monto de Retiro: {monto.ToString()}");
                Balance -= monto;
                return _logRegistro.LogBalanceDespuesRetiro(Balance);
            }
            return _logRegistro.LogBalanceDespuesRetiro(Balance -= monto);
        }

        public double ObtenerBalance()
        {
            return Balance;
        }
    }
}
