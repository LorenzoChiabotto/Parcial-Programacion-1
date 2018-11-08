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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lbFiltros = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.mskFechDesde = new System.Windows.Forms.MaskedTextBox();
            this.lbFechaDesde = new System.Windows.Forms.Label();
            this.lbFechaHasta = new System.Windows.Forms.Label();
            this.mskFechaDesde = new System.Windows.Forms.MaskedTextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btBuscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 113);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(763, 294);
            this.dataGridView1.TabIndex = 0;
            // 
            // lbFiltros
            // 
            this.lbFiltros.AutoSize = true;
            this.lbFiltros.Location = new System.Drawing.Point(12, 9);
            this.lbFiltros.Name = "lbFiltros";
            this.lbFiltros.Size = new System.Drawing.Size(61, 13);
            this.lbFiltros.TabIndex = 1;
            this.lbFiltros.Text = "Buscar por:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(90, 6);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(127, 21);
            this.comboBox1.TabIndex = 2;
            // 
            // mskFechDesde
            // 
            this.mskFechDesde.Location = new System.Drawing.Point(95, 43);
            this.mskFechDesde.Mask = "00/00/0000";
            this.mskFechDesde.Name = "mskFechDesde";
            this.mskFechDesde.Size = new System.Drawing.Size(74, 20);
            this.mskFechDesde.TabIndex = 3;
            this.mskFechDesde.ValidatingType = typeof(System.DateTime);
            // 
            // lbFechaDesde
            // 
            this.lbFechaDesde.AutoSize = true;
            this.lbFechaDesde.Location = new System.Drawing.Point(15, 50);
            this.lbFechaDesde.Name = "lbFechaDesde";
            this.lbFechaDesde.Size = new System.Drawing.Size(74, 13);
            this.lbFechaDesde.TabIndex = 4;
            this.lbFechaDesde.Text = "Fecha Desde:";
            // 
            // lbFechaHasta
            // 
            this.lbFechaHasta.AutoSize = true;
            this.lbFechaHasta.Location = new System.Drawing.Point(175, 50);
            this.lbFechaHasta.Name = "lbFechaHasta";
            this.lbFechaHasta.Size = new System.Drawing.Size(71, 13);
            this.lbFechaHasta.TabIndex = 5;
            this.lbFechaHasta.Text = "Fecha Hasta:";
            // 
            // mskFechaDesde
            // 
            this.mskFechaDesde.Location = new System.Drawing.Point(263, 43);
            this.mskFechaDesde.Mask = "00/00/0000";
            this.mskFechaDesde.Name = "mskFechaDesde";
            this.mskFechaDesde.Size = new System.Drawing.Size(100, 20);
            this.mskFechaDesde.TabIndex = 6;
            this.mskFechaDesde.ValidatingType = typeof(System.DateTime);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(263, 7);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 7;
            // 
            // btBuscar
            // 
            this.btBuscar.Location = new System.Drawing.Point(288, 69);
            this.btBuscar.Name = "btBuscar";
            this.btBuscar.Size = new System.Drawing.Size(75, 23);
            this.btBuscar.TabIndex = 8;
            this.btBuscar.Text = "Buscar";
            this.btBuscar.UseVisualStyleBackColor = true;
            // 
            // GrillaClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btBuscar);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.mskFechaDesde);
            this.Controls.Add(this.lbFechaHasta);
            this.Controls.Add(this.lbFechaDesde);
            this.Controls.Add(this.mskFechDesde);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lbFiltros);
            this.Controls.Add(this.dataGridView1);
            this.Name = "GrillaClientes";
            this.Text = "GrillaClientes";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lbFiltros;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.MaskedTextBox mskFechDesde;
        private System.Windows.Forms.Label lbFechaDesde;
        private System.Windows.Forms.Label lbFechaHasta;
        private System.Windows.Forms.MaskedTextBox mskFechaDesde;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btBuscar;
    }
}