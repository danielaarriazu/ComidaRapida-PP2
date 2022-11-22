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
    public partial class frmCliente : Form
    {
        public frmCliente()
        {
            InitializeComponent();
        }
        eCliente eCli = new eCliente();
        nCliente nCLi = new nCliente();
        nCliente objCli = new nCliente();
        int Fila = 0;

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) // solo permite que se ingrese numeros 
            {
                e.Handled = true;
            }
        }
        //private void btnAgregarCliente_Click(object sender, EventArgs e)
        //{
        //    lblTitulo.Text = "CARGAR CLIENTES";
        //    pbImagenCliente.Image = Tp_Integrador_BurgerSix.Properties.Resources.Agregar_persona;

        //    if (ListaCliente.Count == 0)
        //    {
        //        dgvClientes.Visible = false;
        //    }
        //    else
        //    {
        //        dgvClientes.Visible = true;
        //    }
        //    Habilitartxt();
        //    Limpiartxt();
        //    gbDatos.Visible = true;
        //    //gbGrillaClientes.Visible = true;
        //}

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (lblTitulo.Text == "CARGAR CLIENTES")
            {
                try
                {
                    // cargo el objeto cliente con todos los valores de los texbox
                    objCli.Agregar_Cliente(txtNombre.Text, txtApellido.Text, int.Parse(txtTelefono.Text), txtDireccion.Text);

                    // ListaCliente = objCli.RegistrarCliente(objCli, ListaCliente);
                    Limpiartxt();
                    gbDatos.Visible = true;
                    //gbGrillaClientes.Visible = true;
                    dgvClientes.Visible = true;
                    dgvClientes.DataSource = null;
                    dgvClientes.DataSource = objCli.ListarEmpleados();
                    MessageBox.Show("Cliente : " + txtNombre.Text + " Registrado con Exito", "Registro Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }
            if (lblTitulo.Text == "MODIFICAR CLIENTES")
            {
                try
                {
                    if (string.IsNullOrEmpty(txtDireccion.Text))
                    {
                        txtDireccion.Focus();
                        throw new ApplicationException("No puede dejar valores vacios");
                    }
                    if ((string.IsNullOrEmpty(txtTelefono.Text)))
                    {
                        txtTelefono.Focus();
                        throw new ApplicationException("No puede dejar valores vacios");
                    }
                    else
                    {
                        var tel = long.Parse(txtTelefono.Text);
                        objCli.Modificar_Cliente(int.Parse(lblID.Text), txtNombre.Text, txtApellido.Text, int.Parse(txtTelefono.Text), txtDireccion.Text);
                        dgvClientes.DataSource = null;
                        dgvClientes.DataSource = objCli.ListarEmpleados();
                        MessageBox.Show("Cliente : " + txtNombre.Text + " Modificado con Exito", "Modificacion Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            if (lblTitulo.Text == "ELIMINAR CLIENTES")
            {
                try
                {
                    var id = int.Parse(lblID.Text);
                    objCli.Eliminar_Cliente(int.Parse(lblID.Text));
                    dgvClientes.DataSource = null;
                    dgvClientes.DataSource = objCli.ListarEmpleados();
                    Limpiartxt();
                    MessageBox.Show("Cliente : " + txtNombre.Text + " Eliminado con Exito", "Modificacion Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }


        private void btnMidificarCliente_Click(object sender, EventArgs e)
        {
            Habilitartxt();
            Limpiartxt();
            lblTitulo.Text = "MODIFICAR CLIENTES";
            pbImagenCliente.Image = Presentacion.Properties.Resources.Modificar_persona;
            txtApellido.Enabled = false;
            txtNombre.Enabled = false;

            if (dgvClientes.Rows.Count == 0)
            {
                dgvClientes.Visible = false;
            }
            else
            {
                dgvClientes.DataSource = objCli.ListarEmpleados();
                dgvClientes.Visible = true;
            }

            gbDatos.Visible = true;
            // gbGrillaClientes.Visible = true;
        }

        private void dgvClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (lblTitulo.Text == "MODIFICAR CLIENTES" || lblTitulo.Text == "ELIMINAR CLIENTES")
            {
                Fila = dgvClientes.CurrentRow.Index;
                txtNombre.Text = dgvClientes.Rows[Fila].Cells["Nombre"].Value.ToString();
                txtApellido.Text = dgvClientes.Rows[Fila].Cells["Apellido"].Value.ToString();
                txtTelefono.Text = dgvClientes.Rows[Fila].Cells["Telefono"].Value.ToString();
                txtDireccion.Text = dgvClientes.Rows[Fila].Cells["Direccion"].Value.ToString();
                lblID.Text = dgvClientes.Rows[Fila].Cells["ID_Cliente"].Value.ToString();
            }

        }
        void Limpiartxt() // limpio todos los texbox cuando se registra un usuario
        {
            txtApellido.Text = "";
            txtNombre.Text = "";
            txtDireccion.Text = "";
            txtTelefono.Text = "";
        }
        void Habilitartxt()
        {
            txtApellido.Enabled = true;
            txtNombre.Enabled = true;
            txtDireccion.Enabled = true;
            txtTelefono.Enabled = true;
        }

        private void frmCliente_Load(object sender, EventArgs e)
        {
            if (dgvClientes.Rows.Count == 0)
            {
                dgvClientes.Visible = false;
            }
            else
            {
                dgvClientes.Visible = true;
                dgvClientes.DataSource = null;
                dgvClientes.DataSource = objCli.ListarEmpleados();
            }
            gbDatos.Visible = true;
        }

        private void dgvClientes_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (lblTitulo.Text == "MODIFICAR CLIENTES" || lblTitulo.Text == "ELIMINAR CLIENTES")
            {
                Fila = dgvClientes.CurrentRow.Index;
                txtNombre.Text = dgvClientes.Rows[Fila].Cells["Nombre"].Value.ToString();
                txtApellido.Text = dgvClientes.Rows[Fila].Cells["Apellido"].Value.ToString();
                txtTelefono.Text = dgvClientes.Rows[Fila].Cells["Telefono"].Value.ToString();
                txtDireccion.Text = dgvClientes.Rows[Fila].Cells["Direccion"].Value.ToString();
                lblID.Text = dgvClientes.Rows[Fila].Cells["ID_Cliente"].Value.ToString();
            }
        }

        private void btnEliminarCliente_Click(object sender, EventArgs e)
        {
            lblTitulo.Text = "ELIMINAR CLIENTES";
            Limpiartxt();
            pbImagenCliente.Image = Presentacion.Properties.Resources.Eliminar_persona;
            txtApellido.Enabled = false;
            txtNombre.Enabled = false;
            txtDireccion.Enabled = false;
            txtTelefono.Enabled = false;

            if (dgvClientes.Rows.Count == 0)
            {
                dgvClientes.Visible = false;
            }
            else
            {
                dgvClientes.Visible = true;
                dgvClientes.DataSource = null;
                dgvClientes.DataSource = objCli.ListarEmpleados();
            }
            gbDatos.Visible = true;
            //gbGrillaClientes.Visible = true;
        }

        private void dgvClientes_KeyUp(object sender, KeyEventArgs e)
        {
            if ((int)e.KeyData == (int)Keys.Delete)
            {
                lblID.Text = dgvClientes.Rows[Fila].Cells["ID_Cliente"].Value.ToString();
                objCli.Eliminar_Cliente(int.Parse(lblID.Text));
                dgvClientes.DataSource = null;
                dgvClientes.DataSource = objCli.ListarEmpleados();
                Limpiartxt();
                MessageBox.Show("Cliente : " + txtNombre.Text + " Eliminado con Exito", "Modificacion Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            //private void dgvClientes_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
            //{
            //    Cliente cli_ = new Cliente("", "", "", "", 0);
            //    Fila = dgvClientes.CurrentRow.Index;
            //    cli_.Nombre = dgvClientes.Rows[Fila].Cells["Nombre"].Value.ToString();
            //    cli_.Apellido = dgvClientes.Rows[Fila].Cells["Apellido"].Value.ToString();
            //    cli_.Correo = dgvClientes.Rows[Fila].Cells["Correo"].Value.ToString();
            //    cli_.Telefono = (long)dgvClientes.Rows[Fila].Cells["Telefono"].Value;
            //    cli_.Direccion = dgvClientes.Rows[Fila].Cells["Direccion"].Value.ToString();
            //    lblID.Text = dgvClientes.Rows[Fila].Cells["ID_Cliente"].Value.ToString();
            //    frmArmarPedido_ pedido_ = new frmArmarPedido_(cli_, ListaCliente);
            //    pedido_.Cli = cli_; // paso los valores de la lista cliente a el frmInicio
            //    pedido_.Show();
            //    this.Hide();
            //}
        }

        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            Limpiartxt();
            if (dgvClientes.Rows.Count == 0)
            {
                dgvClientes.Visible = false;
            }
            else
            {
                dgvClientes.Visible = true;
                dgvClientes.DataSource = null;
                dgvClientes.DataSource = objCli.ListarEmpleados();
            }
            gbDatos.Visible = true;
        }
    }
}
