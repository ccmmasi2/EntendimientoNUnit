using Moq;
using NUnit.Framework;
using Pruebas.Core.Cuenta;
using Pruebas.Core.LogRegistro.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pruebas.Test.Cuenta
{
    [TestFixture]
    public class CuentaBancoServiceTests
    {
        private CuentaBancoService service;
         
        [Test]
        public void Deposito_Insertar100_ObtenerBalance()
        {
            var LogMock = new Mock<ILogRegistroService>();
            LogMock.Setup(x => x.Mensaje(""));
            service = new CuentaBancoService(LogMock.Object);

            var resultado = service.Deposito(100);

            Assert.IsTrue(resultado);
            Assert.That(service.ObtenerBalance(), Is.EqualTo(100));
        }

        [Test]
        [TestCase(100, 80)]
        public void Retiro_Deposito100Retirar80_ObtenerBalanceTrue(int deposito, int retiro)
        {
            var LogMock = new Mock<ILogRegistroService>();
            LogMock.Setup(x => x.Mensaje(""));
            LogMock.Setup(x => x.LogBaseDatos(It.IsAny<string>())).Returns(true);
            LogMock.Setup(x => x.LogBalanceDespuesRetiro(It.Is<double>(x => x > 0))).Returns(true);
            service = new CuentaBancoService(LogMock.Object);

            service.Deposito(deposito);
            var resultado = service.Retiro(retiro);

            Assert.That(service.ObtenerBalance(), Is.EqualTo(20));
            Assert.IsTrue(resultado);
        }

        [Test]
        [TestCase(100, 120)]
        public void Retiro_Deposito100Retirar120_ObtenerBalanceFalse(int deposito, int retiro)
        {
            var LogMock = new Mock<ILogRegistroService>();
            LogMock.Setup(x => x.Mensaje(""));
            LogMock.Setup(x => x.LogBaseDatos(It.IsAny<string>())).Returns(true);
            LogMock.Setup(x => x.LogBalanceDespuesRetiro(It.Is<double>(x => x < 0))).Returns(false);
            service = new CuentaBancoService(LogMock.Object);

            service.Deposito(deposito);
            var resultado = service.Retiro(retiro);

            Assert.That(service.ObtenerBalance(), Is.EqualTo(-20));
            Assert.IsFalse(resultado);
        } 
    }
}
