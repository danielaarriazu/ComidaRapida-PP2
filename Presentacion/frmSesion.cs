﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using Negocio;



namespace Presentacion
{
    public partial class frmSesion : Form
    {
        public frmSesion()
        {
            InitializeComponent();
        }
         eUsuario eUsu = new eUsuario();
         nUsuario nUsu = new nUsuario();

       
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (nUsu.I_Sesion(txtUsuario.Text, txtContraseña.Text))
            {
                frmInicio inicio = new frmInicio();
                inicio.Show();
                string mensaje = string.Format("Bienvenido {0}", txtUsuario.Text);

            }
        }
    }
}
