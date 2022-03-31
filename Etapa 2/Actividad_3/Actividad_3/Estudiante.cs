using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_3
{
    internal class Estudiante
    {
        private string matricula;
        private string nombre;
        private int edad;
        private string password;

        public Estudiante()
        {

        }

        public Estudiante(string matricula, string nombre, int edad)
        {
            this.matricula = matricula;
            this.nombre = nombre;
            asignarEdad(edad);
            this.password = asignarPassword();
        }

        public void asignarEdad(int edad)
        {
            if(edad >= 15 && edad <= 90)
            {
                this.edad = edad;
            }
            else
            {
                Console.WriteLine("La edad debe estar entre 15 y 90 años");
            }
        }

        public string asignarPassword()
        {
            var characters = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            var Charsarr = new char[8];
            var random = new Random();

            for (int i = 0; i < Charsarr.Length; i++)
            {
                Charsarr[i] = characters[random.Next(characters.Length)];
            }

            var resultString = new String(Charsarr);
            return resultString;
        }

        public string mostrarDatos()
        {
            return "Matricula: "+this.matricula+"\n"+
                    "Nombre: "+this.nombre+"\n"+
                    "Edad: "+edad+"\n"+
                    "Password: " + this.password+"\n";
        }
    }
}
