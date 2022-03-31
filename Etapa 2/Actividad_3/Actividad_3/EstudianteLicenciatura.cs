using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_3
{
    internal class EstudianteLicenciatura : Estudiante
    {
        bool RealizaServicio;

        public EstudianteLicenciatura() : base()
        {
            RealizaServicio = false;
        }

        public EstudianteLicenciatura(string Matricula, string Nombre, int Edad, double CuotaEscolar, bool RealizaServicio) : base(Matricula, Nombre, Edad, CuotaEscolar)
        {
            this.RealizaServicio=RealizaServicio;
        }

        public override void asignarBeca(int porcentaje)
        {
            base.asignarBeca(porcentaje);

            if(RealizaServicio == true)
            {
                this.CuotaEscolar = CuotaEscolar - ((15 * CuotaEscolar) / 100);
            }
        }

        public override string mostrarDatos()
        {
          
            if(this.RealizaServicio == true)
            {
                return base.mostrarDatos() + "SI Realiza Servicio Social\n";
            }
            else
            {
                return base.mostrarDatos() + "NO Realiza Servicio Social\n";
            }
        }
    }
}
