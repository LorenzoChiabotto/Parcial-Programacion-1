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
            this.txtLocalidad = new System.Windows.Forms.TextBox();
            this.txtCodigoPostal = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.lbRazonSocial = new System.Windows.Forms.Label();
            this.lbCodPostal = new System.Windows.Forms.Label();
            this.lbDireccion = new System.Windows.Forms.Label();
            this.txtCiudad = new System.Windows.Forms.TextBox();
            this.lbCiudad = new System.Windows.Forms.Label();
            this.btAgregarNuevo = new System.Windows.Forms.Button();
            this.dgvComercio = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComercio)).BeginInit();
            this.SuspendLayout();
            // 
            // btCancelar
            // 
            this.btCancelar.Location = new System.Drawing.Point(704, 254);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(75, 23);
            this.btCancelar.TabIndex = 24;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = true;
            // 
            // btGuardar
            // 
            this.btGuardar.Location = new System.Drawing.Point(623, 254);
            this.btGuardar.Name = "btGuardar";
            this.btGuardar.Size = new System.Drawing.Size(75, 23);
            this.btGuardar.TabIndex = 23;
            this.btGuardar.Text = "Guardar";
            this.btGuardar.UseVisualStyleBackColor = true;
            // 
            // txtLocalidad
            // 
            this.txtLocalidad.Location = new System.Drawing.Point(652, 191);
            this.txtLocalidad.Name = "txtLocalidad";
            this.txtLocalidad.Size = new System.Drawing.Size(117, 20);
            this.txtLocalidad.TabIndex = 22;
            // 
            // txtCodigoPostal
            // 
            this.txtCodigoPostal.Location = new System.Drawing.Point(652, 155);
            this.txtCodigoPostal.Name = "txtCodigoPostal";
            this.txtCodigoPostal.Size = new System.Drawing.Size(117, 20);
            this.txtCodigoPostal.TabIndex = 21;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(652, 115);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(117, 20);
            this.txtDireccion.TabIndex = 20;
            // 
            // lbRazonSocial
            // 
            this.lbRazonSocial.AutoSize = true;
            this.lbRazonSocial.Location = new System.Drawing.Point(552, 191);
            this.lbRazonSocial.Name = "lbRazonSocial";
            this.lbRazonSocial.Size = new System.Drawing.Size(70, 13);
            this.lbRazonSocial.TabIndex = 19;
            this.lbRazonSocial.Text = "Razon Social";
            // 
            // lbCodPostal
            // 
            this.lbCodPostal.AutoSize = true;
            this.lbCodPostal.Location = new System.Drawing.Point(552, 155);
            this.lbCodPostal.Name = "lbCodPostal";
            this.lbCodPostal.Size = new System.Drawing.Size(72, 13);
            this.lbCodPostal.TabIndex = 18;
            this.lbCodPostal.Text = "Codigo Postal";
            // 
            // lbDireccion
            // 
            this.lbDireccion.AutoSize = true;
            this.lbDireccion.Location = new System.Drawing.Point(552, 115);
            this.lbDireccion.Name = "lbDireccion";
            this.lbDireccion.Size = new System.Drawing.Size(52, 13);
            this.lbDireccion.TabIndex = 17;
            this.lbDireccion.Text = "Dirección";
            // 
            // txtCiudad
            // 
            this.txtCiudad.Location = new System.Drawing.Point(652, 75);
            this.txtCiudad.Name = "txtCiudad";
            this.txtCiudad.Size = new System.Drawing.Size(117, 20);
            this.txtCiudad.TabIndex = 16;
            // 
            // lbCiudad
            // 
            this.lbCiudad.AutoSize = true;
            this.lbCiudad.Location = new System.Drawing.Point(552, 75);
            this.lbCiudad.Name = "lbCiudad";
            this.lbCiudad.Size = new System.Drawing.Size(40, 13);
            this.lbCiudad.TabIndex = 15;
            this.lbCiudad.Text = "Ciudad";
            // 
            // btAgregarNuevo
            // 
            this.btAgregarNuevo.Location = new System.Drawing.Point(331, 359);
            this.btAgregarNuevo.Name = "btAgregarNuevo";
            this.btAgregarNuevo.Size = new System.Drawing.Size(112, 36);
            this.btAgregarNuevo.TabIndex = 14;
            this.btAgregarNuevo.Text = "Agregar Nuevo";
            this.btAgregarNuevo.UseVisualStyleBackColor = true;
            this.btAgregarNuevo.Click += new System.EventHandler(this.btAgregarNuevo_Click);
            // 
            // dgvComercio
            // 
            this.dgvComercio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvComercio.Location = new System.Drawing.Point(22, 56);
            this.dgvComercio.Name = "dgvComercio";
            this.dgvComercio.Size = new System.Drawing.Size(421, 297);
            this.dgvComercio.TabIndex = 13;
            this.dgvComercio.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ABMComercioAdherido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btGuardar);
            this.Controls.Add(this.txtLocalidad);
            this.Controls.Add(this.txtCodigoPostal);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.lbRazonSocial);
            this.Controls.Add(this.lbCodPostal);
            this.Controls.Add(this.lbDireccion);
            this.Controls.Add(this.txtCiudad);
            this.Controls.Add(this.lbCiudad);
            this.Controls.Add(this.btAgregarNuevo);
            this.Controls.Add(this.dgvComercio);
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
        private System.Windows.Forms.TextBox txtLocalidad;
        private System.Windows.Forms.TextBox txtCodigoPostal;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label lbRazonSocial;
        private System.Windows.Forms.Label lbCodPostal;
        private System.Windows.Forms.Label lbDireccion;
        private System.Windows.Forms.TextBox txtCiudad;
        private System.Windows.Forms.Label lbCiudad;
        private System.Windows.Forms.Button btAgregarNuevo;
        private System.Windows.Forms.DataGridView dgvComercio;
    }
}