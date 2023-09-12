using NUnit.Framework;
using Pruebas.Core.Calculador;

namespace Pruebas.Test.Calculador
{
    [TestFixture]
    public class CalculadorServiceTests
    {
        private CalculadorService service;

        [SetUp]
        public void SetUp()
        {
            service = new CalculadorService();
        }

        [Test]
        [TestCase(1, 3, ExpectedResult = 4)]
        [TestCase(5, 7, ExpectedResult = 12)]
        [TestCase(14, 3, ExpectedResult = 17)]
        [TestCase(7, 3, ExpectedResult = 10)]
        [TestCase(12, 6, ExpectedResult = 18)]
        public int SumarNumeros_IngresarDosNumeros_ObtenerSuma(int numero1, int numero2)
        {
            int resultado = service.SumarNumeros(numero1, numero2);

            return resultado;
        }

        [Test]
        [TestCase(1, 10)]
        public void ObtenerRangoImpares_IngresarValors_ObtenerLista(int inicio, int fin)
        {
            List<int> LResult = null;
            List<int> listaEsperadaImpares = new() { 1, 3, 5, 7, 9 };

            LResult = service.ObtenerRangoImpares(inicio, fin);

            Assert.AreEqual(listaEsperadaImpares, LResult);
            Assert.That(LResult, Is.EquivalentTo(listaEsperadaImpares));
        } 
    }
}
