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
    class nBebida
    {
        dBebida objBeb = new dBebida();
        
        public int Agregar_Bebida(string Nombre, float Precio)
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

            return objBeb.AgregarBebida(Nombre, Precio);
        }

        public DataTable ListarBebida()
        {
            return objBeb.Listar_Bebida();
        }
        public int Eliminar_Bebida(int Id)
        {
            if (Id == 0) // valido que el campo ID no este vacio
            {
                throw new ApplicationException("ID Incorrecto.");
            }

            return objBeb.EliminarBebida(Id);
        }
    }
}
