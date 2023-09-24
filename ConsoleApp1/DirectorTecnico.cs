using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class DirectorTecnico : Persona
    {
        private DateTime fechaDeNacimiento;

        private DirectorTecnico(string nombre) : base(nombre)
        {
        }
        public DirectorTecnico(long dni, string nombre, DateTime fechaDeNacimiento) : base(dni, nombre)
        {
            this.fechaDeNacimiento = fechaDeNacimiento;
        }

        public DateTime FechaDeNacimiento { get => fechaDeNacimiento; set => fechaDeNacimiento = value; }
        

        public override string MostrarDatos() // override sobreescrive el metodo heredado de persona
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.MostrarDatos()); // Llama al método MostrarDatos() de la clase base
            sb.AppendLine($"fecha de nacimiento {fechaDeNacimiento.ToString("dd/MM/yyyy")}");
            return sb.ToString();
        }

        public static bool SonElMismoDt(DirectorTecnico Dt1,DirectorTecnico Dt2)
        {
            if (Dt1.Nombre != Dt2.Nombre || Dt1.fechaDeNacimiento != Dt2.fechaDeNacimiento)
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
