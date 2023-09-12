using NUnit.Framework;
using Pruebas.Core.Calculador;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pruebas.Test.Calculador
{
    [TestFixture]
    public class CalculadorGradoServiceTests
    {
        private CalculadorGradoService service;

        [SetUp]
        public void SetUp()
        {
            service = new CalculadorGradoService();
        }

        [Test]
        [TestCase(6, 95, ExpectedResult = "Basico")]
        [TestCase(60, 95, ExpectedResult = "Medio")]
        [TestCase(70, 95, ExpectedResult = "Medio-Alto")]
        [TestCase(90, 95, ExpectedResult = "Alto")]
        [TestCase(90, 80, ExpectedResult = "Basico")]
        public string ObtenerGrado(int puntaje, int porcentaje)
        {
            service.Puntaje = puntaje;
            service.PorcentajeAsistencia = porcentaje;
            string result = service.ObtenerGrado();

            return result;
        } 
    }
}
