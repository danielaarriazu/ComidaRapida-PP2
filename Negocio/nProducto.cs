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
   public class nProducto
    {
        dProducto objPro = new dProducto();

        public int Agregar_Producto(string Nombre, float Precio, int IdCategoria)
        {
            if (String.IsNullOrEmpty(Nombre.Trim())) //valido que el campo Nombre no este vacio
            {
                throw new ApplicationException("Debe informar el nombre del Producto.");
            }
            if (Precio == 0) // valido que el campo Precio no este vacio
            {
                throw new ApplicationException("Debe informar el precio del Producto.");
            }
            if (IdCategoria == 0) // valido que el campo Id no este vacio
            {
                throw new ApplicationException("Debe informar el Id de la Categoria.");
            }

            return objPro.AgregarProducto(Nombre, Precio,IdCategoria);
        }

        public DataTable ListarProducto()
        {
            return objPro.Listar_Producto();
        }
        public int Eliminar_Producto(int Id)
        {
            if (Id == 0) // valido que el campo ID no este vacio
            {
                throw new ApplicationException("ID Incorrecto.");
            }

            return objPro.EliminarProducto(Id);
        }
    }
}
