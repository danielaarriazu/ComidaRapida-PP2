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
    public class dCliente
    {
        SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlconexion"].ConnectionString);
        public int AgregarCliente(string Nombre, string Apellido, int Telefono, string Direccion)
        {
            int result = 0;
            SqlCommand cmd = new SqlCommand("sp_Alta_Cliente", conexion);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@nombre", Nombre);
            cmd.Parameters.AddWithValue("@apellido", Apellido);
            cmd.Parameters.AddWithValue("@tel", Telefono);
            cmd.Parameters.AddWithValue("@direccion", Direccion);
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

        public DataTable Listar_Clientes()
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand("sp_Listar_Cliente", conexion);
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
        public int ModificarCliente(int Id,string Nombre, string Apellido, int Telefono, string Direccion)
        {
            int result = 0;
            SqlCommand cmd = new SqlCommand("sp_Modificar_Cliente", conexion);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@idCliente", Id);
            cmd.Parameters.AddWithValue("@nombre", Nombre);
            cmd.Parameters.AddWithValue("@apellido", Apellido);
            cmd.Parameters.AddWithValue("@tel", Telefono);
            cmd.Parameters.AddWithValue("@direccion", Direccion);
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
        public int EliminarCliente(int Id)
        {
            int result = 0;
            SqlCommand cmd = new SqlCommand("sp_Eliminar_Cliente", conexion);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@idCliente", Id);
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
