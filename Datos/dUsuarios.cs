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
    public class dUsuarios
    {
        SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlconexion"].ConnectionString);
        

        public bool IniciarSesion(string AliasUsuario, string Contraseña)
        {

            conexion.Open();
            SqlCommand cmd = new SqlCommand("sp_LOGEO", conexion);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@User", AliasUsuario);
            cmd.Parameters.AddWithValue("@Contra", Contraseña);

            cmd.ExecuteNonQuery();
            int result = (int)cmd.ExecuteScalar();

            return result > 0;
        }

    }
}

