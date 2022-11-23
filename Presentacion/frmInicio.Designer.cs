
namespace Presentacion
{
    partial class frmInicio
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInicio));
            this.pnlizquierda = new System.Windows.Forms.Panel();
            this.pnlGestionar = new System.Windows.Forms.Panel();
            this.btnProducto = new System.Windows.Forms.Button();
            this.btnCategoria = new System.Windows.Forms.Button();
            this.btnGestionMenu = new System.Windows.Forms.Button();
            this.btnPedido = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnCliente = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.pnlizquierda.SuspendLayout();
            this.pnlGestionar.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlizquierda
            // 
            this.pnlizquierda.BackColor = System.Drawing.Color.Maroon;
            this.pnlizquierda.Controls.Add(this.pnlGestionar);
            this.pnlizquierda.Controls.Add(this.btnGestionMenu);
            this.pnlizquierda.Controls.Add(this.btnPedido);
            this.pnlizquierda.Controls.Add(this.groupBox2);
            this.pnlizquierda.Controls.Add(this.btnCliente);
            this.pnlizquierda.Controls.Add(this.label7);
            this.pnlizquierda.Controls.Add(this.label8);
            this.pnlizquierda.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlizquierda.Location = new System.Drawing.Point(0, 0);
            this.pnlizquierda.Name = "pnlizquierda";
            this.pnlizquierda.Size = new System.Drawing.Size(954, 169);
            this.pnlizquierda.TabIndex = 8;
            // 
            // pnlGestionar
            // 
            this.pnlGestionar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pnlGestionar.Controls.Add(this.btnProducto);
            this.pnlGestionar.Controls.Add(this.btnCategoria);
            this.pnlGestionar.Location = new System.Drawing.Point(768, 58);
            this.pnlGestionar.Name = "pnlGestionar";
            this.pnlGestionar.Size = new System.Drawing.Size(183, 113);
            this.pnlGestionar.TabIndex = 9;
            // 
            // btnProducto
            // 
            this.btnProducto.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.btnProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProducto.Font = new System.Drawing.Font("Rockwell", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProducto.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnProducto.Image = global::Presentacion.Properties.Resources.producto;
            this.btnProducto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProducto.Location = new System.Drawing.Point(3, 53);
            this.btnProducto.Name = "btnProducto";
            this.btnProducto.Size = new System.Drawing.Size(175, 53);
            this.btnProducto.TabIndex = 5;
            this.btnProducto.Text = "PRODUCTO";
            this.btnProducto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnProducto.UseVisualStyleBackColor = true;
            this.btnProducto.Click += new System.EventHandler(this.btnProducto_Click);
            // 
            // btnCategoria
            // 
            this.btnCategoria.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.btnCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCategoria.Font = new System.Drawing.Font("Rockwell", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCategoria.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCategoria.Image = global::Presentacion.Properties.Resources.categoria;
            this.btnCategoria.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCategoria.Location = new System.Drawing.Point(3, 3);
            this.btnCategoria.Name = "btnCategoria";
            this.btnCategoria.Size = new System.Drawing.Size(175, 53);
            this.btnCategoria.TabIndex = 4;
            this.btnCategoria.Text = "CATEGORIA";
            this.btnCategoria.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCategoria.UseVisualStyleBackColor = true;
            this.btnCategoria.Click += new System.EventHandler(this.btnCategoria_Click);
            // 
            // btnGestionMenu
            // 
            this.btnGestionMenu.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.btnGestionMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGestionMenu.Font = new System.Drawing.Font("Rockwell", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestionMenu.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnGestionMenu.Image = global::Presentacion.Properties.Resources.configuracion1;
            this.btnGestionMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGestionMenu.Location = new System.Drawing.Point(768, 1);
            this.btnGestionMenu.Name = "btnGestionMenu";
            this.btnGestionMenu.Size = new System.Drawing.Size(186, 60);
            this.btnGestionMenu.TabIndex = 3;
            this.btnGestionMenu.Text = "GESTIONAR MENU";
            this.btnGestionMenu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGestionMenu.UseVisualStyleBackColor = true;
            this.btnGestionMenu.Click += new System.EventHandler(this.btnGestionMenu_Click);
            // 
            // btnPedido
            // 
            this.btnPedido.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.btnPedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPedido.Font = new System.Drawing.Font("Rockwell", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPedido.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnPedido.Image = ((System.Drawing.Image)(resources.GetObject("btnPedido.Image")));
            this.btnPedido.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPedido.Location = new System.Drawing.Point(574, 3);
            this.btnPedido.Name = "btnPedido";
            this.btnPedido.Size = new System.Drawing.Size(140, 60);
            this.btnPedido.TabIndex = 2;
            this.btnPedido.Text = "PEDIDO";
            this.btnPedido.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPedido.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Location = new System.Drawing.Point(0, 110);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(957, 10);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            // 
            // btnCliente
            // 
            this.btnCliente.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.btnCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCliente.Font = new System.Drawing.Font("Rockwell", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCliente.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCliente.Image = global::Presentacion.Properties.Resources.cliente;
            this.btnCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCliente.Location = new System.Drawing.Point(318, 4);
            this.btnCliente.Name = "btnCliente";
            this.btnCliente.Size = new System.Drawing.Size(152, 60);
            this.btnCliente.TabIndex = 0;
            this.btnCliente.Text = "CLIENTE";
            this.btnCliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCliente.UseVisualStyleBackColor = true;
            this.btnCliente.Click += new System.EventHandler(this.btnCliente_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Felix Titling", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DarkOrange;
            this.label7.Location = new System.Drawing.Point(70, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 24);
            this.label7.TabIndex = 1;
            this.label7.Text = "TWO";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Location = new System.Drawing.Point(37, 17);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 28);
            this.label8.TabIndex = 0;
            this.label8.Text = "Burger";
            // 
            // frmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Presentacion.Properties.Resources.photo_5057997261979626066_y;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(954, 547);
            this.Controls.Add(this.pnlizquierda);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(960, 480);
            this.Name = "frmInicio";
            this.Text = "Inicio";
            this.Load += new System.EventHandler(this.frmInicio_Load);
            this.pnlizquierda.ResumeLayout(false);
            this.pnlizquierda.PerformLayout();
            this.pnlGestionar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlizquierda;
        private System.Windows.Forms.Button btnGestionMenu;
        private System.Windows.Forms.Button btnPedido;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnCliente;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel pnlGestionar;
        private System.Windows.Forms.Button btnProducto;
        private System.Windows.Forms.Button btnCategoria;
    }
}