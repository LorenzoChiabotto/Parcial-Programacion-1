using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logica;
using System.Text.RegularExpressions;
using Formularios.Interfaces;
using System.Globalization;
namespace Formularios
{
    public partial class AltaCliente : Form
    {
        Cliente cliente;
        IGrillaCliente ownerGrilla;
        IMenuPrincipal ownerMenu;
        public bool Modifica { get; set; }

        public AltaCliente()
        {

        }
        public AltaCliente(Cliente cl)
        {
            cliente = cl;
            Modifica = false;

            InitializeComponent();
        }
        public AltaCliente(Cliente pcliente, bool pModificacion)
        {
            cliente = pcliente;
            InitializeComponent();

            Modifica = true;
        }

        private void AltaCliente_Load(object sender, EventArgs e)
        {
            foreach (var item in Enum.GetValues(typeof(TipoDocumento)))
            {
                cbTipoDocumento.Items.Add(item);
            }
            ownerGrilla = this.Owner as IGrillaCliente;
            ownerMenu = this.Owner as IMenuPrincipal;

            if (Modifica)
            {
                cbTipoDocumento.SelectedItem = cliente.TipoDoc;

                txtDNI.Text = cliente.Documento.ToString();

                txtNombreCompleto.Text = cliente.NombreCompleto;
                txtCorreo.Text = cliente.Email;
                txtCelular.Text = cliente.Celular;
                // rbHombre = nuevoCliente.Sexo  ;
                txtDomicilio.Text = cliente.Domicilio;
                txtCodigoPostal.Text = cliente.CodPostal.ToString();
                txtLocalidad.Text = cliente.Localidad;
                mkTxtFechaNacimiento.Text = cliente.FechaNacimiento.ToShortDateString();
                txtMontoMaximoaAutorizar.Text = cliente.MontoMaximoAutorizar.ToString();

                cbTipodeCliente.SelectedItem = cliente.EsVip ? "VIP" : "Regular";
                if(cliente.Sexo == Sexo.MASCULINO)
                {
                    rbHombre.Checked = true;
                    rbMujer.Checked = false;
                }
                else {
                    rbHombre.Checked = false;
                    rbMujer.Checked = true;
                }

                //Falta el alta del tipo de cliente nuevoCliente.

            }

        }

        private void bGuardar_Click(object sender, EventArgs e)
        {
            
            switch (VerificarCampos())
            {
                case 0:
                    Resultado resultado = new Resultado();

                    cliente.TipoDoc = (TipoDocumento)cbTipoDocumento.SelectedItem;
                    cliente.Documento = Convert.ToInt32(txtDNI.Text);

                    cliente.NombreCompleto = txtNombreCompleto.Text;
                    cliente.Email = txtCorreo.Text;
                    cliente.Celular = txtCelular.Text;
                    cliente.Sexo = rbHombre.Checked ? Sexo.MASCULINO : Sexo.FEMENINO;
                    cliente.Domicilio = txtDomicilio.Text;
                    cliente.CodPostal = int.Parse(txtCodigoPostal.Text);
                    cliente.Localidad = txtLocalidad.Text;
                    cliente.FechaNacimiento = DateTime.Parse(this.mkTxtFechaNacimiento.Text);
                    cliente.MontoMaximoAutorizar = float.Parse(txtMontoMaximoaAutorizar.Text);
                    cliente.EsVip = cbTipodeCliente.SelectedItem.ToString() == "VIP" ? true : false;
                    //Falta el alta del tipo de cliente nuevoCliente.

                    if (ownerGrilla != null)
                    {
                        if(Modifica)
                        {
                            resultado = ownerGrilla.ModificacionCliente(cliente, true);
                            
                        }
                        else
                        {
                            resultado = ownerGrilla.NuevoCliente(cliente);
                        }
                    }
                    else
                    {
                        if (ownerMenu != null)
                        {

                            resultado = ownerMenu.NuevoCliente(cliente);
                        }

                    }
                    if (resultado.FueCorrecto )
                    {
                        MessageBox.Show("La Operacion se realizo con exito");
                        this.Close();
                    }
                    
                    break;

                case 1:
                    MessageBox.Show("Ingrese Tipo Documento");
                    break;
                case 2:
                    MessageBox.Show("Ingrese Número de Documento");
                    break;
                case 3:
                    MessageBox.Show("Ingrese Correo electrónico");
                    break;
                case 4:
                    MessageBox.Show("Ingrese Tipo de Cliente");
                    break;
                case 5:
                    MessageBox.Show("Ingrese Monto Máximo");
                    break;
                case 6:
                    MessageBox.Show("Formato incorrecto de Correo Electrónico");
                    break;
            }
        }

        private int VerificarCampos()
        {
            //0 No hay Campos vacios
            //1 Tipo Documento vacio
            //2 Número DNI Vacio
            //3 Email Vacio
            //4 Tipo de cliente vacio
            //5 Monto Maximo Vacio
            //6 Controlar formato Correo
            //7 Controlar Tipo y Nro DNI ya cargado
            int Codigo;
            Codigo = 0;
                if (String.IsNullOrWhiteSpace(cbTipoDocumento.Text) || 
                string.IsNullOrWhiteSpace(txtDNI.Text) || 
                string.IsNullOrWhiteSpace(txtCorreo.Text) || 
                string.IsNullOrWhiteSpace(cbTipodeCliente.Text) || string.IsNullOrWhiteSpace(txtMontoMaximoaAutorizar.Text))
                {
                    if (String.IsNullOrWhiteSpace(cbTipoDocumento.Text))
                    {
                        Codigo = 1;
                    }
                    else
                    {
                        if (string.IsNullOrWhiteSpace(txtDNI.Text))
                        {
                            Codigo = 2;
                        }
                        else
                        {
                            if (string.IsNullOrWhiteSpace(txtCorreo.Text))
                            {
                                Codigo = 3;
                            }
                            else
                            {
                                if (string.IsNullOrWhiteSpace(cbTipodeCliente.Text))
                                {
                                    Codigo = 4;
                                }
                                else
                                {
                                    Codigo = 5;

                                }
                            }
                        }
                    }

                }
                String Caracteres;
                Caracteres = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
                if (!Regex.IsMatch(txtCorreo.Text, Caracteres))
                {
                    if (!(Regex.Replace(txtCorreo.Text, Caracteres, String.Empty).Length == 0))
                    {
                        Codigo = 6;
                    }               
                }         
            return Codigo;
        }

        private void txt_NombreC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space))
            {
                
                e.Handled = true;
                return;
            }
        }

        private void txtNombreCompleto_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtLocalidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space))
            {

                e.Handled = true;
                return;
            }
        }

        private void txt_Celular_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
           if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {                
                e.Handled = true;
            }
        }

        private void txt_CodPostalKeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtMontoMaximoaAutorizar_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMonto_Maximo(object sender, KeyPressEventArgs e)
        {
        
             CultureInfo cc = System.Threading.Thread.CurrentThread.CurrentCulture;

             if (char.IsNumber(e.KeyChar) ||

                 (e.KeyChar.ToString() == cc.NumberFormat.NumberDecimalSeparator) || (Char.IsControl(e.KeyChar)))
                 e.Handled = false;

             else
             {

                 e.Handled = true;
             }

        }

        private void txtDNI_Keypressed(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void cbTipodeCliente_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
