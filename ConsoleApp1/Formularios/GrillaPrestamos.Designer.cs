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
            this.lbTituloMenu = new System.Windows.Forms.Label();
            this.btDetalle = new System.Windows.Forms.Button();
            this.rbTodos = new System.Windows.Forms.RadioButton();
            this.rbVip = new System.Windows.Forms.RadioButton();
            this.rbRegular = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.mskHasta = new System.Windows.Forms.MaskedTextBox();
            this.mskDesde = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btFiltrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrestamos)).BeginInit();
            this.groupBox1.SuspendLayout();
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
            // lbTituloMenu
            // 
            this.lbTituloMenu.AutoSize = true;
            this.lbTituloMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTituloMenu.Location = new System.Drawing.Point(10, 7);
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
            // rbTodos
            // 
            this.rbTodos.AutoSize = true;
            this.rbTodos.Checked = true;
            this.rbTodos.Location = new System.Drawing.Point(21, 16);
            this.rbTodos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbTodos.Name = "rbTodos";
            this.rbTodos.Size = new System.Drawing.Size(55, 17);
            this.rbTodos.TabIndex = 31;
            this.rbTodos.TabStop = true;
            this.rbTodos.Text = "Todos";
            this.rbTodos.UseVisualStyleBackColor = true;
            // 
            // rbVip
            // 
            this.rbVip.AutoSize = true;
            this.rbVip.Location = new System.Drawing.Point(77, 16);
            this.rbVip.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbVip.Name = "rbVip";
            this.rbVip.Size = new System.Drawing.Size(42, 17);
            this.rbVip.TabIndex = 32;
            this.rbVip.TabStop = true;
            this.rbVip.Text = "VIP";
            this.rbVip.UseVisualStyleBackColor = true;
            // 
            // rbRegular
            // 
            this.rbRegular.AutoSize = true;
            this.rbRegular.Location = new System.Drawing.Point(119, 16);
            this.rbRegular.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbRegular.Name = "rbRegular";
            this.rbRegular.Size = new System.Drawing.Size(62, 17);
            this.rbRegular.TabIndex = 33;
            this.rbRegular.TabStop = true;
            this.rbRegular.Text = "Regular";
            this.rbRegular.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbRegular);
            this.groupBox1.Controls.Add(this.rbTodos);
            this.groupBox1.Controls.Add(this.rbVip);
            this.groupBox1.Location = new System.Drawing.Point(470, 35);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(183, 42);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo Cliente";
            // 
            // mskHasta
            // 
            this.mskHasta.Location = new System.Drawing.Point(383, 51);
            this.mskHasta.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mskHasta.Mask = "00/00/0000";
            this.mskHasta.Name = "mskHasta";
            this.mskHasta.Size = new System.Drawing.Size(76, 20);
            this.mskHasta.TabIndex = 35;
            this.mskHasta.ValidatingType = typeof(System.DateTime);
            // 
            // mskDesde
            // 
            this.mskDesde.Location = new System.Drawing.Point(293, 50);
            this.mskDesde.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mskDesde.Mask = "00/00/0000";
            this.mskDesde.Name = "mskDesde";
            this.mskDesde.Size = new System.Drawing.Size(76, 20);
            this.mskDesde.TabIndex = 36;
            this.mskDesde.ValidatingType = typeof(System.DateTime);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(291, 35);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 37;
            this.label1.Text = "Desde";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(381, 35);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 38;
            this.label2.Text = "Hasta";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(140, 50);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNombre.MaxLength = 30;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(150, 20);
            this.txtNombre.TabIndex = 39;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(137, 35);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 40;
            this.label3.Text = "Cliente";
            // 
            // btFiltrar
            // 
            this.btFiltrar.Location = new System.Drawing.Point(658, 44);
            this.btFiltrar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btFiltrar.Name = "btFiltrar";
            this.btFiltrar.Size = new System.Drawing.Size(74, 33);
            this.btFiltrar.TabIndex = 41;
            this.btFiltrar.Text = "Filtrar";
            this.btFiltrar.UseVisualStyleBackColor = true;
            this.btFiltrar.Click += new System.EventHandler(this.btFiltrar_Click);
            // 
            // GrillaPrestamos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 422);
            this.Controls.Add(this.btFiltrar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mskDesde);
            this.Controls.Add(this.mskHasta);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btDetalle);
            this.Controls.Add(this.lbTituloMenu);
            this.Controls.Add(this.dgvPrestamos);
            this.Name = "GrillaPrestamos";
            this.Text = "ListarPrestamos";
            this.Load += new System.EventHandler(this.GrillaPrestamos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrestamos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPrestamos;
        private System.Windows.Forms.Label lbTituloMenu;
        private System.Windows.Forms.Button btDetalle;
        private System.Windows.Forms.RadioButton rbTodos;
        private System.Windows.Forms.RadioButton rbVip;
        private System.Windows.Forms.RadioButton rbRegular;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox mskHasta;
        private System.Windows.Forms.MaskedTextBox mskDesde;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btFiltrar;
    }
}