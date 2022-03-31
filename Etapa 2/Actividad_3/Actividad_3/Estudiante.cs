using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_3
{
    internal class Estudiante
    {
        protected string Matricula;
        protected string Nombre;
        protected int Edad;
        protected string Password;
        protected double CuotaEscolar;

        public Estudiante()
        {
            this.CuotaEscolar = 0;
        }

        public Estudiante(string Matricula, string Nombre, int Edad, double CuotaEscolar)
        {
            this.Matricula = Matricula;
            this.Nombre = Nombre;
            asignarEdad(Edad);
            this.Password = asignarPassword();
            this.CuotaEscolar = CuotaEscolar;
        }

        public void asignarEdad(int Edad)
        {
            if(Edad >= 15 && Edad <= 90)
            {
                this.Edad = Edad;
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

        public virtual string mostrarDatos()
        {
            return "Matricula: " + this.Matricula + "\n" +
                    "Nombre: " + this.Nombre + "\n" +
                    "Edad: " + Edad + "\n" +
                    "Password: " + this.Password + "\n" +
                    "Cuota Escolar: " + this.CuotaEscolar + "\n";
        }

        public virtual void asignarBeca(int porcentaje)
        {
            var resultado1 = Convert.ToDouble(porcentaje);
            this.CuotaEscolar = CuotaEscolar - ((resultado1 * CuotaEscolar) / 100);
        }
    }
}
