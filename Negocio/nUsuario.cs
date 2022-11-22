using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Entidades;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;


namespace Negocio
{
    public class nUsuario
    {
        dUsuarios objUsu = new dUsuarios();
        public bool I_Sesion(string AliasUsuario, string Contraseña)
        {
            return objUsu.IniciarSesion(AliasUsuario, Contraseña);
        }
    }
}