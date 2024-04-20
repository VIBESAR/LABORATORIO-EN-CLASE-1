using LaboratorioProgra1.Laboratorio;
using LaboratorioProgra1.Laboratorio.Heredados;

namespace LaboratorioProgra1.Laboratorio
{
    internal static class GestorDeVideojuegos
    {
        private static List<VideoJuego> videojuegos = new List<VideoJuego>();

        public static void AgregarVideojuego(VideoJuego videojuego)
        {
            videojuegos.Add(videojuego);
        }

        public static List<VideoJuego> ObtenerTodosLosVideojuegos()
        {
            return videojuegos;
        }

        public static void MostrarInformacionDeTodosLosVideojuegos()
        {
            foreach (VideoJuego videojuego in videojuegos)
            {
                videojuego.MostrarInformacion();
                Console.WriteLine();
            }
        }
    }
}
