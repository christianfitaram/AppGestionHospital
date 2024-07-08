using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    public class Medico
    {
        private string nombre;
        private string apellido1;
        private string apellido2;
        private string fechaInicio;
        private string especialidad;

        public Medico()
        {
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido1 { get => apellido1; set => apellido1 = value; }
        public string Apellido2 { get => apellido2; set => apellido2 = value; }
        public string FechaInicio { get => fechaInicio; set => fechaInicio = value; }
        public string Especialidad { get => especialidad; set => especialidad = value; }

        public Medico(String nombre, String apellido1, String apellido2, String fechaInicio, String especialidad)
        {
            this.nombre =   Nombre;
            this.apellido1 = Apellido1;
            this.apellido2 = Apellido2;
            this.fechaInicio = FechaInicio;
            this.especialidad = Especialidad;
        }


    }
}
