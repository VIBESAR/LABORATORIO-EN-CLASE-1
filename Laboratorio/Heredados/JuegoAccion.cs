using LaboratorioProgra1.Laboratorio;

namespace LaboratorioProgra1.Laboratorio.Heredados
{
    internal class JuegoAccion : VideoJuego
    {
        private string perspectiva;
        private int nivelDificultad;

        public string Perspectiva
        {
            get { return perspectiva; }
            set { perspectiva = value; }
        }

        public int NivelDificultad
        {
            get { return nivelDificultad; }
            set { nivelDificultad = value; }
        }

        public JuegoAccion() : base() { }

        public JuegoAccion(string titulo, string desarrolladora, double calificacion, int anioLanzamiento, string perspectiva, int nivelDificultad) : base(titulo, desarrolladora, calificacion, anioLanzamiento )
        {
            this.perspectiva = perspectiva;
            this.nivelDificultad = nivelDificultad;
        }



        public override void MostrarInformacion()
        {
            base.MostrarInformacion();
            Console.WriteLine($"Perspectiva: {Perspectiva}");
            Console.WriteLine($"Nivel de Dificultad: {NivelDificultad}");
        }
    }
}

