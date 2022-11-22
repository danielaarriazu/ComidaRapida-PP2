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
    class nMedallon
    {
        dMedallon objMed = new dMedallon();

        public int Agregar_Medallon(string Tipo, float Precio)
        {
            //try
            //{
            if (String.IsNullOrEmpty(Tipo.Trim())) //valido que el campo Nombre no este vacio
            {
                throw new ApplicationException("Debe informar el Tipo del Producto.");
            }
            if (Precio == 0) // valido que el campo Precio no este vacio
            {
                throw new ApplicationException("Debe informar el precio del Producto.");
            }

            return objMed.AgregarMedallon(Tipo, Precio);
        }

        public DataTable ListarMedallon()
        {
            return objMed.Listar_Medallon();
        }
        public int Eliminar_Medallon(int Id)
        {
            if (Id == 0) // valido que el campo ID no este vacio
            {
                throw new ApplicationException("ID Incorrecto.");
            }

            return objMed.EliminarMedallon(Id);
        }
    }
}
