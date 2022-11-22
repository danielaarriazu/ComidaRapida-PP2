using System;
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
    public partial class frmCategoria : Form
    {
        public frmCategoria()
        {
            InitializeComponent();
        }
        eCategoria eCli = new eCategoria();
        nCategoria objCat = new nCategoria();
        int Fila = 0;
        private void frmCategoria_Load(object sender, EventArgs e)
        {
            dgvCategoria.Visible = true;
            dgvCategoria.DataSource = null;
            dgvCategoria.DataSource = objCat.ListarCategoria();
            dgvCategoria_Diseño();
        }
        private void btnOk_Click(object sender, EventArgs e)
        {
            try
            {
                objCat.Agregar_Categoria(txtDescripcion.Text);

                dgvCategoria.Visible = true;
                dgvCategoria.DataSource = null;
                dgvCategoria.DataSource = objCat.ListarCategoria();
                dgvCategoria_Diseño();
                MessageBox.Show("Se agrego la categoria: " + txtDescripcion.Text + " con Exito", "Registro Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDescripcion.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                var id = int.Parse(lblID.Text);
                objCat.Eliminar_Categoria(int.Parse(lblID.Text));
                dgvCategoria.DataSource = null;
                dgvCategoria.DataSource = objCat.ListarCategoria();
                dgvCategoria_Diseño();
                MessageBox.Show("Se elimino la categoria: " + txtDescripcion.Text + " con Exito", "Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void dgvCategoria_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Fila = dgvCategoria.CurrentRow.Index;
            lblID.Text= dgvCategoria.Rows[Fila].Cells["Id_Categoria"].Value.ToString();
            txtDescripcion.Text = dgvCategoria.Rows[Fila].Cells["Descripcion"].Value.ToString();
            btnOk.Enabled = false;
        }

        private void dgvCategoria_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Fila = dgvCategoria.CurrentRow.Index;
            lblID.Text = dgvCategoria.Rows[Fila].Cells["Id_Categoria"].Value.ToString();
            txtDescripcion.Text = dgvCategoria.Rows[Fila].Cells["Descripcion"].Value.ToString();
            btnOk.Enabled = false;
        }

        private void dgvCategoria_KeyUp(object sender, KeyEventArgs e)
        {
            if ((int)e.KeyData == (int)Keys.Delete)
            {
                lblID.Text = dgvCategoria.Rows[Fila].Cells["Id_Categoria"].Value.ToString();
                objCat.Eliminar_Categoria(int.Parse(lblID.Text));
                dgvCategoria.DataSource = null;
                dgvCategoria.DataSource = objCat.ListarCategoria();
                dgvCategoria_Diseño();
                txtDescripcion.Text = "";
                MessageBox.Show("Se elimino la categoria: " + txtDescripcion.Text + " con Exito", "Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnAgregarProductos_Click(object sender, EventArgs e)
        {
            frmProductos prod = new frmProductos();
            prod.Show();
        }

        private void pnlAgregarItems_Click(object sender, EventArgs e)
        {
            btnOk.Enabled = true;
            txtDescripcion.Text = "";
        }
        private void dgvCategoria_Diseño()
        {
            dgvCategoria.Columns["Id_Categoria"].Visible = false;
            dgvCategoria.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
        }
    }
}
