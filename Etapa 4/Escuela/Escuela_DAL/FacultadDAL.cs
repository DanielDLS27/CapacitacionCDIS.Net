using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escuela_DAL
{
    public class FacultadDAL
    {
        public DataTable cargarFacultades()
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = @"Server=DESKTOP-AJ3H9PS\SQLEXPRESS;Database=Escuela;Trusted_connection=true";

            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "sp_cargarFacultades";
            command.Connection = connection;

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable dtFacultades = new DataTable();

            connection.Open();

            adapter.SelectCommand = command;
            adapter.Fill(dtFacultades);

            connection.Close();

            return dtFacultades;
        }

        public void agregarFacultad(string codigo, string nombre, DateTime fechaCreacion, int universidad)
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = @"Server=DESKTOP-AJ3H9PS\SQLEXPRESS;Database=Escuela;Trusted_connection=true";

            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "sp_agregarFacultad";
            command.Connection = connection;

            command.Parameters.AddWithValue("pCodigo", codigo);
            command.Parameters.AddWithValue("pNombre", nombre);
            command.Parameters.AddWithValue("pFechaCreacion", fechaCreacion);
            command.Parameters.AddWithValue("pUniversidad", universidad);

            connection.Open();

            command.ExecuteNonQuery();

            connection.Close();
        }

        public DataTable cargarFacultad(string codigo)
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = @"Server=DESKTOP-AJ3H9PS\SQLEXPRESS;Database=Escuela;Trusted_connection=true";

            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "sp_cargarFacultadPorCodigo";
            command.Connection = connection;

            command.Parameters.AddWithValue("pCodigo", codigo);

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable dtFacultad = new DataTable();

            connection.Open();

            adapter.SelectCommand = command;
            adapter.Fill(dtFacultad);

            connection.Close();

            return dtFacultad;

           
        }

        public void modificarFacultad(int idFacultad, string codigo, string nombre, DateTime fechaCreacion, int universidad)
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = @"Server=DESKTOP-AJ3H9PS\SQLEXPRESS;Database=Escuela;Trusted_connection=true";

            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "sp_modificarFacultad";
            command.Connection = connection;

            command.Parameters.AddWithValue("pID", idFacultad);
            command.Parameters.AddWithValue("pCodigo", codigo);
            command.Parameters.AddWithValue("pNombre", nombre);
            command.Parameters.AddWithValue("pFechaCreacion", fechaCreacion);
            command.Parameters.AddWithValue("pUniversidad", universidad);

            connection.Open();

            command.ExecuteNonQuery();

            connection.Close();
        }

        public void eliminarFacultad(int idFacultad)
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = @"Server=DESKTOP-AJ3H9PS\SQLEXPRESS;Database=Escuela;Trusted_connection=true";

            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "sp_eliminarFacultad";
            command.Connection = connection;

            command.Parameters.AddWithValue("pID", idFacultad);

            connection.Open();

            command.ExecuteNonQuery();

            connection.Close();
        }
    }
}
