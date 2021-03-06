using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Escuela_BLL;

namespace Escuela.Facultades
{
    public partial class facultad_s : System.Web.UI.Page, IAcceso
    {
        #region Eventos
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (sesionIniciada())
                {
                    grd_facultades.DataSource = cargarFacultades();
                    grd_facultades.DataBind();
                }
                else
                {
                    Response.Redirect("~/Login.aspx");
                }
            }
        }

        protected void grd_facultades_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if(e.CommandName == "Editar")
            {
                Response.Redirect("~/Facultades/facultad_u.aspx?pCodigo=" + e.CommandArgument);
            }
            else
            {
                Response.Redirect("~/Facultades/facultad_d.aspx?pCodigo=" + e.CommandArgument);
            }
        }

        #endregion

        public DataTable cargarFacultades()
        {
            FacultadBLL facuBLL = new FacultadBLL();
            DataTable dtFacultades = new DataTable();

            dtFacultades = facuBLL.cargarFacultades();

            return dtFacultades;
        }

        public bool sesionIniciada()
        {
            if(Session["Usuario"] != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}