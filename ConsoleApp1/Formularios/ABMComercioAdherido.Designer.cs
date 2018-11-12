namespace Formularios
{
    partial class ABMComercioAdherido
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
            this.btAgregarNuevo = new System.Windows.Forms.Button();
            this.dgvComercio = new System.Windows.Forms.DataGridView();
            this.lbTituloMenu = new System.Windows.Forms.Label();
            this.btEliminar = new System.Windows.Forms.Button();
            this.btModificar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComercio)).BeginInit();
            this.SuspendLayout();
            // 
            // btCancelar
            // 
            this.btCancelar.Location = new System.Drawing.Point(905, 289);
            this.btCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(100, 28);
            this.btCancelar.TabIndex = 24;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // btGuardar
            // 
            this.btGuardar.Location = new System.Drawing.Point(797, 289);
            this.btGuardar.Margin = new System.Windows.Forms.Padding(4);
            this.btGuardar.Name = "btGuardar";
            this.btGuardar.Size = new System.Drawing.Size(100, 28);
            this.btGuardar.TabIndex = 23;
            this.btGuardar.Text = "Guardar";
            this.btGuardar.UseVisualStyleBackColor = true;
            this.btGuardar.Click += new System.EventHandler(this.btGuardar_Click);
            // 
            // txtRazonSocial
            // 
            this.txtRazonSocial.Location = new System.Drawing.Point(869, 235);
            this.txtRazonSocial.Margin = new System.Windows.Forms.Padding(4);
            this.txtRazonSocial.Name = "txtRazonSocial";
            this.txtRazonSocial.Size = new System.Drawing.Size(155, 22);
            this.txtRazonSocial.TabIndex = 22;
            // 
            // txtCodigoPostal
            // 
            this.txtCodigoPostal.Location = new System.Drawing.Point(869, 191);
            this.txtCodigoPostal.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodigoPostal.Name = "txtCodigoPostal";
            this.txtCodigoPostal.Size = new System.Drawing.Size(155, 22);
            this.txtCodigoPostal.TabIndex = 21;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(869, 142);
            this.txtDireccion.Margin = new System.Windows.Forms.Padding(4);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(155, 22);
            this.txtDireccion.TabIndex = 20;
            // 
            // lbRazonSocial
            // 
            this.lbRazonSocial.AutoSize = true;
            this.lbRazonSocial.Location = new System.Drawing.Point(736, 235);
            this.lbRazonSocial.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbRazonSocial.Name = "lbRazonSocial";
            this.lbRazonSocial.Size = new System.Drawing.Size(91, 17);
            this.lbRazonSocial.TabIndex = 19;
            this.lbRazonSocial.Text = "Razon Social";
            // 
            // lbCodPostal
            // 
            this.lbCodPostal.AutoSize = true;
            this.lbCodPostal.Location = new System.Drawing.Point(736, 191);
            this.lbCodPostal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCodPostal.Name = "lbCodPostal";
            this.lbCodPostal.Size = new System.Drawing.Size(95, 17);
            this.lbCodPostal.TabIndex = 18;
            this.lbCodPostal.Text = "Codigo Postal";
            // 
            // lbDireccion
            // 
            this.lbDireccion.AutoSize = true;
            this.lbDireccion.Location = new System.Drawing.Point(736, 142);
            this.lbDireccion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbDireccion.Name = "lbDireccion";
            this.lbDireccion.Size = new System.Drawing.Size(67, 17);
            this.lbDireccion.TabIndex = 17;
            this.lbDireccion.Text = "Dirección";
            // 
            // txtCiudad
            // 
            this.txtCiudad.Location = new System.Drawing.Point(869, 92);
            this.txtCiudad.Margin = new System.Windows.Forms.Padding(4);
            this.txtCiudad.Name = "txtCiudad";
            this.txtCiudad.Size = new System.Drawing.Size(155, 22);
            this.txtCiudad.TabIndex = 16;
            // 
            // lbCiudad
            // 
            this.lbCiudad.AutoSize = true;
            this.lbCiudad.Location = new System.Drawing.Point(736, 92);
            this.lbCiudad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCiudad.Name = "lbCiudad";
            this.lbCiudad.Size = new System.Drawing.Size(52, 17);
            this.lbCiudad.TabIndex = 15;
            this.lbCiudad.Text = "Ciudad";
            // 
            // btAgregarNuevo
            // 
            this.btAgregarNuevo.Location = new System.Drawing.Point(9, 81);
            this.btAgregarNuevo.Margin = new System.Windows.Forms.Padding(4);
            this.btAgregarNuevo.Name = "btAgregarNuevo";
            this.btAgregarNuevo.Size = new System.Drawing.Size(149, 44);
            this.btAgregarNuevo.TabIndex = 14;
            this.btAgregarNuevo.Text = "NUEVO";
            this.btAgregarNuevo.UseVisualStyleBackColor = true;
            this.btAgregarNuevo.Click += new System.EventHandler(this.btAgregarNuevo_Click);
            // 
            // dgvComercio
            // 
            this.dgvComercio.AllowUserToAddRows = false;
            this.dgvComercio.AllowUserToDeleteRows = false;
            this.dgvComercio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvComercio.Location = new System.Drawing.Point(167, 65);
            this.dgvComercio.Margin = new System.Windows.Forms.Padding(4);
            this.dgvComercio.Name = "dgvComercio";
            this.dgvComercio.ReadOnly = true;
            this.dgvComercio.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvComercio.Size = new System.Drawing.Size(561, 366);
            this.dgvComercio.TabIndex = 13;
            // 
            // lbTituloMenu
            // 
            this.lbTituloMenu.AutoSize = true;
            this.lbTituloMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTituloMenu.Location = new System.Drawing.Point(49, 11);
            this.lbTituloMenu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTituloMenu.Name = "lbTituloMenu";
            this.lbTituloMenu.Size = new System.Drawing.Size(265, 29);
            this.lbTituloMenu.TabIndex = 29;
            this.lbTituloMenu.Text = "Comercios Adheridos";
            // 
            // btEliminar
            // 
            this.btEliminar.Location = new System.Drawing.Point(9, 185);
            this.btEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.btEliminar.Name = "btEliminar";
            this.btEliminar.Size = new System.Drawing.Size(149, 44);
            this.btEliminar.TabIndex = 31;
            this.btEliminar.Text = "ELIMINAR";
            this.btEliminar.UseVisualStyleBackColor = true;
            this.btEliminar.Click += new System.EventHandler(this.btEliminar_Click);
            // 
            // btModificar
            // 
            this.btModificar.Location = new System.Drawing.Point(9, 133);
            this.btModificar.Margin = new System.Windows.Forms.Padding(4);
            this.btModificar.Name = "btModificar";
            this.btModificar.Size = new System.Drawing.Size(149, 44);
            this.btModificar.TabIndex = 30;
            this.btModificar.Text = "MODIFICAR";
            this.btModificar.UseVisualStyleBackColor = true;
            this.btModificar.Click += new System.EventHandler(this.btModificar_Click);
            // 
            // ABMComercioAdherido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 450);
            this.Controls.Add(this.btEliminar);
            this.Controls.Add(this.btModificar);
            this.Controls.Add(this.lbTituloMenu);
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
            this.Controls.Add(this.btAgregarNuevo);
            this.Controls.Add(this.dgvComercio);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ABMComercioAdherido";
            this.Text = "ABMComercioAdherido";
            this.Load += new System.EventHandler(this.ABMComercioAdherido_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvComercio)).EndInit();
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
        private System.Windows.Forms.Button btAgregarNuevo;
        private System.Windows.Forms.DataGridView dgvComercio;
        private System.Windows.Forms.Label lbTituloMenu;
        private System.Windows.Forms.Button btEliminar;
        private System.Windows.Forms.Button btModificar;
    }
}