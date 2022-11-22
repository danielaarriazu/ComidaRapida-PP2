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
using System.Windows;
using Entidades;
using System.Windows.Forms;

namespace Datos
{
    public class ConexionBD
    {
        
        //string conexionstring;
        //public SqlConnection IniciarConexion()
        //{
        //    try
        //    {
        //        SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlconexion"].ConnectionString);
        //        //conexionstring = ConfigurationManager.ConnectionStrings["sqlconexion"].ConnectionString;
        //        //conexion.ConnectionString = conexionstring;
        //        conexion.Open();
        //        MessageBox.Show("La conexion se realizo correctamente");
        //    }
        //    catch (SqlException)
        //    {
        //        MessageBox.Show(" Error al conectar la base de datos. ");
        //    }
        //    return conexion;
        //}
        //public void CerrarConexion()
        //{
        //    try
        //    {
        //        SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlconexion"].ConnectionString);
        //        conexion.Close();
        //        MessageBox.Show("El cierre de la conexion se realizo correctamente");
        //    }
        //    catch (SqlException)
        //    {
        //        MessageBox.Show("Error al desconectar la base de datos");
        //    }
        //}


    }
}
