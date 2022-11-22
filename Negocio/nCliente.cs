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
   public class nCliente
    {
        dCliente objCli = new dCliente();
        public int Agregar_Cliente(string Nombre, string Apellido, int Telefono, string Direccion)
        {
            //try
            //{
                if (String.IsNullOrEmpty(Direccion.Trim())) //valido que el campo Direccion no este vacio
                {
                    throw new ApplicationException("Debe informar la dirección de la persona.");
                }
                if (Telefono == 0) // valido que el campo telefono no este vacio
                {
                    throw new ApplicationException("Debe informar el Telefono de la persona.");
                }
                if (String.IsNullOrEmpty(Nombre.Trim())) // valido que el campo Nombre no este vacio
                {
                    throw new ApplicationException("Debe informar el Nombre de la persona.");
                }
                if (String.IsNullOrEmpty(Apellido.Trim())) // valido que el campo Apellido no este vacio
                {
                    throw new ApplicationException("Debe informar el Apellido de la persona.");
                }

                return objCli.AgregarCliente(Nombre, Apellido, Telefono, Direccion);
        }

        public DataTable ListarEmpleados()
        {
            return objCli.Listar_Clientes();
        }
        public int Modificar_Cliente(int Id,string Nombre, string Apellido, int Telefono, string Direccion)
        {
            if (Id == 0) // valido que el campo ID no este vacio
            {
                throw new ApplicationException("ID Incorrecto.");
            }
            if (String.IsNullOrEmpty(Direccion.Trim())) //valido que el campo Direccion no este vacio
            {
                throw new ApplicationException("Debe informar la dirección de la persona.");
            }
            if (Telefono == 0) // valido que el campo telefono no este vacio
            {
                throw new ApplicationException("Debe informar el Telefono de la persona.");
            }
            if (String.IsNullOrEmpty(Nombre.Trim())) // valido que el campo Nombre no este vacio
            {
                throw new ApplicationException("Debe informar el Nombre de la persona.");
            }
            if (String.IsNullOrEmpty(Apellido.Trim())) // valido que el campo Apellido no este vacio
            {
                throw new ApplicationException("Debe informar el Apellido de la persona.");
            }

            return objCli.ModificarCliente(Id,Nombre, Apellido, Telefono, Direccion);
        }
        public int Eliminar_Cliente(int Id)
        {
            if (Id == 0) // valido que el campo ID no este vacio
            {
                throw new ApplicationException("ID Incorrecto.");
            }
            
            return objCli.EliminarCliente(Id);
        }
    }
}
