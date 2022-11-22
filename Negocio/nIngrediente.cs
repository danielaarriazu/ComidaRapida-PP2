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
    class nIngrediente
    {
        dIngrediente objIng = new dIngrediente();

        public int Agregar_Ingrediente(string Nombre, float Precio)
        {
            //try
            //{
            if (String.IsNullOrEmpty(Nombre.Trim())) //valido que el campo Nombre no este vacio
            {
                throw new ApplicationException("Debe informar el nombre del Producto.");
            }
            if (Precio == 0) // valido que el campo Precio no este vacio
            {
                throw new ApplicationException("Debe informar el precio del Producto.");
            }

            return objIng.AgregarIngrediente(Nombre, Precio);
        }

        public DataTable ListarIngrediente()
        {
            return objIng.Listar_Ingrediente();
        }
        public int Eliminar_Ingrediente(int Id)
        {
            if (Id == 0) // valido que el campo ID no este vacio
            {
                throw new ApplicationException("ID Incorrecto.");
            }

            return objIng.EliminarIngrediente(Id);
        }
    }
}
