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
            this.lbTituloAltaPrestamo = new System.Windows.Forms.Label();
            this.lbFechaCredito = new System.Windows.Forms.Label();
            this.lbComercioAdherido = new System.Windows.Forms.Label();
            this.lbSucursal = new System.Windows.Forms.Label();
            this.lbMontoCredito = new System.Windows.Forms.Label();
            this.txtFechaCredito = new System.Windows.Forms.TextBox();
            this.cbSucursal = new System.Windows.Forms.ComboBox();
            this.txtComercioAdherido = new System.Windows.Forms.TextBox();
            this.txtMontoCredito = new System.Windows.Forms.TextBox();
            this.lbTasa = new System.Windows.Forms.Label();
            this.txtTasa = new System.Windows.Forms.TextBox();
            this.btGuardar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbTituloAltaPrestamo
            // 
            this.lbTituloAltaPrestamo.Location = new System.Drawing.Point(102, 18);
            this.lbTituloAltaPrestamo.Name = "lbTituloAltaPrestamo";
            this.lbTituloAltaPrestamo.Size = new System.Drawing.Size(100, 23);
            this.lbTituloAltaPrestamo.TabIndex = 0;
            this.lbTituloAltaPrestamo.Text = "Alta Prestamo";
            // 
            // lbFechaCredito
            // 
            this.lbFechaCredito.Location = new System.Drawing.Point(12, 67);
            this.lbFechaCredito.Name = "lbFechaCredito";
            this.lbFechaCredito.Size = new System.Drawing.Size(100, 23);
            this.lbFechaCredito.TabIndex = 1;
            this.lbFechaCredito.Text = "Fecha del credito";
            // 
            // lbComercioAdherido
            // 
            this.lbComercioAdherido.Location = new System.Drawing.Point(12, 105);
            this.lbComercioAdherido.Name = "lbComercioAdherido";
            this.lbComercioAdherido.Size = new System.Drawing.Size(100, 23);
            this.lbComercioAdherido.TabIndex = 2;
            this.lbComercioAdherido.Text = "Comercio Adherido";
            // 
            // lbSucursal
            // 
            this.lbSucursal.Location = new System.Drawing.Point(12, 140);
            this.lbSucursal.Name = "lbSucursal";
            this.lbSucursal.Size = new System.Drawing.Size(100, 23);
            this.lbSucursal.TabIndex = 3;
            this.lbSucursal.Text = "Sucursal:";
            // 
            // lbMontoCredito
            // 
            this.lbMontoCredito.Location = new System.Drawing.Point(12, 183);
            this.lbMontoCredito.Name = "lbMontoCredito";
            this.lbMontoCredito.Size = new System.Drawing.Size(100, 23);
            this.lbMontoCredito.TabIndex = 4;
            this.lbMontoCredito.Text = "Monto del Crédito";
            // 
            // txtFechaCredito
            // 
            this.txtFechaCredito.Location = new System.Drawing.Point(133, 67);
            this.txtFechaCredito.Name = "txtFechaCredito";
            this.txtFechaCredito.Size = new System.Drawing.Size(183, 20);
            this.txtFechaCredito.TabIndex = 5;
            this.txtFechaCredito.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // cbSucursal
            // 
            this.cbSucursal.FormattingEnabled = true;
            this.cbSucursal.Location = new System.Drawing.Point(133, 141);
            this.cbSucursal.Name = "cbSucursal";
            this.cbSucursal.Size = new System.Drawing.Size(183, 21);
            this.cbSucursal.TabIndex = 6;
            // 
            // txtComercioAdherido
            // 
            this.txtComercioAdherido.Location = new System.Drawing.Point(133, 107);
            this.txtComercioAdherido.Name = "txtComercioAdherido";
            this.txtComercioAdherido.Size = new System.Drawing.Size(183, 20);
            this.txtComercioAdherido.TabIndex = 7;
            // 
            // txtMontoCredito
            // 
            this.txtMontoCredito.Location = new System.Drawing.Point(133, 183);
            this.txtMontoCredito.Name = "txtMontoCredito";
            this.txtMontoCredito.Size = new System.Drawing.Size(183, 20);
            this.txtMontoCredito.TabIndex = 8;
            // 
            // lbTasa
            // 
            this.lbTasa.Location = new System.Drawing.Point(12, 219);
            this.lbTasa.Name = "lbTasa";
            this.lbTasa.Size = new System.Drawing.Size(100, 23);
            this.lbTasa.TabIndex = 9;
            this.lbTasa.Text = "Tasa";
            // 
            // txtTasa
            // 
            this.txtTasa.Location = new System.Drawing.Point(133, 216);
            this.txtTasa.Name = "txtTasa";
            this.txtTasa.Size = new System.Drawing.Size(100, 20);
            this.txtTasa.TabIndex = 10;
            // 
            // btGuardar
            // 
            this.btGuardar.Location = new System.Drawing.Point(315, 237);
            this.btGuardar.Name = "btGuardar";
            this.btGuardar.Size = new System.Drawing.Size(85, 49);
            this.btGuardar.TabIndex = 11;
            this.btGuardar.Text = "Guardar";
            this.btGuardar.UseVisualStyleBackColor = true;
            // 
            // AltaPrestamo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 298);
            this.Controls.Add(this.btGuardar);
            this.Controls.Add(this.txtTasa);
            this.Controls.Add(this.lbTasa);
            this.Controls.Add(this.txtMontoCredito);
            this.Controls.Add(this.txtComercioAdherido);
            this.Controls.Add(this.cbSucursal);
            this.Controls.Add(this.txtFechaCredito);
            this.Controls.Add(this.lbMontoCredito);
            this.Controls.Add(this.lbSucursal);
            this.Controls.Add(this.lbComercioAdherido);
            this.Controls.Add(this.lbFechaCredito);
            this.Controls.Add(this.lbTituloAltaPrestamo);
            this.Name = "AltaPrestamo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AltaPrestamo";
            this.Load += new System.EventHandler(this.AltaPrestamo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTituloAltaPrestamo;
        private System.Windows.Forms.Label lbFechaCredito;
        private System.Windows.Forms.Label lbComercioAdherido;
        private System.Windows.Forms.Label lbSucursal;
        private System.Windows.Forms.Label lbMontoCredito;
        private System.Windows.Forms.TextBox txtFechaCredito;
        private System.Windows.Forms.ComboBox cbSucursal;
        private System.Windows.Forms.TextBox txtComercioAdherido;
        private System.Windows.Forms.TextBox txtMontoCredito;
        private System.Windows.Forms.Label lbTasa;
        private System.Windows.Forms.TextBox txtTasa;
        private System.Windows.Forms.Button btGuardar;
    }
}