using System;

namespace LaboratorioProgra1.Laboratorio
{
    /// <summary>
    /// Clase que representa un videojuego.
    /// </summary>
    internal class VideoJuego
    {
        private string titulo;
        private string desarrolladora;
        private double calificacion;
        private int anioLanzamiento;
        private bool jugando;
        private object value;

        public VideoJuego() { }

        public VideoJuego(string titulo, string desarrolladora, double calificacion, int anioLanzamiento)
        {
            this.titulo = titulo;
            this.desarrolladora = desarrolladora;
            this.calificacion = calificacion;
            this.anioLanzamiento = anioLanzamiento;
            this.jugando = false;
        }

        public VideoJuego(string titulo, string desarrolladora, double calificacion, object value)
        {
            this.titulo = titulo;
            this.desarrolladora = desarrolladora;
            this.calificacion = calificacion;
            this.value = value;
        }

        public string Titulo
        {
            get { return titulo; }
            set { titulo = value; }
        }

        public string Desarrolladora
        {
            get { return desarrolladora; }
            set { desarrolladora = value; }
        }

        public double Calificacion
        {
            get { return calificacion; }
            set
            {
                if (value >= 0 && value <= 10)
                {
                    calificacion = value;
                }
                else
                {
                    Console.WriteLine("La calificación debe estar entre 0 y 10");
                }
            }
        }

        public int AnioLanzamiento
        {
            get { return anioLanzamiento; }
            set
            {
                if (value >= 1900)
                {
                    anioLanzamiento = value;
                }
                else
                {
                    Console.WriteLine("El año de lanzamiento debe ser mayor o igual a 1900");
                }
            }
        }

        public void MostrarInformacion()
        {
            Console.WriteLine("--------- Videojuego ---------");
            Console.WriteLine($"Título: {Titulo}");
            Console.WriteLine($"Desarrolladora: {Desarrolladora}");
            Console.WriteLine($"Calificación: {Calificacion}");
            Console.WriteLine($"Año de Lanzamiento: {AnioLanzamiento}");
            Console.WriteLine("-----------------------------");
        }

        public static void saludo()
        {
            Console.WriteLine("Hi Gamer:");
        }

        public void IniciarPartida()
        {
            jugando = true;
            Console.WriteLine("¡Partida iniciada!");
        }

        public void DetenerPartida()
        {
            jugando = false;
            Console.WriteLine("Partida detenida.");
        }

        public void TerminarJuego()
        {
            if (jugando)
            {
                jugando = false;
                Console.WriteLine("Juego terminado.");
            }
            else
            {
                Console.WriteLine("No hay partida en curso.");
            }
        }
    }
}
