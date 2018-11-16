namespace Formularios
{
    partial class ABMLugarDePago
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
            this.btCancelar = new System.Windows.Forms.Button();
            this.btGuardar = new System.Windows.Forms.Button();
            this.txtRazonSocial = new System.Windows.Forms.TextBox();
            this.txtCodigoPostal = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.lbRazonSocial = new System.Windows.Forms.Label();
            this.lbCodPostal = new System.Windows.Forms.Label();
            this.lbDireccion = new System.Windows.Forms.Label();
            this.txtCiudad = new System.Windows.Forms.TextBox();
            this.lbCiudad = new System.Windows.Forms.Label();
            this.dgvLugares = new System.Windows.Forms.DataGridView();
            this.btEliminar = new System.Windows.Forms.Button();
            this.btModificar = new System.Windows.Forms.Button();
            this.btAgregarNuevo = new System.Windows.Forms.Button();
            this.lbTituloMenu = new System.Windows.Forms.Label();
            this.cbSucursal = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLugares)).BeginInit();
            this.SuspendLayout();
            // 
            // btCancelar
            // 
            this.btCancelar.Location = new System.Drawing.Point(701, 256);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(75, 23);
            this.btCancelar.TabIndex = 24;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // btGuardar
            // 
            this.btGuardar.Location = new System.Drawing.Point(620, 256);
            this.btGuardar.Name = "btGuardar";
            this.btGuardar.Size = new System.Drawing.Size(75, 23);
            this.btGuardar.TabIndex = 23;
            this.btGuardar.Text = "Guardar";
            this.btGuardar.UseVisualStyleBackColor = true;
            this.btGuardar.Click += new System.EventHandler(this.btGuardar_Click);
            // 
            // txtRazonSocial
            // 
            this.txtRazonSocial.Location = new System.Drawing.Point(671, 188);
            this.txtRazonSocial.MaxLength = 40;
            this.txtRazonSocial.Name = "txtRazonSocial";
            this.txtRazonSocial.Size = new System.Drawing.Size(117, 20);
            this.txtRazonSocial.TabIndex = 22;
            this.txtRazonSocial.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRazonSocial_KeyPress);
            // 
            // txtCodigoPostal
            // 
            this.txtCodigoPostal.Location = new System.Drawing.Point(671, 152);
            this.txtCodigoPostal.MaxLength = 8;
            this.txtCodigoPostal.Name = "txtCodigoPostal";
            this.txtCodigoPostal.Size = new System.Drawing.Size(117, 20);
            this.txtCodigoPostal.TabIndex = 21;
            this.txtCodigoPostal.TextChanged += new System.EventHandler(this.txtCodigoPostal_TextChanged);
            this.txtCodigoPostal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_CP_KeyPress);
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(671, 115);
            this.txtDireccion.MaxLength = 40;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(117, 20);
            this.txtDireccion.TabIndex = 20;
            // 
            // lbRazonSocial
            // 
            this.lbRazonSocial.AutoSize = true;
            this.lbRazonSocial.Location = new System.Drawing.Point(593, 191);
            this.lbRazonSocial.Name = "lbRazonSocial";
            this.lbRazonSocial.Size = new System.Drawing.Size(67, 13);
            this.lbRazonSocial.TabIndex = 19;
            this.lbRazonSocial.Text = "RazonSocial";
            // 
            // lbCodPostal
            // 
            this.lbCodPostal.AutoSize = true;
            this.lbCodPostal.Location = new System.Drawing.Point(593, 152);
            this.lbCodPostal.Name = "lbCodPostal";
            this.lbCodPostal.Size = new System.Drawing.Size(72, 13);
            this.lbCodPostal.TabIndex = 18;
            this.lbCodPostal.Text = "Codigo Postal";
            // 
            // lbDireccion
            // 
            this.lbDireccion.AutoSize = true;
            this.lbDireccion.Location = new System.Drawing.Point(593, 115);
            this.lbDireccion.Name = "lbDireccion";
            this.lbDireccion.Size = new System.Drawing.Size(52, 13);
            this.lbDireccion.TabIndex = 17;
            this.lbDireccion.Text = "Dirección";
            // 
            // txtCiudad
            // 
            this.txtCiudad.Location = new System.Drawing.Point(671, 75);
            this.txtCiudad.MaxLength = 40;
            this.txtCiudad.Name = "txtCiudad";
            this.txtCiudad.Size = new System.Drawing.Size(117, 20);
            this.txtCiudad.TabIndex = 16;
            this.txtCiudad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCiudad_KeyPress);
            // 
            // lbCiudad
            // 
            this.lbCiudad.AutoSize = true;
            this.lbCiudad.Location = new System.Drawing.Point(593, 82);
            this.lbCiudad.Name = "lbCiudad";
            this.lbCiudad.Size = new System.Drawing.Size(40, 13);
            this.lbCiudad.TabIndex = 15;
            this.lbCiudad.Text = "Ciudad";
            // 
            // dgvLugares
            // 
            this.dgvLugares.AllowUserToAddRows = false;
            this.dgvLugares.AllowUserToDeleteRows = false;
            this.dgvLugares.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLugares.Location = new System.Drawing.Point(139, 65);
            this.dgvLugares.Name = "dgvLugares";
            this.dgvLugares.ReadOnly = true;
            this.dgvLugares.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLugares.Size = new System.Drawing.Size(448, 268);
            this.dgvLugares.TabIndex = 13;
            // 
            // btEliminar
            // 
            this.btEliminar.Location = new System.Drawing.Point(21, 159);
            this.btEliminar.Name = "btEliminar";
            this.btEliminar.Size = new System.Drawing.Size(112, 36);
            this.btEliminar.TabIndex = 27;
            this.btEliminar.Text = "ELIMINAR";
            this.btEliminar.UseVisualStyleBackColor = true;
            this.btEliminar.Click += new System.EventHandler(this.btEliminar_Click);
            // 
            // btModificar
            // 
            this.btModificar.Location = new System.Drawing.Point(21, 117);
            this.btModificar.Name = "btModificar";
            this.btModificar.Size = new System.Drawing.Size(112, 36);
            this.btModificar.TabIndex = 26;
            this.btModificar.Text = "MODIFICAR";
            this.btModificar.UseVisualStyleBackColor = true;
            this.btModificar.Click += new System.EventHandler(this.btModificar_Click);
            // 
            // btAgregarNuevo
            // 
            this.btAgregarNuevo.Location = new System.Drawing.Point(21, 75);
            this.btAgregarNuevo.Name = "btAgregarNuevo";
            this.btAgregarNuevo.Size = new System.Drawing.Size(112, 36);
            this.btAgregarNuevo.TabIndex = 25;
            this.btAgregarNuevo.Text = "NUEVO";
            this.btAgregarNuevo.UseVisualStyleBackColor = true;
            this.btAgregarNuevo.Click += new System.EventHandler(this.btAgregarNuevo_Click);
            // 
            // lbTituloMenu
            // 
            this.lbTituloMenu.AutoSize = true;
            this.lbTituloMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTituloMenu.Location = new System.Drawing.Point(44, 22);
            this.lbTituloMenu.Name = "lbTituloMenu";
            this.lbTituloMenu.Size = new System.Drawing.Size(147, 24);
            this.lbTituloMenu.TabIndex = 29;
            this.lbTituloMenu.Text = "Lugar de Pago";
            // 
            // cbSucursal
            // 
            this.cbSucursal.AutoSize = true;
            this.cbSucursal.Location = new System.Drawing.Point(649, 219);
            this.cbSucursal.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbSucursal.Name = "cbSucursal";
            this.cbSucursal.Size = new System.Drawing.Size(80, 17);
            this.cbSucursal.TabIndex = 30;
            this.cbSucursal.Text = "Es sucursal";
            this.cbSucursal.UseVisualStyleBackColor = true;
            // 
            // ABMLugarDePago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 342);
            this.Controls.Add(this.cbSucursal);
            this.Controls.Add(this.lbTituloMenu);
            this.Controls.Add(this.btEliminar);
            this.Controls.Add(this.btModificar);
            this.Controls.Add(this.btAgregarNuevo);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btGuardar);
            this.Controls.Add(this.txtRazonSocial);
            this.Controls.Add(this.txtCodigoPostal);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.lbRazonSocial);
            this.Controls.Add(this.lbCodPostal);
            this.Controls.Add(this.lbDireccion);
            this.Controls.Add(this.txtCiudad);
            this.Controls.Add(this.lbCiudad);
            this.Controls.Add(this.dgvLugares);
            this.Name = "ABMLugarDePago";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ABMLugarDePago";
            this.Load += new System.EventHandler(this.ABMLugarDePago_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLugares)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.Button btGuardar;
        private System.Windows.Forms.TextBox txtRazonSocial;
        private System.Windows.Forms.TextBox txtCodigoPostal;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label lbRazonSocial;
        private System.Windows.Forms.Label lbCodPostal;
        private System.Windows.Forms.Label lbDireccion;
        private System.Windows.Forms.TextBox txtCiudad;
        private System.Windows.Forms.Label lbCiudad;
        private System.Windows.Forms.DataGridView dgvLugares;
        private System.Windows.Forms.Button btEliminar;
        private System.Windows.Forms.Button btModificar;
        private System.Windows.Forms.Button btAgregarNuevo;
        private System.Windows.Forms.Label lbTituloMenu;
        private System.Windows.Forms.CheckBox cbSucursal;
    }
}