namespace Formularios
{
    partial class GrillaClientes
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
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.btNuevo = new System.Windows.Forms.Button();
            this.btModificar = new System.Windows.Forms.Button();
            this.btEliminar = new System.Windows.Forms.Button();
            this.lbTituloMenu = new System.Windows.Forms.Label();
            this.btNuevoPrestamo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvClientes
            // 
            this.dgvClientes.AllowUserToAddRows = false;
            this.dgvClientes.AllowUserToDeleteRows = false;
            this.dgvClientes.AllowUserToOrderColumns = true;
            this.dgvClientes.AllowUserToResizeRows = false;
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Location = new System.Drawing.Point(93, 67);
            this.dgvClientes.MultiSelect = false;
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.ReadOnly = true;
            this.dgvClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClientes.Size = new System.Drawing.Size(680, 294);
            this.dgvClientes.TabIndex = 0;
            // 
            // btNuevo
            // 
            this.btNuevo.Location = new System.Drawing.Point(10, 67);
            this.btNuevo.Name = "btNuevo";
            this.btNuevo.Size = new System.Drawing.Size(75, 37);
            this.btNuevo.TabIndex = 9;
            this.btNuevo.Text = "NUEVO";
            this.btNuevo.UseVisualStyleBackColor = true;
            this.btNuevo.Click += new System.EventHandler(this.btNuevo_Click);
            // 
            // btModificar
            // 
            this.btModificar.Location = new System.Drawing.Point(10, 119);
            this.btModificar.Name = "btModificar";
            this.btModificar.Size = new System.Drawing.Size(75, 35);
            this.btModificar.TabIndex = 10;
            this.btModificar.Text = "MODIFICAR";
            this.btModificar.UseVisualStyleBackColor = true;
            this.btModificar.Click += new System.EventHandler(this.btModificar_Click);
            // 
            // btEliminar
            // 
            this.btEliminar.Location = new System.Drawing.Point(10, 171);
            this.btEliminar.Name = "btEliminar";
            this.btEliminar.Size = new System.Drawing.Size(75, 35);
            this.btEliminar.TabIndex = 11;
            this.btEliminar.Text = "ELIMINAR";
            this.btEliminar.UseVisualStyleBackColor = true;
            this.btEliminar.Click += new System.EventHandler(this.btEliminar_Click);
            // 
            // lbTituloMenu
            // 
            this.lbTituloMenu.AutoSize = true;
            this.lbTituloMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTituloMenu.Location = new System.Drawing.Point(10, 7);
            this.lbTituloMenu.Name = "lbTituloMenu";
            this.lbTituloMenu.Size = new System.Drawing.Size(85, 24);
            this.lbTituloMenu.TabIndex = 29;
            this.lbTituloMenu.Text = "Clientes";
            // 
            // btNuevoPrestamo
            // 
            this.btNuevoPrestamo.Location = new System.Drawing.Point(10, 326);
            this.btNuevoPrestamo.Name = "btNuevoPrestamo";
            this.btNuevoPrestamo.Size = new System.Drawing.Size(75, 35);
            this.btNuevoPrestamo.TabIndex = 30;
            this.btNuevoPrestamo.Text = "NUEVO PRESTAMO";
            this.btNuevoPrestamo.UseVisualStyleBackColor = true;
            this.btNuevoPrestamo.Click += new System.EventHandler(this.btNuevoPrestamo_Click);
            // 
            // GrillaClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 400);
            this.Controls.Add(this.btNuevoPrestamo);
            this.Controls.Add(this.lbTituloMenu);
            this.Controls.Add(this.btEliminar);
            this.Controls.Add(this.btModificar);
            this.Controls.Add(this.btNuevo);
            this.Controls.Add(this.dgvClientes);
            this.Name = "GrillaClientes";
            this.Text = "GrillaClientes";
            this.Load += new System.EventHandler(this.GrillaClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.Button btNuevo;
        private System.Windows.Forms.Button btModificar;
        private System.Windows.Forms.Button btEliminar;
        private System.Windows.Forms.Label lbTituloMenu;
        private System.Windows.Forms.Button btNuevoPrestamo;
    }
}