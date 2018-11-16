namespace Formularios
{
    partial class DetallePrestamo
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
            this.label7 = new System.Windows.Forms.Label();
            this.lblCuotas = new System.Windows.Forms.Label();
            this.lblFechaPago = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btRealizarPago = new System.Windows.Forms.Button();
            this.cbLugarPago = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.lbDetCuota = new System.Windows.Forms.Label();
            this.lbMontoCuota = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.lblMonto = new System.Windows.Forms.Label();
            this.lblTasa = new System.Windows.Forms.Label();
            this.lblComercio = new System.Windows.Forms.Label();
            this.lblSucursal = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblNroPrestamo = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvPagos = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblNroDoc = new System.Windows.Forms.Label();
            this.lblTipoDoc = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblPagado = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPagos)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(74, 241);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "Cuotas";
            // 
            // lblCuotas
            // 
            this.lblCuotas.AutoSize = true;
            this.lblCuotas.Location = new System.Drawing.Point(142, 241);
            this.lblCuotas.Name = "lblCuotas";
            this.lblCuotas.Size = new System.Drawing.Size(60, 17);
            this.lblCuotas.TabIndex = 27;
            this.lblCuotas.Text = "[Cuotas]";
            // 
            // lblFechaPago
            // 
            this.lblFechaPago.AutoSize = true;
            this.lblFechaPago.Location = new System.Drawing.Point(164, 63);
            this.lblFechaPago.Name = "lblFechaPago";
            this.lblFechaPago.Size = new System.Drawing.Size(48, 17);
            this.lblFechaPago.TabIndex = 6;
            this.lblFechaPago.Text = "  /  /    ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(111, 63);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(47, 17);
            this.label12.TabIndex = 5;
            this.label12.Text = "Fecha";
            // 
            // btRealizarPago
            // 
            this.btRealizarPago.Location = new System.Drawing.Point(82, 100);
            this.btRealizarPago.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btRealizarPago.Name = "btRealizarPago";
            this.btRealizarPago.Size = new System.Drawing.Size(138, 39);
            this.btRealizarPago.TabIndex = 4;
            this.btRealizarPago.Text = "Realizar Pago";
            this.btRealizarPago.UseVisualStyleBackColor = true;
            this.btRealizarPago.Click += new System.EventHandler(this.btRealizarPago_Click);
            // 
            // cbLugarPago
            // 
            this.cbLugarPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLugarPago.FormattingEnabled = true;
            this.cbLugarPago.Location = new System.Drawing.Point(114, 37);
            this.cbLugarPago.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbLugarPago.Name = "cbLugarPago";
            this.cbLugarPago.Size = new System.Drawing.Size(160, 24);
            this.cbLugarPago.TabIndex = 3;
            this.cbLugarPago.SelectedIndexChanged += new System.EventHandler(this.cbLugarPago_SelectedIndexChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 40);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(102, 17);
            this.label13.TabIndex = 1;
            this.label13.Text = "Lugar de Pago";
            // 
            // lbDetCuota
            // 
            this.lbDetCuota.AutoSize = true;
            this.lbDetCuota.Location = new System.Drawing.Point(37, 273);
            this.lbDetCuota.Name = "lbDetCuota";
            this.lbDetCuota.Size = new System.Drawing.Size(88, 17);
            this.lbDetCuota.TabIndex = 30;
            this.lbDetCuota.Text = "Monto Cuota";
            // 
            // lbMontoCuota
            // 
            this.lbMontoCuota.AutoSize = true;
            this.lbMontoCuota.Location = new System.Drawing.Point(142, 273);
            this.lbMontoCuota.Name = "lbMontoCuota";
            this.lbMontoCuota.Size = new System.Drawing.Size(96, 17);
            this.lbMontoCuota.TabIndex = 31;
            this.lbMontoCuota.Text = "[Monto Cuota]";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(12, 24);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(95, 20);
            this.label22.TabIndex = 44;
            this.label22.Text = "Prestamo:";
            // 
            // lblMonto
            // 
            this.lblMonto.AutoSize = true;
            this.lblMonto.Location = new System.Drawing.Point(142, 214);
            this.lblMonto.Name = "lblMonto";
            this.lblMonto.Size = new System.Drawing.Size(55, 17);
            this.lblMonto.TabIndex = 43;
            this.lblMonto.Text = "[Monto]";
            // 
            // lblTasa
            // 
            this.lblTasa.AutoSize = true;
            this.lblTasa.Location = new System.Drawing.Point(142, 183);
            this.lblTasa.Name = "lblTasa";
            this.lblTasa.Size = new System.Drawing.Size(48, 17);
            this.lblTasa.TabIndex = 42;
            this.lblTasa.Text = "[Tasa]";
            // 
            // lblComercio
            // 
            this.lblComercio.AutoSize = true;
            this.lblComercio.Location = new System.Drawing.Point(142, 153);
            this.lblComercio.Name = "lblComercio";
            this.lblComercio.Size = new System.Drawing.Size(75, 17);
            this.lblComercio.TabIndex = 41;
            this.lblComercio.Text = "[Comercio]";
            // 
            // lblSucursal
            // 
            this.lblSucursal.AutoSize = true;
            this.lblSucursal.Location = new System.Drawing.Point(142, 123);
            this.lblSucursal.Name = "lblSucursal";
            this.lblSucursal.Size = new System.Drawing.Size(71, 17);
            this.lblSucursal.TabIndex = 40;
            this.lblSucursal.Text = "[Sucursal]";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(142, 95);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(55, 17);
            this.lblFecha.TabIndex = 39;
            this.lblFecha.Text = "[Fecha]";
            // 
            // lblNroPrestamo
            // 
            this.lblNroPrestamo.AutoSize = true;
            this.lblNroPrestamo.Location = new System.Drawing.Point(142, 64);
            this.lblNroPrestamo.Name = "lblNroPrestamo";
            this.lblNroPrestamo.Size = new System.Drawing.Size(99, 17);
            this.lblNroPrestamo.TabIndex = 38;
            this.lblNroPrestamo.Text = "[NroPrestamo]";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(84, 183);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 17);
            this.label8.TabIndex = 37;
            this.label8.Text = "Tasa";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(78, 214);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 17);
            this.label6.TabIndex = 36;
            this.label6.Text = "Monto ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(58, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 17);
            this.label5.TabIndex = 35;
            this.label5.Text = "Comercio";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(62, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 17);
            this.label4.TabIndex = 34;
            this.label4.Text = "Sucursal";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(78, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 17);
            this.label2.TabIndex = 33;
            this.label2.Text = "Fecha";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 17);
            this.label1.TabIndex = 32;
            this.label1.Text = "Nro. prestamo";
            // 
            // dgvPagos
            // 
            this.dgvPagos.AllowUserToAddRows = false;
            this.dgvPagos.AllowUserToDeleteRows = false;
            this.dgvPagos.AllowUserToOrderColumns = true;
            this.dgvPagos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPagos.Location = new System.Drawing.Point(757, 43);
            this.dgvPagos.Name = "dgvPagos";
            this.dgvPagos.ReadOnly = true;
            this.dgvPagos.RowTemplate.Height = 24;
            this.dgvPagos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPagos.Size = new System.Drawing.Size(617, 318);
            this.dgvPagos.TabIndex = 45;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btRealizarPago);
            this.groupBox1.Controls.Add(this.lblFechaPago);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.cbLugarPago);
            this.groupBox1.Location = new System.Drawing.Point(373, 197);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(288, 143);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Realizar Pago";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(754, 23);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(52, 17);
            this.label14.TabIndex = 46;
            this.label14.Text = "Pagos:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(569, 123);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(66, 17);
            this.lblNombre.TabIndex = 53;
            this.lblNombre.Text = "[Nombre]";
            // 
            // lblNroDoc
            // 
            this.lblNroDoc.AutoSize = true;
            this.lblNroDoc.Location = new System.Drawing.Point(569, 88);
            this.lblNroDoc.Name = "lblNroDoc";
            this.lblNroDoc.Size = new System.Drawing.Size(64, 17);
            this.lblNroDoc.TabIndex = 52;
            this.lblNroDoc.Text = "[NroDoc]";
            // 
            // lblTipoDoc
            // 
            this.lblTipoDoc.AutoSize = true;
            this.lblTipoDoc.Location = new System.Drawing.Point(569, 57);
            this.lblTipoDoc.Name = "lblTipoDoc";
            this.lblTipoDoc.Size = new System.Drawing.Size(69, 17);
            this.lblTipoDoc.TabIndex = 51;
            this.lblTipoDoc.Text = "[TipoDoc]";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(444, 123);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(119, 17);
            this.label11.TabIndex = 50;
            this.label11.Text = "Nombre completo";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(456, 88);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(107, 17);
            this.label10.TabIndex = 49;
            this.label10.Text = "Nro Documento";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(450, 57);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(112, 17);
            this.label9.TabIndex = 48;
            this.label9.Text = "Tipo Documento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(416, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 20);
            this.label3.TabIndex = 47;
            this.label3.Text = "Cliente:";
            // 
            // lblPagado
            // 
            this.lblPagado.AutoSize = true;
            this.lblPagado.Location = new System.Drawing.Point(857, 364);
            this.lblPagado.Name = "lblPagado";
            this.lblPagado.Size = new System.Drawing.Size(55, 17);
            this.lblPagado.TabIndex = 55;
            this.lblPagado.Text = "[Monto]";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(754, 364);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(97, 17);
            this.label16.TabIndex = 54;
            this.label16.Text = "Total Pagado:";
            // 
            // DetallePrestamo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1386, 393);
            this.Controls.Add(this.lblPagado);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblNroDoc);
            this.Controls.Add(this.lblTipoDoc);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.dgvPagos);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.lblMonto);
            this.Controls.Add(this.lblTasa);
            this.Controls.Add(this.lblComercio);
            this.Controls.Add(this.lblSucursal);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblNroPrestamo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbMontoCuota);
            this.Controls.Add(this.lbDetCuota);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblCuotas);
            this.Controls.Add(this.label7);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "DetallePrestamo";
            this.Text = "DetallePrestamo";
            this.Load += new System.EventHandler(this.DetallePrestamo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPagos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblCuotas;
        private System.Windows.Forms.Button btRealizarPago;
        private System.Windows.Forms.ComboBox cbLugarPago;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblFechaPago;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lbDetCuota;
        private System.Windows.Forms.Label lbMontoCuota;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label lblMonto;
        private System.Windows.Forms.Label lblTasa;
        private System.Windows.Forms.Label lblComercio;
        private System.Windows.Forms.Label lblSucursal;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblNroPrestamo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvPagos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblNroDoc;
        private System.Windows.Forms.Label lblTipoDoc;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblPagado;
        private System.Windows.Forms.Label label16;
    }
}