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
   public class dPedidoDetalle
    {
        SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlconexion"].ConnectionString);
        public int AgregarPedidoDetalle(int Cantidad, float SubTotal, int Id_Hamburgesa, int Id_Producto)
        {
            int result = 0;
            SqlCommand cmd = new SqlCommand("sp_Alta_PedidoDetalle", conexion);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@cantidad", Cantidad);
            cmd.Parameters.AddWithValue("@subtotoal", SubTotal);
            cmd.Parameters.AddWithValue("@id_hamburgesa", Id_Hamburgesa);
            cmd.Parameters.AddWithValue("@id_producto", Id_Producto);

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
