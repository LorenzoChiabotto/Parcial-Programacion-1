namespace Formularios
{
    partial class AltaPrestamo
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
            this.lbFechaCredito = new System.Windows.Forms.Label();
            this.lbComercioAdherido = new System.Windows.Forms.Label();
            this.lbSucursal = new System.Windows.Forms.Label();
            this.lbMontoCredito = new System.Windows.Forms.Label();
            this.txtFechaCredito = new System.Windows.Forms.TextBox();
            this.cbSucursal = new System.Windows.Forms.ComboBox();
            this.txtMontoCredito = new System.Windows.Forms.TextBox();
            this.btGuardar = new System.Windows.Forms.Button();
            this.lbDoc = new System.Windows.Forms.Label();
            this.cbTipoDocumento = new System.Windows.Forms.ComboBox();
            this.lbTipoDocumento = new System.Windows.Forms.Label();
            this.txtDocumento = new System.Windows.Forms.TextBox();
            this.lbTituloMenu = new System.Windows.Forms.Label();
            this.cbComercio = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblValorTasa = new System.Windows.Forms.Label();
            this.txtCuotas = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCheckCliente = new System.Windows.Forms.Label();
            this.lblMontoTotal = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblMontoMaximo = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblMontoCuota = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbFechaCredito
            // 
            this.lbFechaCredito.AutoSize = true;
            this.lbFechaCredito.Location = new System.Drawing.Point(16, 145);
            this.lbFechaCredito.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbFechaCredito.Name = "lbFechaCredito";
            this.lbFechaCredito.Size = new System.Drawing.Size(117, 17);
            this.lbFechaCredito.TabIndex = 1;
            this.lbFechaCredito.Text = "Fecha del credito";
            // 
            // lbComercioAdherido
            // 
            this.lbComercioAdherido.AutoSize = true;
            this.lbComercioAdherido.Location = new System.Drawing.Point(11, 180);
            this.lbComercioAdherido.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbComercioAdherido.Name = "lbComercioAdherido";
            this.lbComercioAdherido.Size = new System.Drawing.Size(128, 17);
            this.lbComercioAdherido.TabIndex = 2;
            this.lbComercioAdherido.Text = "Comercio Adherido";
            // 
            // lbSucursal
            // 
            this.lbSucursal.AutoSize = true;
            this.lbSucursal.Location = new System.Drawing.Point(395, 83);
            this.lbSucursal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbSucursal.Name = "lbSucursal";
            this.lbSucursal.Size = new System.Drawing.Size(67, 17);
            this.lbSucursal.TabIndex = 3;
            this.lbSucursal.Text = "Sucursal:";
            // 
            // lbMontoCredito
            // 
            this.lbMontoCredito.AutoSize = true;
            this.lbMontoCredito.Location = new System.Drawing.Point(341, 53);
            this.lbMontoCredito.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbMontoCredito.Name = "lbMontoCredito";
            this.lbMontoCredito.Size = new System.Drawing.Size(119, 17);
            this.lbMontoCredito.TabIndex = 4;
            this.lbMontoCredito.Text = "Monto del Crédito";
            // 
            // txtFechaCredito
            // 
            this.txtFechaCredito.Location = new System.Drawing.Point(145, 142);
            this.txtFechaCredito.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtFechaCredito.Name = "txtFechaCredito";
            this.txtFechaCredito.Size = new System.Drawing.Size(188, 22);
            this.txtFechaCredito.TabIndex = 4;
            // 
            // cbSucursal
            // 
            this.cbSucursal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSucursal.FormattingEnabled = true;
            this.cbSucursal.Location = new System.Drawing.Point(469, 80);
            this.cbSucursal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbSucursal.Name = "cbSucursal";
            this.cbSucursal.Size = new System.Drawing.Size(259, 24);
            this.cbSucursal.TabIndex = 5;
            this.cbSucursal.SelectedIndexChanged += new System.EventHandler(this.cbSucursal_SelectedIndexChanged);
            // 
            // txtMontoCredito
            // 
            this.txtMontoCredito.Location = new System.Drawing.Point(469, 50);
            this.txtMontoCredito.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMontoCredito.MaxLength = 8;
            this.txtMontoCredito.Name = "txtMontoCredito";
            this.txtMontoCredito.Size = new System.Drawing.Size(113, 22);
            this.txtMontoCredito.TabIndex = 7;
            this.txtMontoCredito.TextChanged += new System.EventHandler(this.txtMontoCredito_TextChanged);
            this.txtMontoCredito.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_MontoKeyPress);
            // 
            // btGuardar
            // 
            this.btGuardar.Location = new System.Drawing.Point(577, 165);
            this.btGuardar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btGuardar.Name = "btGuardar";
            this.btGuardar.Size = new System.Drawing.Size(189, 66);
            this.btGuardar.TabIndex = 9;
            this.btGuardar.Text = "Guardar";
            this.btGuardar.UseVisualStyleBackColor = true;
            this.btGuardar.Click += new System.EventHandler(this.btGuardar_Click);
            // 
            // lbDoc
            // 
            this.lbDoc.AutoSize = true;
            this.lbDoc.Location = new System.Drawing.Point(16, 92);
            this.lbDoc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbDoc.Name = "lbDoc";
            this.lbDoc.Size = new System.Drawing.Size(84, 17);
            this.lbDoc.TabIndex = 12;
            this.lbDoc.Text = "Documento:";
            // 
            // cbTipoDocumento
            // 
            this.cbTipoDocumento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoDocumento.FormattingEnabled = true;
            this.cbTipoDocumento.Location = new System.Drawing.Point(145, 48);
            this.cbTipoDocumento.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbTipoDocumento.Name = "cbTipoDocumento";
            this.cbTipoDocumento.Size = new System.Drawing.Size(188, 24);
            this.cbTipoDocumento.TabIndex = 2;
            this.cbTipoDocumento.SelectedIndexChanged += new System.EventHandler(this.cbTipoDocumento_SelectedIndexChanged);
            // 
            // lbTipoDocumento
            // 
            this.lbTipoDocumento.AutoSize = true;
            this.lbTipoDocumento.Location = new System.Drawing.Point(16, 54);
            this.lbTipoDocumento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTipoDocumento.Name = "lbTipoDocumento";
            this.lbTipoDocumento.Size = new System.Drawing.Size(112, 17);
            this.lbTipoDocumento.TabIndex = 13;
            this.lbTipoDocumento.Text = "Tipo Documento";
            // 
            // txtDocumento
            // 
            this.txtDocumento.Location = new System.Drawing.Point(145, 86);
            this.txtDocumento.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDocumento.MaxLength = 8;
            this.txtDocumento.Name = "txtDocumento";
            this.txtDocumento.Size = new System.Drawing.Size(151, 22);
            this.txtDocumento.TabIndex = 3;
            this.txtDocumento.TextChanged += new System.EventHandler(this.txtDocumento_TextChanged);
            this.txtDocumento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDNI_keypress);
            // 
            // lbTituloMenu
            // 
            this.lbTituloMenu.AutoSize = true;
            this.lbTituloMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTituloMenu.Location = new System.Drawing.Point(73, 11);
            this.lbTituloMenu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTituloMenu.Name = "lbTituloMenu";
            this.lbTituloMenu.Size = new System.Drawing.Size(175, 29);
            this.lbTituloMenu.TabIndex = 28;
            this.lbTituloMenu.Text = "Alta Prestamo";
            // 
            // cbComercio
            // 
            this.cbComercio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbComercio.FormattingEnabled = true;
            this.cbComercio.Location = new System.Drawing.Point(145, 178);
            this.cbComercio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbComercio.Name = "cbComercio";
            this.cbComercio.Size = new System.Drawing.Size(188, 24);
            this.cbComercio.TabIndex = 29;
            this.cbComercio.SelectedIndexChanged += new System.EventHandler(this.cbComercio_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(417, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 17);
            this.label1.TabIndex = 30;
            this.label1.Text = "Tasa:";
            // 
            // lblValorTasa
            // 
            this.lblValorTasa.AutoSize = true;
            this.lblValorTasa.Location = new System.Drawing.Point(467, 118);
            this.lblValorTasa.Name = "lblValorTasa";
            this.lblValorTasa.Size = new System.Drawing.Size(103, 17);
            this.lblValorTasa.TabIndex = 31;
            this.lblValorTasa.Text = "[VALOR TASA]";
            // 
            // txtCuotas
            // 
            this.txtCuotas.Location = new System.Drawing.Point(673, 50);
            this.txtCuotas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCuotas.MaxLength = 8;
            this.txtCuotas.Name = "txtCuotas";
            this.txtCuotas.Size = new System.Drawing.Size(55, 22);
            this.txtCuotas.TabIndex = 33;
            this.txtCuotas.TextChanged += new System.EventHandler(this.txtCuotas_TextChanged);
            this.txtCuotas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_MontoCreditoKeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(593, 53);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 17);
            this.label2.TabIndex = 32;
            this.label2.Text = "N° Cuotas";
            // 
            // lblCheckCliente
            // 
            this.lblCheckCliente.AutoSize = true;
            this.lblCheckCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCheckCliente.Location = new System.Drawing.Point(298, 86);
            this.lblCheckCliente.Name = "lblCheckCliente";
            this.lblCheckCliente.Size = new System.Drawing.Size(70, 20);
            this.lblCheckCliente.TabIndex = 34;
            this.lblCheckCliente.Text = "[check]";
            // 
            // lblMontoTotal
            // 
            this.lblMontoTotal.AutoSize = true;
            this.lblMontoTotal.Location = new System.Drawing.Point(472, 178);
            this.lblMontoTotal.Name = "lblMontoTotal";
            this.lblMontoTotal.Size = new System.Drawing.Size(55, 17);
            this.lblMontoTotal.TabIndex = 36;
            this.lblMontoTotal.Text = "[Monto]";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(379, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 17);
            this.label4.TabIndex = 35;
            this.label4.Text = "Monto Total";
            // 
            // lblMontoMaximo
            // 
            this.lblMontoMaximo.AutoSize = true;
            this.lblMontoMaximo.Location = new System.Drawing.Point(246, 118);
            this.lblMontoMaximo.Name = "lblMontoMaximo";
            this.lblMontoMaximo.Size = new System.Drawing.Size(55, 17);
            this.lblMontoMaximo.TabIndex = 38;
            this.lblMontoMaximo.Text = "[Monto]";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(142, 118);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 17);
            this.label6.TabIndex = 37;
            this.label6.Text = "Monto Maximo";
            // 
            // lblMontoCuota
            // 
            this.lblMontoCuota.AutoSize = true;
            this.lblMontoCuota.Location = new System.Drawing.Point(472, 206);
            this.lblMontoCuota.Name = "lblMontoCuota";
            this.lblMontoCuota.Size = new System.Drawing.Size(55, 17);
            this.lblMontoCuota.TabIndex = 40;
            this.lblMontoCuota.Text = "[Monto]";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(374, 204);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 17);
            this.label5.TabIndex = 39;
            this.label5.Text = "Monto Cuota";
            // 
            // AltaPrestamo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(779, 244);
            this.Controls.Add(this.lblMontoCuota);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblMontoMaximo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblMontoTotal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblCheckCliente);
            this.Controls.Add(this.txtCuotas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblValorTasa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbComercio);
            this.Controls.Add(this.lbTituloMenu);
            this.Controls.Add(this.txtDocumento);
            this.Controls.Add(this.cbTipoDocumento);
            this.Controls.Add(this.lbTipoDocumento);
            this.Controls.Add(this.lbDoc);
            this.Controls.Add(this.btGuardar);
            this.Controls.Add(this.txtMontoCredito);
            this.Controls.Add(this.cbSucursal);
            this.Controls.Add(this.txtFechaCredito);
            this.Controls.Add(this.lbMontoCredito);
            this.Controls.Add(this.lbSucursal);
            this.Controls.Add(this.lbComercioAdherido);
            this.Controls.Add(this.lbFechaCredito);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AltaPrestamo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AltaPrestamo";
            this.Load += new System.EventHandler(this.AltaPrestamo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbFechaCredito;
        private System.Windows.Forms.Label lbComercioAdherido;
        private System.Windows.Forms.Label lbSucursal;
        private System.Windows.Forms.Label lbMontoCredito;
        private System.Windows.Forms.TextBox txtFechaCredito;
        private System.Windows.Forms.ComboBox cbSucursal;
        private System.Windows.Forms.TextBox txtMontoCredito;
        private System.Windows.Forms.Button btGuardar;
        private System.Windows.Forms.Label lbDoc;
        private System.Windows.Forms.ComboBox cbTipoDocumento;
        private System.Windows.Forms.Label lbTipoDocumento;
        private System.Windows.Forms.TextBox txtDocumento;
        private System.Windows.Forms.Label lbTituloMenu;
        private System.Windows.Forms.ComboBox cbComercio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblValorTasa;
        private System.Windows.Forms.TextBox txtCuotas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCheckCliente;
        private System.Windows.Forms.Label lblMontoTotal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblMontoMaximo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblMontoCuota;
        private System.Windows.Forms.Label label5;
    }
}