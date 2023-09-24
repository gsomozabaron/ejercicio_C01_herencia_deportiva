using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Persona
    {
        private long dni;
        private string nombre;

        public Persona(long dni, string nombre) 
        {
            this.nombre = nombre;
            this.dni = dni;
        }

        public Persona(string nombre)
        {
            this.nombre = nombre;
        }

        public long Dni { get => dni; set => dni = value; }
        public string Nombre { get => nombre; set => nombre = value; }

        public virtual string MostrarDatos() //se agrega el virtual para que la puedan heredar las clases derivadas 
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"nombre: {nombre}");
            sb.AppendLine($"DNI: {dni.ToString()}");
            return sb.ToString();
        }
    }   
}
