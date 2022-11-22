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
   public class nCategoria
    {
        dCategoria objCat = new dCategoria();

        public int Agregar_Categoria(string Descripcion)
        {
            if (String.IsNullOrEmpty(Descripcion.Trim())) //valido que el campo Descripcion no este vacio
            {
                throw new ApplicationException("Debe informar la descripcion de la Categoria.");
            }

            return objCat.AgregarCategoria(Descripcion);
        }

        public DataTable ListarCategoria()
        {
            return objCat.Listar_Categoria();
        }
        public int Eliminar_Categoria(int Id)
        {
            if (Id == 0) // valido que el campo ID no este vacio
            {
                throw new ApplicationException("ID Incorrecto.");
            }

            return objCat.EliminarCategoria(Id);
        }
    }
}
