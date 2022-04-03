using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Escuela_DAL;

namespace Escuela_BLL
{
    public class FacultadBLL
    {
        public DataTable cargarFacultades()
        {
            FacultadDAL facultad = new FacultadDAL();
            return facultad.cargarFacultades();
        }

        public void agregarFacultad(string codigo, string nombre, DateTime fechaCreacion, int universidad)
        {
            FacultadDAL facultad = new FacultadDAL();
            DataTable dtFacultad = new DataTable();

            dtFacultad = cargarFacultad(codigo);

            if(dtFacultad.Rows.Count > 0)
            {
                throw new Exception("El codigo de la facultad ya existe, introduce un codigo diferente");
            }
            else
            {
                int creacion = DateTime.Now.Year - fechaCreacion.Year;

                if(creacion > 122)
                {
                    throw new Exception("Fecha no permitida, introduce una fecha mayor a 1900");
                }
                else if(creacion < 12)
                {
                    throw new Exception("Fecha no permitida, introduce una fecha menor a 2010");
                }
                else
                {
                    facultad.agregarFacultad(codigo, nombre, fechaCreacion, universidad);
                }

                
            }
            
        }

        public DataTable cargarFacultad(string codigo)
        {
            FacultadDAL facultad = new FacultadDAL();
            return facultad.cargarFacultad(codigo);
        }

        public void modificarFacultad(int idFacultad, string codigo, string nombre, DateTime fechaCreacion, int universidad)
        {
            FacultadDAL facultad = new FacultadDAL();
            facultad.modificarFacultad(idFacultad, codigo, nombre, fechaCreacion, universidad);
        }

        public void eliminarFacultad(int idFacultad)
        {
            FacultadDAL facultad = new FacultadDAL();
            facultad.eliminarFacultad(idFacultad);
        }
    }
}
