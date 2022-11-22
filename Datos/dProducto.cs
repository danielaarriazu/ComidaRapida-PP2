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
    public class dProducto
    {
        SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlconexion"].ConnectionString);
        public int AgregarProducto(string Nombre, float Precio,int IdCategoria)
        {
            int result = 0;
            SqlCommand cmd = new SqlCommand("sp_Alta_Producto", conexion);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@nombre", Nombre);
            cmd.Parameters.AddWithValue("@precio", Precio);
            cmd.Parameters.AddWithValue("@idCategoria", IdCategoria);

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

        public DataTable Listar_Producto()
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand("sp_ListarProducto", conexion);
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
        public int EliminarProducto(int Id)
        {
            int result = 0;
            SqlCommand cmd = new SqlCommand("sp_Eliminar_Producto", conexion);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@idProducto", Id);
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
