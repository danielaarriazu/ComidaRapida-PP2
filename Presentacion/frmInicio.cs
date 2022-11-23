using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
        }

        private void btnGestionMenu_Click(object sender, EventArgs e)
        {
            if (pnlGestionar.Visible== true)
            {
                pnlGestionar.Visible = false;
            }
            else
            {
                pnlGestionar.Visible = true;
            }
        }

        private void frmInicio_Load(object sender, EventArgs e)
        {
            pnlGestionar.Visible = false;
        }

        private void btnCategoria_Click(object sender, EventArgs e)
        {
            if (pnlGestionar.Visible == true)
            {
                pnlGestionar.Visible = false;
            }
            else
            {
                pnlGestionar.Visible = true;
            }
            frmCategoria categ = new frmCategoria();
            categ.Show();
        }

        private void btnProducto_Click(object sender, EventArgs e)
        {
            if (pnlGestionar.Visible == true)
            {
                pnlGestionar.Visible = false;
            }
            else
            {
                pnlGestionar.Visible = true;
            }
            frmProductos prod = new frmProductos();
            prod.Show();
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            frmCliente cli = new frmCliente();
            cli.Show();
        }
    }
}
