using LaboratorioProgra1.EjemploPolimorfismo.Heredados;
using LaboratorioProgra1.Laboratorio;
using LaboratorioProgra1.Laboratorio.Heredados;

static void Main(string[] args)
{
    JuegoAccion juegoAccion = new JuegoAccion("Doom Eternal", "id Software", 9.5, 2020, "Primera persona", 5);
    JuegoAventura juegoAventura = new JuegoAventura("The Legend of Zelda: Breath of the Wild", "Nintendo", 10, 2017, "Fantasía épica", true);
    JuegoDeportes juegoDeportes = new JuegoDeportes("FIFA 23", "EA Sports", 8.5, 2022, "Fútbol", 11);

    juegoAccion.NivelDificultad = 3;
    juegoAventura.Historia = "Link emprende una nueva aventura...";
    juegoDeportes.EquiposJugadores = 2;

    GestorDeVideojuegos.AgregarVideojuego(juegoAccion);
    GestorDeVideojuegos.AgregarVideojuego(juegoAventura);
    GestorDeVideojuegos.AgregarVideojuego(juegoDeportes);

    GestorDeVideojuegos.MostrarInformacionDeTodosLosVideojuegos();


    juegoAccion.IniciarPartida();
    juegoAccion.Jugar(); 
    juegoAccion.TerminarJuego();


    VideoJuego[] videojuegosArray = new VideoJuego[] { juegoAccion, juegoAventura, juegoDeportes };
    foreach (VideoJuego videojuego in videojuegosArray)
    {
        videojuego.MostrarInformacion();
        Console.WriteLine("-----------------------------");
    }
}



