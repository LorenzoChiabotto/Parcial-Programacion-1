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
            this.SuspendLayout();
            // 
            // lbFechaCredito
            // 
            this.lbFechaCredito.AutoSize = true;
            this.lbFechaCredito.Location = new System.Drawing.Point(12, 103);
            this.lbFechaCredito.Name = "lbFechaCredito";
            this.lbFechaCredito.Size = new System.Drawing.Size(89, 13);
            this.lbFechaCredito.TabIndex = 1;
            this.lbFechaCredito.Text = "Fecha del credito";
            // 
            // lbComercioAdherido
            // 
            this.lbComercioAdherido.AutoSize = true;
            this.lbComercioAdherido.Location = new System.Drawing.Point(8, 132);
            this.lbComercioAdherido.Name = "lbComercioAdherido";
            this.lbComercioAdherido.Size = new System.Drawing.Size(96, 13);
            this.lbComercioAdherido.TabIndex = 2;
            this.lbComercioAdherido.Text = "Comercio Adherido";
            // 
            // lbSucursal
            // 
            this.lbSucursal.AutoSize = true;
            this.lbSucursal.Location = new System.Drawing.Point(296, 71);
            this.lbSucursal.Name = "lbSucursal";
            this.lbSucursal.Size = new System.Drawing.Size(51, 13);
            this.lbSucursal.TabIndex = 3;
            this.lbSucursal.Text = "Sucursal:";
            // 
            // lbMontoCredito
            // 
            this.lbMontoCredito.AutoSize = true;
            this.lbMontoCredito.Location = new System.Drawing.Point(256, 43);
            this.lbMontoCredito.Name = "lbMontoCredito";
            this.lbMontoCredito.Size = new System.Drawing.Size(90, 13);
            this.lbMontoCredito.TabIndex = 4;
            this.lbMontoCredito.Text = "Monto del Crédito";
            // 
            // txtFechaCredito
            // 
            this.txtFechaCredito.Location = new System.Drawing.Point(109, 101);
            this.txtFechaCredito.Name = "txtFechaCredito";
            this.txtFechaCredito.Size = new System.Drawing.Size(142, 20);
            this.txtFechaCredito.TabIndex = 4;
            // 
            // cbSucursal
            // 
            this.cbSucursal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSucursal.FormattingEnabled = true;
            this.cbSucursal.Location = new System.Drawing.Point(352, 68);
            this.cbSucursal.Name = "cbSucursal";
            this.cbSucursal.Size = new System.Drawing.Size(195, 21);
            this.cbSucursal.TabIndex = 5;
            this.cbSucursal.SelectedIndexChanged += new System.EventHandler(this.cbSucursal_SelectedIndexChanged);
            // 
            // txtMontoCredito
            // 
            this.txtMontoCredito.Location = new System.Drawing.Point(352, 41);
            this.txtMontoCredito.MaxLength = 8;
            this.txtMontoCredito.Name = "txtMontoCredito";
            this.txtMontoCredito.Size = new System.Drawing.Size(86, 20);
            this.txtMontoCredito.TabIndex = 7;
            this.txtMontoCredito.TextChanged += new System.EventHandler(this.txtMontoCredito_TextChanged);
            this.txtMontoCredito.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_MontoKeyPress);
            // 
            // btGuardar
            // 
            this.btGuardar.Location = new System.Drawing.Point(404, 130);
            this.btGuardar.Name = "btGuardar";
            this.btGuardar.Size = new System.Drawing.Size(142, 54);
            this.btGuardar.TabIndex = 9;
            this.btGuardar.Text = "Guardar";
            this.btGuardar.UseVisualStyleBackColor = true;
            this.btGuardar.Click += new System.EventHandler(this.btGuardar_Click);
            // 
            // lbDoc
            // 
            this.lbDoc.AutoSize = true;
            this.lbDoc.Location = new System.Drawing.Point(12, 75);
            this.lbDoc.Name = "lbDoc";
            this.lbDoc.Size = new System.Drawing.Size(65, 13);
            this.lbDoc.TabIndex = 12;
            this.lbDoc.Text = "Documento:";
            // 
            // cbTipoDocumento
            // 
            this.cbTipoDocumento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoDocumento.FormattingEnabled = true;
            this.cbTipoDocumento.Location = new System.Drawing.Point(109, 39);
            this.cbTipoDocumento.Name = "cbTipoDocumento";
            this.cbTipoDocumento.Size = new System.Drawing.Size(142, 21);
            this.cbTipoDocumento.TabIndex = 2;
            this.cbTipoDocumento.SelectedIndexChanged += new System.EventHandler(this.cbTipoDocumento_SelectedIndexChanged);
            // 
            // lbTipoDocumento
            // 
            this.lbTipoDocumento.AutoSize = true;
            this.lbTipoDocumento.Location = new System.Drawing.Point(12, 44);
            this.lbTipoDocumento.Name = "lbTipoDocumento";
            this.lbTipoDocumento.Size = new System.Drawing.Size(86, 13);
            this.lbTipoDocumento.TabIndex = 13;
            this.lbTipoDocumento.Text = "Tipo Documento";
            // 
            // txtDocumento
            // 
            this.txtDocumento.Location = new System.Drawing.Point(109, 70);
            this.txtDocumento.MaxLength = 8;
            this.txtDocumento.Name = "txtDocumento";
            this.txtDocumento.Size = new System.Drawing.Size(142, 20);
            this.txtDocumento.TabIndex = 3;
            this.txtDocumento.TextChanged += new System.EventHandler(this.txtDocumento_TextChanged);
            this.txtDocumento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDNI_keypress);
            // 
            // lbTituloMenu
            // 
            this.lbTituloMenu.AutoSize = true;
            this.lbTituloMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTituloMenu.Location = new System.Drawing.Point(55, 9);
            this.lbTituloMenu.Name = "lbTituloMenu";
            this.lbTituloMenu.Size = new System.Drawing.Size(138, 24);
            this.lbTituloMenu.TabIndex = 28;
            this.lbTituloMenu.Text = "Alta Prestamo";
            // 
            // cbComercio
            // 
            this.cbComercio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbComercio.FormattingEnabled = true;
            this.cbComercio.Location = new System.Drawing.Point(109, 130);
            this.cbComercio.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbComercio.Name = "cbComercio";
            this.cbComercio.Size = new System.Drawing.Size(142, 21);
            this.cbComercio.TabIndex = 29;
            this.cbComercio.SelectedIndexChanged += new System.EventHandler(this.cbComercio_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(313, 99);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 30;
            this.label1.Text = "Tasa:";
            // 
            // lblValorTasa
            // 
            this.lblValorTasa.AutoSize = true;
            this.lblValorTasa.Location = new System.Drawing.Point(350, 99);
            this.lblValorTasa.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblValorTasa.Name = "lblValorTasa";
            this.lblValorTasa.Size = new System.Drawing.Size(80, 13);
            this.lblValorTasa.TabIndex = 31;
            this.lblValorTasa.Text = "[VALOR TASA]";
            // 
            // txtCuotas
            // 
            this.txtCuotas.Location = new System.Drawing.Point(505, 41);
            this.txtCuotas.MaxLength = 8;
            this.txtCuotas.Name = "txtCuotas";
            this.txtCuotas.Size = new System.Drawing.Size(42, 20);
            this.txtCuotas.TabIndex = 33;
            this.txtCuotas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_MontoCreditoKeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(445, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 32;
            this.label2.Text = "N° Cuotas";
            // 
            // AltaPrestamo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(584, 234);
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
    }
}