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
    class nHamburgesa
    {
        dHamburgesa objHamb = new dHamburgesa();

        public int Agregar_Hamburgesa(int IdProducto, float Precio)
        {
            //try
            if (IdProducto == 0) // valido que el campo IdProducto no este vacio
            {
                throw new ApplicationException("Debe informar el IdProducto del Producto.");
            }
            if (Precio == 0) // valido que el campo Precio no este vacio
            {
                throw new ApplicationException("Debe informar el precio de la Hamburgesa.");
            }

            return objHamb.AgregarHamburgesa(IdProducto, Precio);
        }

        public DataTable ListarHamburgesa()
        {
            return objHamb.Listar_Hamburgesa();
        }
        public int Eliminar_Hamburgesa(int Id)
        {
            if (Id == 0) // valido que el campo ID no este vacio
            {
                throw new ApplicationException("ID Incorrecto.");
            }

            return objHamb.EliminarHamburgesa(Id);
        }
    }
}
