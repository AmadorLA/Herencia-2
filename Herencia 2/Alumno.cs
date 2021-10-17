using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia_2
{
    class Alumno : Persona
    {
        private double matricula;
        private string carrera;
        public string Carrera
        {
            get
            {
                return carrera ;
            }
            set
            {
                carrera = value;
            }
        }
        public double Matricula
        {
            get
            {
                return matricula;
            }
            set
            {
                matricula = value;
            }
        }

        public Alumno()
        {
            matricula = 0.00;
            carrera = "";
        }

        public Alumno(String carrera, double matricula)
        {
            this.carrera = carrera;
            this.matricula = matricula;
        }

        public override string ToString()
        {
            return base.ToString() + "" + matricula + ",Carrera[" + carrera.ToString() + "]";
        }

    }


}
