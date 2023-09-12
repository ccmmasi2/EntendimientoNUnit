
using System.ComponentModel;

namespace Pruebas.Core.Calculador
{
    public class CalculadorService
    { 
        public int SumarNumeros(int numero1, int numero2)
        {
            return numero1 + numero2;
        }

        public double SumarNumerosDouble(double numero1, double numero2)
        {
            return numero1 + numero2;
        }

        public List<int> ObtenerRangoImpares(int inicio, int final)
        {
            List<int> ListaRango = new List<int>();

            for (int i = inicio; i < final; i++)
            {
                if(i%2 != 0)
                {
                    ListaRango.Add(i);
                }
            }

            return ListaRango;
        }

        public bool EsImpar(int numero)
        {
            return numero % 2 != 0;
        }

        public int MultiplicarNumeros(int numero1, int numero2)
        { return numero1 * numero2; }   
    }
}
