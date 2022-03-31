using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Estudiante[] estudiantes;
            int cantEstudiantes;
            string matricula;
            string nombre;
            int edad;

            Console.WriteLine("Ingrese cantidad de estudiantes: ");
            cantEstudiantes = int.Parse(Console.ReadLine());

            estudiantes = new Estudiante[cantEstudiantes];

            for(int i = 0; i < estudiantes.Length; i++)
            {
                Console.WriteLine("Estudiante #" +( i + 1));
                Console.Write("Ingrese Matricula: ");
                matricula = Console.ReadLine();
                Console.Write("\nIngrese Nombre: ");
                nombre = Console.ReadLine();
                Console.Write("\nIngrese Edad: ");
                edad = int.Parse(Console.ReadLine());
                Console.WriteLine();

                estudiantes[i] = new Estudiante(matricula, nombre, edad);
            }

            for(int i = 0;i < estudiantes.Length; i++)
            {
                Console.WriteLine("Estudiante #"+( i + 1)+"\n");
                Console.WriteLine(estudiantes[i].mostrarDatos());
            }

            Console.ReadLine();
        }
    }
}
