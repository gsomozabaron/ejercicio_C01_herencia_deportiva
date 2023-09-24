using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Equipo
    {
        private short cantidadDeJugadores;
        private List<Jugador> jugadores;
        private string nombre;

        public Equipo(short cantidadDeJugadores, string nombre, List<Jugador>jugadores)
        {
            this.cantidadDeJugadores = cantidadDeJugadores;
            this.nombre = nombre;
        }

        public Equipo(List<Jugador> jugadores)
        {
            this.jugadores = new List<Jugador>(); // Inicializa la lista de jugadores
        }

        //public short CantidadDeJugadores { get => cantidadDeJugadores; set => cantidadDeJugadores = value; }
        //public string Nombre { get => nombre; set => nombre = value; }
        //internal List<Jugador> Jugadores { get => jugadores; set => jugadores = value; }
    }
}
