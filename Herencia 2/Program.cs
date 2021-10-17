using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia_2
{
    class Program
    {
        static void Main(string[] args)
        {

            Persona persona= new  Persona();
            persona.FechaNacimiento= 16/15/03;
            persona.Nombre = "";
            Alumno Alm = new Alumno();

            Console.WriteLine(Alm.ToString());
        }
    }
}
