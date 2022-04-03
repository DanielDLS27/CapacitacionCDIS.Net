using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Escuela_BLL;

namespace Escuela.Facultades
{
    public partial class facultad_d : System.Web.UI.Page, IAcceso
    {
        #region Eventos

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (sesionIniciada())
                {
                    string codigo = Request.QueryString["pCodigo"];
                    cargarUniversidades();
                    cargarFacultad(codigo);
                }
                else
                {
                    Response.Redirect("~/Login.aspx");
                }
            }
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            eliminarFacultad();
            Page.ClientScript.RegisterStartupScript(this.GetType(), "Alta", "alert('Facultad eliminada exitosamente.')", true);
        }

        #endregion

        #region Metodos

        public void cargarFacultad(string codigo)
        {
            FacultadBLL facuBLL = new FacultadBLL();
            DataTable dtFacultad = new DataTable();

            dtFacultad = facuBLL.cargarFacultad(codigo);

            lblIdFacultad.Text = dtFacultad.Rows[0]["ID_Facultad"].ToString();
            lblCodigo.Text = dtFacultad.Rows[0]["codigo"].ToString();
            lblNombre.Text = dtFacultad.Rows[0]["nombre"].ToString();
            lblFechaCreacion.Text = dtFacultad.Rows[0]["fechaCreacion"].ToString().Substring(0, 10);
            ddlUniversidad.SelectedValue = dtFacultad.Rows[0]["universidad"].ToString();
        }

        public void cargarUniversidades()
        {
            UniversidadBLL uniBLL = new UniversidadBLL();
            DataTable dtUniversidades = new DataTable();

            dtUniversidades = uniBLL.cargarUniversidades();

            ddlUniversidad.DataSource = dtUniversidades;
            ddlUniversidad.DataTextField = "nombre";
            ddlUniversidad.DataValueField = "ID_Universidad";
            ddlUniversidad.DataBind();

            ddlUniversidad.Items.Insert(0, new ListItem("---- Seleccione Universidad ----", "0"));

        }

        public void eliminarFacultad()
        {
            FacultadBLL facuBLL = new FacultadBLL();

            int idFacultad = int.Parse(lblIdFacultad.Text);

            facuBLL.eliminarFacultad(idFacultad);
        }

        public bool sesionIniciada()
        {
            if (Session["Usuario"] != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        #endregion


    }
}