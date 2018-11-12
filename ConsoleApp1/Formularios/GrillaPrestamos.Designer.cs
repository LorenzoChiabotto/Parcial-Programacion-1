namespace Formularios
{
    partial class GrillaPrestamos
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
            this.dgvPrestamos = new System.Windows.Forms.DataGridView();
            this.lbFiltrar = new System.Windows.Forms.Label();
            this.cbTipoDocumento = new System.Windows.Forms.ComboBox();
            this.txbDocumento = new System.Windows.Forms.TextBox();
            this.btNuevo = new System.Windows.Forms.Button();
            this.lbTituloMenu = new System.Windows.Forms.Label();
            this.btDetalle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrestamos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPrestamos
            // 
            this.dgvPrestamos.AllowUserToAddRows = false;
            this.dgvPrestamos.AllowUserToDeleteRows = false;
            this.dgvPrestamos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrestamos.Location = new System.Drawing.Point(45, 102);
            this.dgvPrestamos.Margin = new System.Windows.Forms.Padding(4);
            this.dgvPrestamos.Name = "dgvPrestamos";
            this.dgvPrestamos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPrestamos.Size = new System.Drawing.Size(931, 337);
            this.dgvPrestamos.TabIndex = 0;
            // 
            // lbFiltrar
            // 
            this.lbFiltrar.AutoSize = true;
            this.lbFiltrar.Location = new System.Drawing.Point(42, 75);
            this.lbFiltrar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbFiltrar.Name = "lbFiltrar";
            this.lbFiltrar.Size = new System.Drawing.Size(112, 17);
            this.lbFiltrar.TabIndex = 1;
            this.lbFiltrar.Text = "Tipo Documento";
            // 
            // cbTipoDocumento
            // 
            this.cbTipoDocumento.FormattingEnabled = true;
            this.cbTipoDocumento.Location = new System.Drawing.Point(162, 72);
            this.cbTipoDocumento.Margin = new System.Windows.Forms.Padding(4);
            this.cbTipoDocumento.Name = "cbTipoDocumento";
            this.cbTipoDocumento.Size = new System.Drawing.Size(160, 24);
            this.cbTipoDocumento.TabIndex = 2;
            // 
            // txbDocumento
            // 
            this.txbDocumento.Location = new System.Drawing.Point(339, 72);
            this.txbDocumento.Margin = new System.Windows.Forms.Padding(4);
            this.txbDocumento.Name = "txbDocumento";
            this.txbDocumento.Size = new System.Drawing.Size(160, 22);
            this.txbDocumento.TabIndex = 4;
            // 
            // btNuevo
            // 
            this.btNuevo.Location = new System.Drawing.Point(45, 447);
            this.btNuevo.Margin = new System.Windows.Forms.Padding(4);
            this.btNuevo.Name = "btNuevo";
            this.btNuevo.Size = new System.Drawing.Size(173, 33);
            this.btNuevo.TabIndex = 10;
            this.btNuevo.Text = "NUEVO";
            this.btNuevo.UseVisualStyleBackColor = true;
            this.btNuevo.Click += new System.EventHandler(this.btNuevo_Click);
            // 
            // lbTituloMenu
            // 
            this.lbTituloMenu.AutoSize = true;
            this.lbTituloMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTituloMenu.Location = new System.Drawing.Point(79, 11);
            this.lbTituloMenu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTituloMenu.Name = "lbTituloMenu";
            this.lbTituloMenu.Size = new System.Drawing.Size(137, 29);
            this.lbTituloMenu.TabIndex = 29;
            this.lbTituloMenu.Text = "Prestamos";
            // 
            // btDetalle
            // 
            this.btDetalle.Location = new System.Drawing.Point(729, 447);
            this.btDetalle.Margin = new System.Windows.Forms.Padding(4);
            this.btDetalle.Name = "btDetalle";
            this.btDetalle.Size = new System.Drawing.Size(247, 33);
            this.btDetalle.TabIndex = 30;
            this.btDetalle.Text = "VER DETALLE";
            this.btDetalle.UseVisualStyleBackColor = true;
            this.btDetalle.Click += new System.EventHandler(this.btDetalle_Click);
            // 
            // GrillaPrestamos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1007, 519);
            this.Controls.Add(this.btDetalle);
            this.Controls.Add(this.lbTituloMenu);
            this.Controls.Add(this.btNuevo);
            this.Controls.Add(this.txbDocumento);
            this.Controls.Add(this.cbTipoDocumento);
            this.Controls.Add(this.lbFiltrar);
            this.Controls.Add(this.dgvPrestamos);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "GrillaPrestamos";
            this.Text = "ListarPrestamos";
            this.Load += new System.EventHandler(this.GrillaPrestamos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrestamos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPrestamos;
        private System.Windows.Forms.Label lbFiltrar;
        private System.Windows.Forms.ComboBox cbTipoDocumento;
        private System.Windows.Forms.TextBox txbDocumento;
        private System.Windows.Forms.Button btNuevo;
        private System.Windows.Forms.Label lbTituloMenu;
        private System.Windows.Forms.Button btDetalle;
    }
}