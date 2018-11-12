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
            this.dgvPrestamos.Location = new System.Drawing.Point(34, 83);
            this.dgvPrestamos.Name = "dgvPrestamos";
            this.dgvPrestamos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPrestamos.Size = new System.Drawing.Size(698, 274);
            this.dgvPrestamos.TabIndex = 0;
            // 
            // lbFiltrar
            // 
            this.lbFiltrar.AutoSize = true;
            this.lbFiltrar.Location = new System.Drawing.Point(32, 61);
            this.lbFiltrar.Name = "lbFiltrar";
            this.lbFiltrar.Size = new System.Drawing.Size(86, 13);
            this.lbFiltrar.TabIndex = 1;
            this.lbFiltrar.Text = "Tipo Documento";
            // 
            // cbTipoDocumento
            // 
            this.cbTipoDocumento.FormattingEnabled = true;
            this.cbTipoDocumento.Location = new System.Drawing.Point(122, 58);
            this.cbTipoDocumento.Name = "cbTipoDocumento";
            this.cbTipoDocumento.Size = new System.Drawing.Size(121, 21);
            this.cbTipoDocumento.TabIndex = 2;
            // 
            // txbDocumento
            // 
            this.txbDocumento.Location = new System.Drawing.Point(254, 58);
            this.txbDocumento.Name = "txbDocumento";
            this.txbDocumento.Size = new System.Drawing.Size(121, 20);
            this.txbDocumento.TabIndex = 4;
            this.txbDocumento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Documento_KeyPress);
            // 
            // btNuevo
            // 
            this.btNuevo.Location = new System.Drawing.Point(34, 363);
            this.btNuevo.Name = "btNuevo";
            this.btNuevo.Size = new System.Drawing.Size(130, 27);
            this.btNuevo.TabIndex = 10;
            this.btNuevo.Text = "NUEVO";
            this.btNuevo.UseVisualStyleBackColor = true;
            this.btNuevo.Click += new System.EventHandler(this.btNuevo_Click);
            // 
            // lbTituloMenu
            // 
            this.lbTituloMenu.AutoSize = true;
            this.lbTituloMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTituloMenu.Location = new System.Drawing.Point(59, 9);
            this.lbTituloMenu.Name = "lbTituloMenu";
            this.lbTituloMenu.Size = new System.Drawing.Size(107, 24);
            this.lbTituloMenu.TabIndex = 29;
            this.lbTituloMenu.Text = "Prestamos";
            // 
            // btDetalle
            // 
            this.btDetalle.Location = new System.Drawing.Point(547, 363);
            this.btDetalle.Name = "btDetalle";
            this.btDetalle.Size = new System.Drawing.Size(185, 27);
            this.btDetalle.TabIndex = 30;
            this.btDetalle.Text = "VER DETALLE";
            this.btDetalle.UseVisualStyleBackColor = true;
            this.btDetalle.Click += new System.EventHandler(this.btDetalle_Click);
            // 
            // GrillaPrestamos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 422);
            this.Controls.Add(this.btDetalle);
            this.Controls.Add(this.lbTituloMenu);
            this.Controls.Add(this.btNuevo);
            this.Controls.Add(this.txbDocumento);
            this.Controls.Add(this.cbTipoDocumento);
            this.Controls.Add(this.lbFiltrar);
            this.Controls.Add(this.dgvPrestamos);
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