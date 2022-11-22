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
    class nAdicional
    {
        dAdicional objAdi = new dAdicional();

        public int Agregar_Adicional(string Nombre, float Precio)
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

            return objAdi.AgregarAdicional(Nombre, Precio);
        }

        public DataTable ListarAdicional()
        {
            return objAdi.Listar_Adicional();
        }
        public int Eliminar_Adicional(int Id)
        {
            if (Id == 0) // valido que el campo ID no este vacio
            {
                throw new ApplicationException("ID Incorrecto.");
            }

            return objAdi.EliminarAdicional(Id);
        }
    }
}
