using LaboratorioProgra1.Laboratorio;

namespace LaboratorioProgra1.Laboratorio.Heredados
{
    internal class JuegoAventura : VideoJuego
    {
        private string historia;
        private bool mundoAbierto;

        public string Historia
        {
            get { return historia; }
            set { historia = value; }
        }

        public bool MundoAbierto
        {
            get { return mundoAbierto; }
            set { mundoAbierto = value; }
        }

        public JuegoAventura() : base() { }

        public JuegoAventura(string titulo, string desarrolladora, double calificacion, int anioLanzamiento, string historia, bool mundoAbierto) : base(titulo, desarrolladora, calificacion, anioLanzamiento)
        {
            this.historia = historia;
            this.mundoAbierto = mundoAbierto;
        }

        public override void MostrarInformacion()
        {
            base.MostrarInformacion();
            Console.WriteLine($"Historia: {Historia}");
            Console.WriteLine($"Mundo Abierto: {mundoAbierto}");
        }
    }
}
