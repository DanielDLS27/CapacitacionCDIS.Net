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
    public partial class facultad_u : System.Web.UI.Page, IAcceso
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

        protected void btnEditar_Click(object sender, EventArgs e)
        {
            modificarFacultad();
            Page.ClientScript.RegisterStartupScript(this.GetType(), "Alta", "alert('Facultad modificada exitosamente.')", true);
        }

        #endregion

        #region Metodos

        public void cargarFacultad(string codigo)
        {
            FacultadBLL facuBLL = new FacultadBLL();
            DataTable dtFacultad = new DataTable();

            dtFacultad = facuBLL.cargarFacultad(codigo);

            lblIdFacultad.Text = dtFacultad.Rows[0]["ID_Facultad"].ToString();
            txtCodigo.Text = dtFacultad.Rows[0]["codigo"].ToString();
            txtNombre.Text = dtFacultad.Rows[0]["nombre"].ToString();
            txtFechaCreacion.Text = dtFacultad.Rows[0]["fechaCreacion"].ToString().Substring(0,10);
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

        public void modificarFacultad()
        {
            FacultadBLL facuBLL = new FacultadBLL();

            int idFacultad = int.Parse(lblIdFacultad.Text);
            string codigo = txtCodigo.Text;
            string nombre = txtNombre.Text;
            DateTime fechaCreacion = Convert.ToDateTime(txtFechaCreacion.Text);
            int universidad = int.Parse(ddlUniversidad.SelectedValue);

            facuBLL.modificarFacultad(idFacultad, codigo, nombre, fechaCreacion, universidad);
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