using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Jugador : Persona
    {
        private int partidosJugados;
        private int totalGoles;

        public Jugador(long dni, string nombre, int partidosJugados, int totalGoles) : base(dni, nombre)
        {
            this.partidosJugados = partidosJugados;
            this.totalGoles = totalGoles;
        }

        public int PartidosJugados { get => partidosJugados; set => partidosJugados = value; }
        public int TotalGoles { get => totalGoles; set => totalGoles = value; }
        public float PromedioDeGoles { get
            {
                if (partidosJugados > 0)
                {
                    return (float)totalGoles / partidosJugados;
                }
                else
                {
                    return 0.0f; // Manejar el caso cuando no se han jugado partidos
                }
            }
        }

        public override string MostrarDatos() // override sobreescrive el metodo heredado de persona
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.MostrarDatos()); // Llama al método MostrarDatos() de la clase base
            sb.AppendLine($"partidos jugados {partidosJugados.ToString()}");
            sb.AppendLine($"total de goles {totalGoles.ToString()}");
            return sb.ToString();
        }
        public static bool SonElMismoDt(Jugador jugador1, Jugador jugador2)
        {
            if (jugador1.Nombre != jugador2.Nombre || jugador1.Dni != jugador2.Dni)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
