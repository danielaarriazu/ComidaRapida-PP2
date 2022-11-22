using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.IO;
using System.Configuration;
using System.Data;
using Microsoft.Win32;
using System.Windows.Forms;
using Entidades;

namespace Datos
{
    public class dCategoria
    {
       static SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlconexion"].ConnectionString);
        public int AgregarCategoria(string Descripcion)
        {
            int result = 0;
            SqlCommand cmd = new SqlCommand("sp_Alta_Categoria", conexion);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@descripcion", Descripcion);

            try
            {
                conexion.Open();
                cmd.ExecuteNonQuery();
                result = 1;
            }
            catch { }
            finally
            {
                conexion.Close();
            }
            return result;
        }
        public DataTable Listar_Categoria()
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand("sp_Listar_Categoria", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                conexion.Open();
                cmd.ExecuteNonQuery();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
            }
            catch { }
            finally
            {
                conexion.Close();
            }

            return dt;
        }
        public int EliminarCategoria(int Id)
        {
            int result = 0;
            SqlCommand cmd = new SqlCommand("sp_Eliminar_Categoria", conexion);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@idCategoria", Id);
            try
            {
                conexion.Open();
                cmd.ExecuteNonQuery();
                result = 1;
            }
            catch { }
            finally
            {
                conexion.Close();
            }
            return result;
        }
    }
}
