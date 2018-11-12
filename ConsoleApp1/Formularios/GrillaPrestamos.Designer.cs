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
            this.lbDocumento = new System.Windows.Forms.Label();
            this.txbDocumento = new System.Windows.Forms.TextBox();
            this.btBuscar = new System.Windows.Forms.Button();
            this.btNuevo = new System.Windows.Forms.Button();
            this.lbTituloMenu = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrestamos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPrestamos
            // 
            this.dgvPrestamos.AllowUserToAddRows = false;
            this.dgvPrestamos.AllowUserToDeleteRows = false;
            this.dgvPrestamos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrestamos.Location = new System.Drawing.Point(339, 75);
            this.dgvPrestamos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvPrestamos.Name = "dgvPrestamos";
            this.dgvPrestamos.Size = new System.Drawing.Size(732, 385);
            this.dgvPrestamos.TabIndex = 0;
            this.dgvPrestamos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // lbFiltrar
            // 
            this.lbFiltrar.AutoSize = true;
            this.lbFiltrar.Location = new System.Drawing.Point(16, 75);
            this.lbFiltrar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbFiltrar.Name = "lbFiltrar";
            this.lbFiltrar.Size = new System.Drawing.Size(112, 17);
            this.lbFiltrar.TabIndex = 1;
            this.lbFiltrar.Text = "Tipo Documento";
            // 
            // cbTipoDocumento
            // 
            this.cbTipoDocumento.FormattingEnabled = true;
            this.cbTipoDocumento.Location = new System.Drawing.Point(169, 75);
            this.cbTipoDocumento.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbTipoDocumento.Name = "cbTipoDocumento";
            this.cbTipoDocumento.Size = new System.Drawing.Size(160, 24);
            this.cbTipoDocumento.TabIndex = 2;
            // 
            // lbDocumento
            // 
            this.lbDocumento.AutoSize = true;
            this.lbDocumento.Location = new System.Drawing.Point(20, 124);
            this.lbDocumento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbDocumento.Name = "lbDocumento";
            this.lbDocumento.Size = new System.Drawing.Size(84, 17);
            this.lbDocumento.TabIndex = 3;
            this.lbDocumento.Text = "Documento:";
            // 
            // txbDocumento
            // 
            this.txbDocumento.Location = new System.Drawing.Point(169, 124);
            this.txbDocumento.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txbDocumento.Name = "txbDocumento";
            this.txbDocumento.Size = new System.Drawing.Size(160, 22);
            this.txbDocumento.TabIndex = 4;
            // 
            // btBuscar
            // 
            this.btBuscar.Location = new System.Drawing.Point(231, 176);
            this.btBuscar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btBuscar.Name = "btBuscar";
            this.btBuscar.Size = new System.Drawing.Size(100, 28);
            this.btBuscar.TabIndex = 5;
            this.btBuscar.Text = "Buscar";
            this.btBuscar.UseVisualStyleBackColor = true;
            // 
            // btNuevo
            // 
            this.btNuevo.Location = new System.Drawing.Point(24, 212);
            this.btNuevo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btNuevo.Name = "btNuevo";
            this.btNuevo.Size = new System.Drawing.Size(100, 46);
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
            // GrillaPrestamos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1116, 612);
            this.Controls.Add(this.lbTituloMenu);
            this.Controls.Add(this.btNuevo);
            this.Controls.Add(this.btBuscar);
            this.Controls.Add(this.txbDocumento);
            this.Controls.Add(this.lbDocumento);
            this.Controls.Add(this.cbTipoDocumento);
            this.Controls.Add(this.lbFiltrar);
            this.Controls.Add(this.dgvPrestamos);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
        private System.Windows.Forms.Label lbDocumento;
        private System.Windows.Forms.TextBox txbDocumento;
        private System.Windows.Forms.Button btBuscar;
        private System.Windows.Forms.Button btNuevo;
        private System.Windows.Forms.Label lbTituloMenu;
    }
}