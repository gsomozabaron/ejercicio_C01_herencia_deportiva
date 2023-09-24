namespace ConsoleApp1
{
    public class Program
    {
        static void Main(string[] args)
        {
            DirectorTecnico dt1 = new DirectorTecnico(25646638, "daniel", new DateTime(1977, 4, 5));
            DirectorTecnico dt2 = new DirectorTecnico(25646638, "daniel", new DateTime(1977, 4, 5));
            DirectorTecnico dt3 = new DirectorTecnico(25646635, "jorge", new DateTime(1977, 4, 6));
   
            Jugador jugador1 = new Jugador(25757845, "marcelo", 10, 5);
            Jugador jugador2 = new Jugador(25757846, "leo", 6, 3);
            Jugador jugador3 = new Jugador(25757847, "neri", 12, 6);
            Jugador jugador4 = new Jugador(25757848, "fideo", 15, 2);

            List<Jugador> listaJugadores = new List<Jugador>
            {
                jugador1, jugador2, jugador3, jugador4
            };
            
            Equipo equipo = new Equipo(11, "Yupanqui", listaJugadores);

            Console.WriteLine("mostrar datos de jugadores 1, 2, 3 y 4");
            Console.WriteLine(jugador1.MostrarDatos());
            Console.WriteLine(jugador2.MostrarDatos());
            Console.WriteLine(jugador3.MostrarDatos());
            Console.WriteLine(jugador4.MostrarDatos());

            Console.WriteLine("*******************************");
            Console.WriteLine("mostrar datos de Dt 1, 2 y 3");
            Console.WriteLine(dt1.MostrarDatos());
            Console.WriteLine(dt2.MostrarDatos());
            Console.WriteLine(dt3.MostrarDatos());

            Console.WriteLine("*******************************");
            Console.WriteLine("**** es el mismo dt?? caso 1 si, caso 2 no ****");
            Console.WriteLine(DirectorTecnico.SonElMismoDt(dt1, dt2));
            Console.WriteLine(DirectorTecnico.SonElMismoDt(dt1, dt3));

            Console.WriteLine("*******************************");
            Console.WriteLine($" promedio de goles de {jugador1.Nombre}\n" +
                              $"  {jugador1.PromedioDeGoles} %\n" +
                              $" {jugador1.TotalGoles} goles en {jugador1.PartidosJugados} partidos");
            
            Console.WriteLine("*******************************");
            Console.WriteLine("**** es el mismo jugador?? caso 1 si, caso 2 no ****");
            Console.WriteLine(Jugador.SonElMismoDt(jugador1, jugador1));
            Console.WriteLine(Jugador.SonElMismoDt(jugador1, jugador2));







        }
    }
}