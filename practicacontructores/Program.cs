using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practicacontructores
{
    class Program
    {
        static void Main(string[] args)
        {
            Alumno alumno1 = new Alumno();
            Alumno alumno2 = new Alumno("juan", "123456");

            Console.WriteLine("Alumno 1:");
            Console.WriteLine("Nombre: " + alumno1.Nombre);
            Console.WriteLine("Matricula: " + alumno1.Matricula);

            Console.WriteLine("Alumno 2:");
            Console.WriteLine("Nombre: " + alumno2.Nombre);
            Console.WriteLine("Matricula: " + alumno2.Matricula);

            Alumno alumno3 = new Alumno();
            alumno3.Nombre = "Juan";
            alumno3.Matricula = "hsdfhsdf";

            Console.WriteLine("Alumno 3:");
            Console.WriteLine("Nombre: " + alumno3.Nombre);
            Console.WriteLine("Matricula: " + alumno3.Matricula);

            Console.Read();
        }
    }
}
