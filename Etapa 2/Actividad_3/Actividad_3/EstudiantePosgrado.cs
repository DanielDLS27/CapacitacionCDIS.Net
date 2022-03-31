using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_3
{
    internal class EstudiantePosgrado : Estudiante
    {
        int NivelSNI;

        public EstudiantePosgrado() : base()
        {
            NivelSNI = 0;
        }

        public EstudiantePosgrado(string Matricula, string Nombre, int Edad, double CuotaEscolar, int NivelSNI) : base(Matricula, Nombre, Edad, CuotaEscolar)
        {
            this.NivelSNI= NivelSNI;
            comprobarNivelSNI();
        }

        public void comprobarNivelSNI()
        {
            if(this.NivelSNI != 1 && this.NivelSNI != 2 && this.NivelSNI != 3)
            {
                Console.WriteLine("Nivel SNI INVALIDO");
                this.NivelSNI = 0;
            }
        }

        public override void asignarBeca(int porcentaje)
        {
            base.asignarBeca(porcentaje);

            if(this.NivelSNI == 1 || this.NivelSNI == 2)
            {
                this.CuotaEscolar = this.CuotaEscolar - ((15 * this.CuotaEscolar) / 100);
            }

            if(NivelSNI == 3)
            {
                this.CuotaEscolar = this.CuotaEscolar - ((30 * this.CuotaEscolar) / 100);
            }
        }

        public override string mostrarDatos()
        {
            return base.mostrarDatos()+"Nivel SNI: " + this.NivelSNI+"\n";
           
        }
    }
}
