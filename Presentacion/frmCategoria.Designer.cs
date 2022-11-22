
namespace Presentacion
{
    partial class frmCategoria
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlAgregarItems = new System.Windows.Forms.Panel();
            this.lblID = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.dgvCategoria = new System.Windows.Forms.DataGridView();
            this.pnlGrillaCategoria = new System.Windows.Forms.Panel();
            this.btnAgregarProductos = new System.Windows.Forms.Button();
            this.pnlAgregarItems.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategoria)).BeginInit();
            this.pnlGrillaCategoria.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlAgregarItems
            // 
            this.pnlAgregarItems.BackColor = System.Drawing.Color.Coral;
            this.pnlAgregarItems.Controls.Add(this.btnAgregarProductos);
            this.pnlAgregarItems.Controls.Add(this.btnEliminar);
            this.pnlAgregarItems.Controls.Add(this.lblID);
            this.pnlAgregarItems.Controls.Add(this.lblTitulo);
            this.pnlAgregarItems.Controls.Add(this.btnOk);
            this.pnlAgregarItems.Controls.Add(this.label2);
            this.pnlAgregarItems.Controls.Add(this.txtDescripcion);
            this.pnlAgregarItems.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlAgregarItems.Location = new System.Drawing.Point(0, 0);
            this.pnlAgregarItems.Name = "pnlAgregarItems";
            this.pnlAgregarItems.Size = new System.Drawing.Size(528, 203);
            this.pnlAgregarItems.TabIndex = 1;
            this.pnlAgregarItems.Click += new System.EventHandler(this.pnlAgregarItems_Click);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(12, 9);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(16, 13);
            this.lblID.TabIndex = 54;
            this.lblID.Text = "Id";
            this.lblID.Visible = false;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTitulo.Location = new System.Drawing.Point(130, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(242, 28);
            this.lblTitulo.TabIndex = 53;
            this.lblTitulo.Text = "AGREGAR CATEGORIA";
            // 
            // btnOk
            // 
            this.btnOk.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.btnOk.FlatAppearance.BorderSize = 2;
            this.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOk.Font = new System.Drawing.Font("Rockwell", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOk.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnOk.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOk.Location = new System.Drawing.Point(377, 60);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(124, 53);
            this.btnOk.TabIndex = 52;
            this.btnOk.Text = "Agregar";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Rockwell", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 20);
            this.label2.TabIndex = 47;
            this.label2.Text = "Descripcion:";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Font = new System.Drawing.Font("Rockwell", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.Location = new System.Drawing.Point(163, 90);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(158, 23);
            this.txtDescripcion.TabIndex = 46;
            // 
            // btnEliminar
            // 
            this.btnEliminar.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.btnEliminar.FlatAppearance.BorderSize = 2;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Rockwell", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminar.Location = new System.Drawing.Point(377, 119);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(124, 53);
            this.btnEliminar.TabIndex = 55;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // dgvCategoria
            // 
            this.dgvCategoria.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Rockwell", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCategoria.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCategoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Rockwell", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCategoria.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCategoria.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCategoria.Location = new System.Drawing.Point(0, 0);
            this.dgvCategoria.Name = "dgvCategoria";
            this.dgvCategoria.Size = new System.Drawing.Size(528, 251);
            this.dgvCategoria.TabIndex = 0;
            this.dgvCategoria.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCategoria_CellClick);
            this.dgvCategoria.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvCategoria_CellMouseClick);
            this.dgvCategoria.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dgvCategoria_KeyUp);
            // 
            // pnlGrillaCategoria
            // 
            this.pnlGrillaCategoria.Controls.Add(this.dgvCategoria);
            this.pnlGrillaCategoria.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlGrillaCategoria.Location = new System.Drawing.Point(0, 199);
            this.pnlGrillaCategoria.Name = "pnlGrillaCategoria";
            this.pnlGrillaCategoria.Size = new System.Drawing.Size(528, 251);
            this.pnlGrillaCategoria.TabIndex = 2;
            // 
            // btnAgregarProductos
            // 
            this.btnAgregarProductos.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.btnAgregarProductos.FlatAppearance.BorderSize = 2;
            this.btnAgregarProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarProductos.Font = new System.Drawing.Font("Rockwell", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarProductos.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAgregarProductos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarProductos.Location = new System.Drawing.Point(377, 3);
            this.btnAgregarProductos.Name = "btnAgregarProductos";
            this.btnAgregarProductos.Size = new System.Drawing.Size(124, 53);
            this.btnAgregarProductos.TabIndex = 56;
            this.btnAgregarProductos.Text = "Agregar Productos";
            this.btnAgregarProductos.UseVisualStyleBackColor = true;
            this.btnAgregarProductos.Click += new System.EventHandler(this.btnAgregarProductos_Click);
            // 
            // frmCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 450);
            this.Controls.Add(this.pnlGrillaCategoria);
            this.Controls.Add(this.pnlAgregarItems);
            this.Name = "frmCategoria";
            this.Text = "Categoria";
            this.Load += new System.EventHandler(this.frmCategoria_Load);
            this.pnlAgregarItems.ResumeLayout(false);
            this.pnlAgregarItems.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategoria)).EndInit();
            this.pnlGrillaCategoria.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlAgregarItems;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.DataGridView dgvCategoria;
        private System.Windows.Forms.Panel pnlGrillaCategoria;
        private System.Windows.Forms.Button btnAgregarProductos;
    }
}