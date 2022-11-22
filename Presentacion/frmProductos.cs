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
    public partial class frmProductos : Form
    {
        public frmProductos()
        {
            InitializeComponent();
        }
        eProducto ePro = new eProducto();
        nProducto objPro = new nProducto();
        nCategoria objCat = new nCategoria();
       
        int Fila = 0;
        private void frmProductos_Load(object sender, EventArgs e)
        {
            cmbCategoria.DataSource = objCat.ListarCategoria();
            cmbCategoria.DisplayMember = "Descripcion";
            cmbCategoria.ValueMember = "Id_Categoria";
            cmbCategoria.SelectedValue = 0;
            dgvProductos.Visible = true;
            dgvProductos.DataSource = null;
            dgvProductos.DataSource = objPro.ListarProducto();
            dgvProducto_Diseño();

        }
        private void btnOk_Click(object sender, EventArgs e)
        {
            try
            {

                objPro.Agregar_Producto(txtNombre.Text, float.Parse(txtPrecio.Text),int.Parse(cmbCategoria.SelectedValue.ToString()));// agregar id categoria
                dgvProductos.Visible = true;
                dgvProductos.DataSource = null;
                dgvProductos.DataSource = objPro.ListarProducto();
                dgvProducto_Diseño();
                MessageBox.Show("Se agrego la producto: " + txtNombre.Text + " a la categoria " + cmbCategoria.Text+" con Exito", "Registro Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Limpiartxt();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }
        void Limpiartxt() // limpio todos los texbox cuando se registra un usuario
        {
            txtNombre.Text = "";
            cmbCategoria.SelectedValue = 0;
            txtPrecio.Text = "";
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                var id = int.Parse(lblID.Text);
                objPro.Eliminar_Producto(int.Parse(lblID.Text));
                dgvProductos.DataSource = null;
                dgvProductos.DataSource = objPro.ListarProducto();
                dgvProducto_Diseño();
                MessageBox.Show("Se elimino el producto: " + txtNombre.Text + " de la categoria " + cmbCategoria.Text + " con Exito", "Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Limpiartxt();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void pnlAgregarItems_Click(object sender, EventArgs e)
        {
            btnOk.Enabled = true;
            Limpiartxt();
        }

        private void dgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Fila = dgvProductos.CurrentRow.Index;

            lblID.Text = dgvProductos.Rows[Fila].Cells["Id_Producto"].Value.ToString();
            txtNombre.Text = dgvProductos.Rows[Fila].Cells["Nombre"].Value.ToString();
            txtPrecio.Text = dgvProductos.Rows[Fila].Cells["Precio"].Value.ToString();
            cmbCategoria.SelectedValue = int.Parse(dgvProductos.Rows[Fila].Cells["Id_Categoria"].Value.ToString());
            //cargar combo box categoria
            btnOk.Enabled = false;
        }

        private void dgvProductos_KeyUp(object sender, KeyEventArgs e)
        {
            if ((int)e.KeyData == (int)Keys.Delete)
            {
                lblID.Text = dgvProductos.Rows[Fila].Cells["Id_Producto"].Value.ToString();
                objPro.Eliminar_Producto(int.Parse(lblID.Text));
                dgvProductos.DataSource = null;
                dgvProductos.DataSource = objPro.ListarProducto();
                dgvProducto_Diseño();
                MessageBox.Show("Se elimino el producto: " + txtNombre.Text + " de la categoria " + cmbCategoria.Text + " con Exito", "Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Limpiartxt();
            }
        }
        private void dgvProducto_Diseño()
        {
            dgvProductos.Columns["Id_Categoria"].Visible = false;
            dgvProductos.Columns["Id_Producto"].Visible = false;
            dgvProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
        }
    }
}
