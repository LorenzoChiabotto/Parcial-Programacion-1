namespace Formularios
{
    partial class ABMSucursal
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
            this.dgvSucursal = new System.Windows.Forms.DataGridView();
            this.btAgregarNuevo = new System.Windows.Forms.Button();
            this.lbCiudad = new System.Windows.Forms.Label();
            this.txtCiudad = new System.Windows.Forms.TextBox();
            this.lbDireccion = new System.Windows.Forms.Label();
            this.lbCodPostal = new System.Windows.Forms.Label();
            this.lbTasaDeInteres = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtCodigoPostal = new System.Windows.Forms.TextBox();
            this.txtLocalidad = new System.Windows.Forms.TextBox();
            this.btGuardar = new System.Windows.Forms.Button();
            this.btCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSucursal)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSucursal
            // 
            this.dgvSucursal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSucursal.Location = new System.Drawing.Point(13, 12);
            this.dgvSucursal.Name = "dgvSucursal";
            this.dgvSucursal.Size = new System.Drawing.Size(421, 297);
            this.dgvSucursal.TabIndex = 0;
            // 
            // btAgregarNuevo
            // 
            this.btAgregarNuevo.Location = new System.Drawing.Point(322, 315);
            this.btAgregarNuevo.Name = "btAgregarNuevo";
            this.btAgregarNuevo.Size = new System.Drawing.Size(112, 36);
            this.btAgregarNuevo.TabIndex = 1;
            this.btAgregarNuevo.Text = "Agregar Nuevo";
            this.btAgregarNuevo.UseVisualStyleBackColor = true;
            this.btAgregarNuevo.Click += new System.EventHandler(this.btAgregarNuevo_Click);
            // 
            // lbCiudad
            // 
            this.lbCiudad.AutoSize = true;
            this.lbCiudad.Location = new System.Drawing.Point(543, 31);
            this.lbCiudad.Name = "lbCiudad";
            this.lbCiudad.Size = new System.Drawing.Size(40, 13);
            this.lbCiudad.TabIndex = 3;
            this.lbCiudad.Text = "Ciudad";
            // 
            // txtCiudad
            // 
            this.txtCiudad.Location = new System.Drawing.Point(643, 31);
            this.txtCiudad.Name = "txtCiudad";
            this.txtCiudad.Size = new System.Drawing.Size(117, 20);
            this.txtCiudad.TabIndex = 4;
            // 
            // lbDireccion
            // 
            this.lbDireccion.AutoSize = true;
            this.lbDireccion.Location = new System.Drawing.Point(543, 71);
            this.lbDireccion.Name = "lbDireccion";
            this.lbDireccion.Size = new System.Drawing.Size(52, 13);
            this.lbDireccion.TabIndex = 5;
            this.lbDireccion.Text = "Dirección";
            // 
            // lbCodPostal
            // 
            this.lbCodPostal.AutoSize = true;
            this.lbCodPostal.Location = new System.Drawing.Point(543, 111);
            this.lbCodPostal.Name = "lbCodPostal";
            this.lbCodPostal.Size = new System.Drawing.Size(72, 13);
            this.lbCodPostal.TabIndex = 6;
            this.lbCodPostal.Text = "Codigo Postal";
            // 
            // lbTasaDeInteres
            // 
            this.lbTasaDeInteres.AutoSize = true;
            this.lbTasaDeInteres.Location = new System.Drawing.Point(543, 147);
            this.lbTasaDeInteres.Name = "lbTasaDeInteres";
            this.lbTasaDeInteres.Size = new System.Drawing.Size(81, 13);
            this.lbTasaDeInteres.TabIndex = 7;
            this.lbTasaDeInteres.Text = "Tasa de Interés";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(643, 71);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(117, 20);
            this.txtDireccion.TabIndex = 8;
            // 
            // txtCodigoPostal
            // 
            this.txtCodigoPostal.Location = new System.Drawing.Point(643, 111);
            this.txtCodigoPostal.Name = "txtCodigoPostal";
            this.txtCodigoPostal.Size = new System.Drawing.Size(117, 20);
            this.txtCodigoPostal.TabIndex = 9;
            // 
            // txtLocalidad
            // 
            this.txtLocalidad.Location = new System.Drawing.Point(643, 147);
            this.txtLocalidad.Name = "txtLocalidad";
            this.txtLocalidad.Size = new System.Drawing.Size(117, 20);
            this.txtLocalidad.TabIndex = 10;
            // 
            // btGuardar
            // 
            this.btGuardar.Location = new System.Drawing.Point(614, 210);
            this.btGuardar.Name = "btGuardar";
            this.btGuardar.Size = new System.Drawing.Size(75, 23);
            this.btGuardar.TabIndex = 11;
            this.btGuardar.Text = "Guardar";
            this.btGuardar.UseVisualStyleBackColor = true;
            this.btGuardar.Click += new System.EventHandler(this.btGuardar_Click);
            // 
            // btCancelar
            // 
            this.btCancelar.Location = new System.Drawing.Point(695, 210);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(75, 23);
            this.btCancelar.TabIndex = 12;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // ABMSucursal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btGuardar);
            this.Controls.Add(this.txtLocalidad);
            this.Controls.Add(this.txtCodigoPostal);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.lbTasaDeInteres);
            this.Controls.Add(this.lbCodPostal);
            this.Controls.Add(this.lbDireccion);
            this.Controls.Add(this.txtCiudad);
            this.Controls.Add(this.lbCiudad);
            this.Controls.Add(this.btAgregarNuevo);
            this.Controls.Add(this.dgvSucursal);
            this.Name = "ABMSucursal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ABMSucursal";
            this.Load += new System.EventHandler(this.ABMSucursal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSucursal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSucursal;
        private System.Windows.Forms.Button btAgregarNuevo;
        private System.Windows.Forms.Label lbCiudad;
        private System.Windows.Forms.TextBox txtCiudad;
        private System.Windows.Forms.Label lbDireccion;
        private System.Windows.Forms.Label lbCodPostal;
        private System.Windows.Forms.Label lbTasaDeInteres;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtCodigoPostal;
        private System.Windows.Forms.TextBox txtLocalidad;
        private System.Windows.Forms.Button btGuardar;
        private System.Windows.Forms.Button btCancelar;
    }
}