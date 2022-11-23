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
    public partial class frmArmarPedido : Form
    {
        public frmArmarPedido()
        {
            InitializeComponent();
        }
        eHamburgesa eHam = new eHamburgesa();
        eProducto eProd = new eProducto();
        nHamburgesa objHam = new nHamburgesa();
        nProducto objPro = new nProducto();
        bool btnhambur = false;
        bool btnbebida = false;
        bool btnadici = false;

        private void btnHambuegesa_Click(object sender, EventArgs e)
        {
            frmArmarHamburgesa  FrmHam = new frmArmarHamburgesa();
            FrmHam.TopLevel = false;
            pnlFrmCrearPedido.Controls.Add(FrmHam);
            FrmHam.Show();
        }

        //private void btnHambuegesa_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        btnhambur = true;
        //        btnadici = false;
        //        btnbebida = false;
        //        label3.Visible = true;
        //        label4.Visible = true;
        //        label5.Visible = true;
        //        label6.Visible = true;
        //        imgFondo.Visible = false;
        //        txtPrecio.Visible = true;
        //        nudCantidad.Visible = true;
        //        cmbTipo.Visible = true;
        //        cmbIngredientes.Visible = true;
        //        label7.Visible = false;
        //        clbAdicionales.Visible = false;
        //        clbAderezos.Visible = false;

        //        listaAdi.Clear();
        //        listaBebidas.Clear();


        //        lblEleccionPedido.Text = "Elige tu hamburgesa";

        //        ali = new HamburgesaCarne("Hamburgesa de Carne", 0, "");
        //        listAli.Add(ali);
        //        ali = new HamburgesaCarne("Hamburgesa de Pollo", 0, "");
        //        listAli.Add(ali);
        //        ali = new HamburgesaCarne("Hamburgesa Vegetariana", 0, "");
        //        listAli.Add(ali);

        //        cmbTipo.DataSource = listAli;
        //        cmbTipo.DisplayMember = "Tipo";
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        //    }
        //}
    }
}
