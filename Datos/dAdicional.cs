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
   public class dAdicional
    {
        SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlconexion"].ConnectionString);
        public int AgregarAdicional(string Nombre, float Precio)
        {
            int result = 0;
            SqlCommand cmd = new SqlCommand("sp_Alta_Adicional", conexion);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@nombre", Nombre);
            cmd.Parameters.AddWithValue("@precio", Precio);
            
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

        public DataTable Listar_Adicional()
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand("sp_Listar_Adicional", conexion);
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
        public int EliminarAdicional(int Id)
        {
            int result = 0;
            SqlCommand cmd = new SqlCommand("sp_Eliminar_Adicional", conexion);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@idAdicional", Id);
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
