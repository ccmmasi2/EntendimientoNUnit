using NUnit.Framework;
using Pruebas.Core.Cliente;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pruebas.Test.Cliente
{
    [TestFixture]
    public class ClienteServicesTests
    {
        private ClienteService service;

        [SetUp]
        public void SetUp()
        {
            service = new ClienteService(); 
        }

        [Test]
        public void DetalleCliente_TotalCompras90_RecibirClienteBasico()
        {
            service.TotalCompras = 90;
            ClienteTipo cliente = service.DetalleCliente();
            Assert.That(cliente, Is.TypeOf<ClienteBasico>());
        }
    }
}
