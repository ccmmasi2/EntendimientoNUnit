namespace Pruebas.Core.Calculador
{
    public class CalculadorGradoService
    {
        public int Puntaje { get; set; }
        public int PorcentajeAsistencia { get; set; }
        public string ObtenerGrado()
        {
            string grado = ((Puntaje >= 0 && Puntaje <= 50) && PorcentajeAsistencia > 90) ? "Basico" :
                           ((Puntaje >= 51 && Puntaje <= 65) && PorcentajeAsistencia > 90) ? "Medio" :
                           ((Puntaje >= 66 && Puntaje <= 80) && PorcentajeAsistencia > 90) ? "Medio-Alto" :
                           (Puntaje >= 81 && PorcentajeAsistencia > 90) ? "Alto" : "Basico";

            return grado;
        }
    }
}
