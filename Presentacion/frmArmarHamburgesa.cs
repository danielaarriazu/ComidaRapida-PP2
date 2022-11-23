using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Datos;
using Entidades;
using Negocio;

namespace Presentacion
{
    public partial class frmArmarHamburgesa : Form
    {
        public frmArmarHamburgesa()
        {
            InitializeComponent();
        }
        eProducto ePro = new eProducto();
        nProducto objPro = new nProducto();
        DataTable dt = new DataTable();

        int idCat = 0;
        int idProd = 0;
        private void frmArmarHamburgesa_Load(object sender, EventArgs e)
        {
            cmbCategoria.DataSource = objPro.Seleccionar_Categoria();
            cmbCategoria.DisplayMember = "Descripcion";
            cmbCategoria.ValueMember = "Id_Categoria";
            cmbCategoria.SelectedValue = 0;
            dgvCrearHamburgesa_Diseño();
        }
        private void dgvCrearHamburgesa_Diseño()
        {
            dgvCrearHamburgesa.Columns["Id_Categoria"].Visible = false;
            dgvCrearHamburgesa.Columns["Id_Producto"].Visible = false;
            dgvCrearHamburgesa.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            string Medallon = cmbCategoria.Text.ToString();

            idCat = Convert.ToInt32(cmbCategoria.SelectedValue);
            idProd = Convert.ToInt32(cmbProducto.SelectedValue);

            dgvCrearHamburgesa_Diseño();
            cmbCategoria.SelectedValue = 0;
            cmbProducto.SelectedValue = 0;
            txtPrecioHamburgesa.Text = "";
            cmbCategoria.Focus();
            mostrardatos();
            sumar();

        }
        public void mostrardatos()
        {

            dt = objPro.Seleccionar_Producto(idProd, idCat);

            foreach (DataRow data in dt.Rows)
            {
                this.dgvCrearHamburgesa.Rows.Add();
                int aa = this.dgvCrearHamburgesa.RowCount - 1;
                this.dgvCrearHamburgesa.Rows[aa].Cells[0].Value = data["Id_Categoria"].ToString();
                this.dgvCrearHamburgesa.Rows[aa].Cells[1].Value = data["Categoria"].ToString();
                this.dgvCrearHamburgesa.Rows[aa].Cells[2].Value = data["Id_Producto"].ToString();
                this.dgvCrearHamburgesa.Rows[aa].Cells[3].Value = data["Producto"].ToString();
                this.dgvCrearHamburgesa.Rows[aa].Cells[4].Value = data["Precio"].ToString();
            }
        }

        private void cmbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCategoria.Text == "Medallon")
            {
                cmbProducto.DataSource = objPro.ListarMedallon();
                cmbProducto.DisplayMember = "Descripcion";
                cmbProducto.ValueMember = "Id_Producto";
                cmbProducto.SelectedValue = 0;
            }
            if (cmbCategoria.Text == "Ingrediente")
            {
                cmbProducto.DataSource = objPro.ListarIngrediente();
                cmbProducto.DisplayMember = "Descripcion";
                cmbProducto.ValueMember = "Id_Producto";
                cmbProducto.SelectedValue = 0;
            }
        }
        public void sumar()
        {
            decimal totalMonto = 0;
            foreach (DataGridViewRow row in dgvCrearHamburgesa.Rows)
                totalMonto += Convert.ToDecimal(row.Cells["Precio"].Value);
            txtPrecioHamburgesa.Text = Convert.ToString(totalMonto);
        }

        private void dgvCrearHamburgesa_KeyUp(object sender, KeyEventArgs e)
        {
            if ((int)e.KeyData == (int)Keys.Delete)
            {
                dgvCrearHamburgesa.Rows.RemoveAt(dgvCrearHamburgesa.CurrentRow.Index);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            dgvCrearHamburgesa.Rows.Clear();
            txtPrecioHamburgesa.Text = "";
        }

        private void btnCrearH_Click(object sender, EventArgs e)
        {

        }
    }
}