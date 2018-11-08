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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lbFiltrar = new System.Windows.Forms.Label();
            this.cbTipoDocumento = new System.Windows.Forms.ComboBox();
            this.lbDocumento = new System.Windows.Forms.Label();
            this.txbDocumento = new System.Windows.Forms.TextBox();
            this.btBuscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 123);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(776, 342);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // lbFiltrar
            // 
            this.lbFiltrar.AutoSize = true;
            this.lbFiltrar.Location = new System.Drawing.Point(12, 21);
            this.lbFiltrar.Name = "lbFiltrar";
            this.lbFiltrar.Size = new System.Drawing.Size(86, 13);
            this.lbFiltrar.TabIndex = 1;
            this.lbFiltrar.Text = "Tipo Documento";
            // 
            // cbTipoDocumento
            // 
            this.cbTipoDocumento.FormattingEnabled = true;
            this.cbTipoDocumento.Location = new System.Drawing.Point(127, 21);
            this.cbTipoDocumento.Name = "cbTipoDocumento";
            this.cbTipoDocumento.Size = new System.Drawing.Size(121, 21);
            this.cbTipoDocumento.TabIndex = 2;
            // 
            // lbDocumento
            // 
            this.lbDocumento.AutoSize = true;
            this.lbDocumento.Location = new System.Drawing.Point(15, 61);
            this.lbDocumento.Name = "lbDocumento";
            this.lbDocumento.Size = new System.Drawing.Size(65, 13);
            this.lbDocumento.TabIndex = 3;
            this.lbDocumento.Text = "Documento:";
            // 
            // txbDocumento
            // 
            this.txbDocumento.Location = new System.Drawing.Point(127, 61);
            this.txbDocumento.Name = "txbDocumento";
            this.txbDocumento.Size = new System.Drawing.Size(121, 20);
            this.txbDocumento.TabIndex = 4;
            // 
            // btBuscar
            // 
            this.btBuscar.Location = new System.Drawing.Point(173, 94);
            this.btBuscar.Name = "btBuscar";
            this.btBuscar.Size = new System.Drawing.Size(75, 23);
            this.btBuscar.TabIndex = 5;
            this.btBuscar.Text = "Buscar";
            this.btBuscar.UseVisualStyleBackColor = true;
            // 
            // GrillaPrestamos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btBuscar);
            this.Controls.Add(this.txbDocumento);
            this.Controls.Add(this.lbDocumento);
            this.Controls.Add(this.cbTipoDocumento);
            this.Controls.Add(this.lbFiltrar);
            this.Controls.Add(this.dataGridView1);
            this.Name = "GrillaPrestamos";
            this.Text = "ListarPrestamos";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lbFiltrar;
        private System.Windows.Forms.ComboBox cbTipoDocumento;
        private System.Windows.Forms.Label lbDocumento;
        private System.Windows.Forms.TextBox txbDocumento;
        private System.Windows.Forms.Button btBuscar;
    }
}