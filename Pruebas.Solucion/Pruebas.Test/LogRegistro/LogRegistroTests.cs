using NUnit.Framework;
using Pruebas.Core.LogRegistro.Implementacion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pruebas.Test.LogRegistro
{
    [TestFixture]
    public class LogRegistroTests
    {
        [Test]
        public void LogBalanceDespuesRetiro_IngresarBalancePositivo_retornaExitoso()
        {
            LogRegistroService service = new LogRegistroService();

            var resultado = service.LogBalanceDespuesRetiro(20);

            Assert.IsTrue(resultado);
        }

        [Test]
        public void LogBalanceDespuesRetiro_IngresarBalanceNegativo_retornaFallo()
        {
            LogRegistroService service = new LogRegistroService();

            var resultado = service.LogBalanceDespuesRetiro(-20);

            Assert.IsFalse(resultado);
        } 
    }
}
