using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia_2
{
    class Persona
    {

        protected string nombre;
        protected double fechanacimiento;

        public double FechaNacimiento
        {
            get
            {
                return fechanacimiento;
            }
            set
            {
                fechanacimiento = value;
            }
        }
        public string Nombre
        {
            get
            {
                return nombre;
            }
            set
            {
                nombre = value;
            }
        }
        public Persona()
        {
            nombre = "";
            fechanacimiento = 0.00;
        }
        public Persona(string nombre, double fechanacimiento)
        {
            this.nombre = nombre;
            this.fechanacimiento = fechanacimiento;
        }

        public override string ToString()
        {
            return base.ToString() + "" + Nombre + ", Fecha De Nacimiento: " + fechanacimiento;
        }

    }

}
