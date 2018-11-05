namespace Formularios
{
    partial class AltaCliente
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
            this.lbTipoDocumento = new System.Windows.Forms.Label();
            this.cbTipoDocumento = new System.Windows.Forms.ComboBox();
            this.lbDNI = new System.Windows.Forms.Label();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.lbNombreCompleto = new System.Windows.Forms.Label();
            this.txtNombreCompleto = new System.Windows.Forms.TextBox();
            this.lbCorreo = new System.Windows.Forms.Label();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.lbCelular = new System.Windows.Forms.Label();
            this.txtCelular = new System.Windows.Forms.TextBox();
            this.lbFechaNacimiento = new System.Windows.Forms.Label();
            this.rbMujer = new System.Windows.Forms.RadioButton();
            this.rbHombre = new System.Windows.Forms.RadioButton();
            this.lbDomicilio = new System.Windows.Forms.Label();
            this.txtDomicilio = new System.Windows.Forms.TextBox();
            this.lbCodigoPostal = new System.Windows.Forms.Label();
            this.txtCodigoPostal = new System.Windows.Forms.TextBox();
            this.lbLocalidad = new System.Windows.Forms.Label();
            this.txtLocalidad = new System.Windows.Forms.TextBox();
            this.lbSexo = new System.Windows.Forms.Label();
            this.lbTipoCliente = new System.Windows.Forms.Label();
            this.lbMontoMaximoaAutorizar = new System.Windows.Forms.Label();
            this.txtMontoMaximoaAutorizar = new System.Windows.Forms.TextBox();
            this.lbTituloMenu = new System.Windows.Forms.Label();
            this.mkTxtFechaNacimiento = new System.Windows.Forms.MaskedTextBox();
            this.cbTipodeCliente = new System.Windows.Forms.ComboBox();
            this.bGuardar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbTipoDocumento
            // 
            this.lbTipoDocumento.AutoSize = true;
            this.lbTipoDocumento.Location = new System.Drawing.Point(31, 70);
            this.lbTipoDocumento.Name = "lbTipoDocumento";
            this.lbTipoDocumento.Size = new System.Drawing.Size(86, 13);
            this.lbTipoDocumento.TabIndex = 0;
            this.lbTipoDocumento.Text = "Tipo Documento";
            this.lbTipoDocumento.Click += new System.EventHandler(this.lbTipoDocumento_Click);
            // 
            // cbTipoDocumento
            // 
            this.cbTipoDocumento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoDocumento.FormattingEnabled = true;
            this.cbTipoDocumento.Items.AddRange(new object[] {
            "DNI",
            "LE",
            "LC"});
            this.cbTipoDocumento.Location = new System.Drawing.Point(145, 62);
            this.cbTipoDocumento.Name = "cbTipoDocumento";
            this.cbTipoDocumento.Size = new System.Drawing.Size(156, 21);
            this.cbTipoDocumento.TabIndex = 1;
            this.cbTipoDocumento.SelectedIndexChanged += new System.EventHandler(this.cbTipoDocumento_SelectedIndexChanged);
            // 
            // lbDNI
            // 
            this.lbDNI.AutoSize = true;
            this.lbDNI.Location = new System.Drawing.Point(344, 70);
            this.lbDNI.Name = "lbDNI";
            this.lbDNI.Size = new System.Drawing.Size(26, 13);
            this.lbDNI.TabIndex = 2;
            this.lbDNI.Text = "DNI";
            // 
            // txtDNI
            // 
            this.txtDNI.Location = new System.Drawing.Point(473, 63);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(156, 20);
            this.txtDNI.TabIndex = 3;
            // 
            // lbNombreCompleto
            // 
            this.lbNombreCompleto.AutoSize = true;
            this.lbNombreCompleto.Location = new System.Drawing.Point(31, 97);
            this.lbNombreCompleto.Name = "lbNombreCompleto";
            this.lbNombreCompleto.Size = new System.Drawing.Size(91, 13);
            this.lbNombreCompleto.TabIndex = 4;
            this.lbNombreCompleto.Text = "Nombre Completo";
            // 
            // txtNombreCompleto
            // 
            this.txtNombreCompleto.Location = new System.Drawing.Point(145, 98);
            this.txtNombreCompleto.Name = "txtNombreCompleto";
            this.txtNombreCompleto.Size = new System.Drawing.Size(156, 20);
            this.txtNombreCompleto.TabIndex = 5;
            // 
            // lbCorreo
            // 
            this.lbCorreo.AutoSize = true;
            this.lbCorreo.Location = new System.Drawing.Point(341, 101);
            this.lbCorreo.Name = "lbCorreo";
            this.lbCorreo.Size = new System.Drawing.Size(94, 13);
            this.lbCorreo.TabIndex = 6;
            this.lbCorreo.Text = "Correo Electrónico";
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(473, 101);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(156, 20);
            this.txtCorreo.TabIndex = 7;
            this.txtCorreo.TextChanged += new System.EventHandler(this.txtCorreo_TextChanged);
            // 
            // lbCelular
            // 
            this.lbCelular.AutoSize = true;
            this.lbCelular.Location = new System.Drawing.Point(34, 127);
            this.lbCelular.Name = "lbCelular";
            this.lbCelular.Size = new System.Drawing.Size(39, 13);
            this.lbCelular.TabIndex = 8;
            this.lbCelular.Text = "Celular";
            // 
            // txtCelular
            // 
            this.txtCelular.Location = new System.Drawing.Point(145, 127);
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(156, 20);
            this.txtCelular.TabIndex = 9;
            // 
            // lbFechaNacimiento
            // 
            this.lbFechaNacimiento.AutoSize = true;
            this.lbFechaNacimiento.Location = new System.Drawing.Point(31, 219);
            this.lbFechaNacimiento.Name = "lbFechaNacimiento";
            this.lbFechaNacimiento.Size = new System.Drawing.Size(108, 13);
            this.lbFechaNacimiento.TabIndex = 10;
            this.lbFechaNacimiento.Text = "Fecha de Nacimiento";
            // 
            // rbMujer
            // 
            this.rbMujer.AutoSize = true;
            this.rbMujer.Location = new System.Drawing.Point(473, 134);
            this.rbMujer.Name = "rbMujer";
            this.rbMujer.Size = new System.Drawing.Size(62, 17);
            this.rbMujer.TabIndex = 12;
            this.rbMujer.TabStop = true;
            this.rbMujer.Text = "MUJER";
            this.rbMujer.UseVisualStyleBackColor = true;
            // 
            // rbHombre
            // 
            this.rbHombre.AutoSize = true;
            this.rbHombre.Location = new System.Drawing.Point(541, 134);
            this.rbHombre.Name = "rbHombre";
            this.rbHombre.Size = new System.Drawing.Size(72, 17);
            this.rbHombre.TabIndex = 13;
            this.rbHombre.TabStop = true;
            this.rbHombre.Text = "HOMBRE";
            this.rbHombre.UseVisualStyleBackColor = true;
            // 
            // lbDomicilio
            // 
            this.lbDomicilio.AutoSize = true;
            this.lbDomicilio.Location = new System.Drawing.Point(34, 158);
            this.lbDomicilio.Name = "lbDomicilio";
            this.lbDomicilio.Size = new System.Drawing.Size(49, 13);
            this.lbDomicilio.TabIndex = 14;
            this.lbDomicilio.Text = "Domicilio";
            // 
            // txtDomicilio
            // 
            this.txtDomicilio.Location = new System.Drawing.Point(145, 153);
            this.txtDomicilio.Name = "txtDomicilio";
            this.txtDomicilio.Size = new System.Drawing.Size(156, 20);
            this.txtDomicilio.TabIndex = 15;
            // 
            // lbCodigoPostal
            // 
            this.lbCodigoPostal.AutoSize = true;
            this.lbCodigoPostal.Location = new System.Drawing.Point(341, 162);
            this.lbCodigoPostal.Name = "lbCodigoPostal";
            this.lbCodigoPostal.Size = new System.Drawing.Size(72, 13);
            this.lbCodigoPostal.TabIndex = 16;
            this.lbCodigoPostal.Text = "Código Postal";
            // 
            // txtCodigoPostal
            // 
            this.txtCodigoPostal.Location = new System.Drawing.Point(473, 162);
            this.txtCodigoPostal.Name = "txtCodigoPostal";
            this.txtCodigoPostal.Size = new System.Drawing.Size(156, 20);
            this.txtCodigoPostal.TabIndex = 17;
            // 
            // lbLocalidad
            // 
            this.lbLocalidad.AutoSize = true;
            this.lbLocalidad.Location = new System.Drawing.Point(34, 183);
            this.lbLocalidad.Name = "lbLocalidad";
            this.lbLocalidad.Size = new System.Drawing.Size(53, 13);
            this.lbLocalidad.TabIndex = 18;
            this.lbLocalidad.Text = "Localidad";
            // 
            // txtLocalidad
            // 
            this.txtLocalidad.Location = new System.Drawing.Point(145, 181);
            this.txtLocalidad.Name = "txtLocalidad";
            this.txtLocalidad.Size = new System.Drawing.Size(156, 20);
            this.txtLocalidad.TabIndex = 19;
            // 
            // lbSexo
            // 
            this.lbSexo.AutoSize = true;
            this.lbSexo.Location = new System.Drawing.Point(344, 134);
            this.lbSexo.Name = "lbSexo";
            this.lbSexo.Size = new System.Drawing.Size(31, 13);
            this.lbSexo.TabIndex = 20;
            this.lbSexo.Text = "Sexo";
            // 
            // lbTipoCliente
            // 
            this.lbTipoCliente.AutoSize = true;
            this.lbTipoCliente.Location = new System.Drawing.Point(341, 219);
            this.lbTipoCliente.Name = "lbTipoCliente";
            this.lbTipoCliente.Size = new System.Drawing.Size(78, 13);
            this.lbTipoCliente.TabIndex = 21;
            this.lbTipoCliente.Text = "Tipo de Cliente";
            // 
            // lbMontoMaximoaAutorizar
            // 
            this.lbMontoMaximoaAutorizar.AutoSize = true;
            this.lbMontoMaximoaAutorizar.Location = new System.Drawing.Point(341, 190);
            this.lbMontoMaximoaAutorizar.Name = "lbMontoMaximoaAutorizar";
            this.lbMontoMaximoaAutorizar.Size = new System.Drawing.Size(129, 13);
            this.lbMontoMaximoaAutorizar.TabIndex = 24;
            this.lbMontoMaximoaAutorizar.Text = "Monto Maximo a Autorizar";
            // 
            // txtMontoMaximoaAutorizar
            // 
            this.txtMontoMaximoaAutorizar.Location = new System.Drawing.Point(473, 190);
            this.txtMontoMaximoaAutorizar.Name = "txtMontoMaximoaAutorizar";
            this.txtMontoMaximoaAutorizar.Size = new System.Drawing.Size(156, 20);
            this.txtMontoMaximoaAutorizar.TabIndex = 25;
            // 
            // lbTituloMenu
            // 
            this.lbTituloMenu.AutoSize = true;
            this.lbTituloMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTituloMenu.Location = new System.Drawing.Point(30, 18);
            this.lbTituloMenu.Name = "lbTituloMenu";
            this.lbTituloMenu.Size = new System.Drawing.Size(116, 24);
            this.lbTituloMenu.TabIndex = 26;
            this.lbTituloMenu.Text = "Alta Cliente";
            // 
            // mkTxtFechaNacimiento
            // 
            this.mkTxtFechaNacimiento.Location = new System.Drawing.Point(145, 212);
            this.mkTxtFechaNacimiento.Mask = "00/00/0000";
            this.mkTxtFechaNacimiento.Name = "mkTxtFechaNacimiento";
            this.mkTxtFechaNacimiento.Size = new System.Drawing.Size(156, 20);
            this.mkTxtFechaNacimiento.TabIndex = 27;
            this.mkTxtFechaNacimiento.ValidatingType = typeof(System.DateTime);
            // 
            // cbTipodeCliente
            // 
            this.cbTipodeCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipodeCliente.FormattingEnabled = true;
            this.cbTipodeCliente.Location = new System.Drawing.Point(473, 219);
            this.cbTipodeCliente.Name = "cbTipodeCliente";
            this.cbTipodeCliente.Size = new System.Drawing.Size(156, 21);
            this.cbTipodeCliente.TabIndex = 28;
            // 
            // bGuardar
            // 
            this.bGuardar.Location = new System.Drawing.Point(501, 266);
            this.bGuardar.Name = "bGuardar";
            this.bGuardar.Size = new System.Drawing.Size(128, 49);
            this.bGuardar.TabIndex = 29;
            this.bGuardar.Text = "Guardar";
            this.bGuardar.UseVisualStyleBackColor = true;
            this.bGuardar.Click += new System.EventHandler(this.bGuardar_Click);
            // 
            // AltaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bGuardar);
            this.Controls.Add(this.cbTipodeCliente);
            this.Controls.Add(this.mkTxtFechaNacimiento);
            this.Controls.Add(this.lbTituloMenu);
            this.Controls.Add(this.txtMontoMaximoaAutorizar);
            this.Controls.Add(this.lbMontoMaximoaAutorizar);
            this.Controls.Add(this.lbTipoCliente);
            this.Controls.Add(this.lbSexo);
            this.Controls.Add(this.txtLocalidad);
            this.Controls.Add(this.lbLocalidad);
            this.Controls.Add(this.txtCodigoPostal);
            this.Controls.Add(this.lbCodigoPostal);
            this.Controls.Add(this.txtDomicilio);
            this.Controls.Add(this.lbDomicilio);
            this.Controls.Add(this.rbHombre);
            this.Controls.Add(this.rbMujer);
            this.Controls.Add(this.lbFechaNacimiento);
            this.Controls.Add(this.txtCelular);
            this.Controls.Add(this.lbCelular);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.lbCorreo);
            this.Controls.Add(this.txtNombreCompleto);
            this.Controls.Add(this.lbNombreCompleto);
            this.Controls.Add(this.txtDNI);
            this.Controls.Add(this.lbDNI);
            this.Controls.Add(this.cbTipoDocumento);
            this.Controls.Add(this.lbTipoDocumento);
            this.Name = "AltaCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AltaCliente";
            this.Load += new System.EventHandler(this.AltaCliente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTipoDocumento;
        private System.Windows.Forms.ComboBox cbTipoDocumento;
        private System.Windows.Forms.Label lbDNI;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.Label lbNombreCompleto;
        private System.Windows.Forms.TextBox txtNombreCompleto;
        private System.Windows.Forms.Label lbCorreo;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Label lbCelular;
        private System.Windows.Forms.TextBox txtCelular;
        private System.Windows.Forms.Label lbFechaNacimiento;
        private System.Windows.Forms.RadioButton rbMujer;
        private System.Windows.Forms.RadioButton rbHombre;
        private System.Windows.Forms.Label lbDomicilio;
        private System.Windows.Forms.TextBox txtDomicilio;
        private System.Windows.Forms.Label lbCodigoPostal;
        private System.Windows.Forms.TextBox txtCodigoPostal;
        private System.Windows.Forms.Label lbLocalidad;
        private System.Windows.Forms.TextBox txtLocalidad;
        private System.Windows.Forms.Label lbSexo;
        private System.Windows.Forms.Label lbTipoCliente;
        private System.Windows.Forms.Label lbMontoMaximoaAutorizar;
        private System.Windows.Forms.TextBox txtMontoMaximoaAutorizar;
        private System.Windows.Forms.Label lbTituloMenu;
        private System.Windows.Forms.MaskedTextBox mkTxtFechaNacimiento;
        private System.Windows.Forms.ComboBox cbTipodeCliente;
        private System.Windows.Forms.Button bGuardar;
    }
}