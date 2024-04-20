using LaboratorioProgra1.Laboratorio;

namespace LaboratorioProgra1.Laboratorio.Heredados
{
    internal class JuegoDeportes : VideoJuego
    {
        private string deporte;
        private int equiposJugadores;

        public string Deporte
        {
            get { return deporte; }
            set { deporte = value; }
        }

        public int EquiposJugadores
        {
            get { return equiposJugadores; }
            set { equiposJugadores = value; }
        }

        public JuegoDeportes() : base() { }

        public JuegoDeportes(string titulo, string desarrolladora, double calificacion, int anioLanzamiento, string deporte, int equiposJugadores) : base(titulo, desarrolladora, calificacion, anioLanzamiento)
        {
            this.deporte = deporte;
            this.equiposJugadores = equiposJugadores;
        }

        public override void MostrarInformacion()
        {
            base.MostrarInformacion();
            Console.WriteLine($"Deporte: {Deporte}");
            Console.WriteLine($"Equipos/Jugadores: {equiposJugadores}");
        }
    }
}
