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
using Formularios.Interfaces;
namespace Formularios
{
    public partial class AltaCliente : Form
    {
        public AltaCliente()
        {
            InitializeComponent();
            
        }

        private void lbTipoDocumento_Click(object sender, EventArgs e)
        {

        }

        private void AltaCliente_Load(object sender, EventArgs e)
        {

        }

        private void bGuardar_Click(object sender, EventArgs e)
        {
            switch (ComprobarCampos())
            {
                case 0:

                    Resultado resultado = new Resultado();
                    Cliente nuevoCliente = new Cliente();

                    // nuevoCliente.TipoDoc = cbTipoDocumento;
                    nuevoCliente.Documento = Convert.ToInt32(txtDNI.Text);

                    nuevoCliente.NombreCompleto = txtNombreCompleto.Text;
                    nuevoCliente.Email = txtCorreo.Text;
                    nuevoCliente.Celular = txtCelular.Text;
                    // nuevoCliente.Sexo = rbHombre;
                    nuevoCliente.Domicilio = txtDomicilio.Text;
                    nuevoCliente.CodPostal = int.Parse(txtCodigoPostal.Text);
                    nuevoCliente.Localidad = txtLocalidad.Text;
                    //nuevoCliente.FechaNacimiento = mkTxtFechaNacimiento.text
                    nuevoCliente.MontoMaximoAutorizar = int.Parse(txtMontoMaximoaAutorizar.Text);
                    //Falta el alta del tipo de cliente nuevoCliente.

                    IMenuPrincipal formPrincipal = this.Owner as IMenuPrincipal;
                    if (formPrincipal != null)
                    {
                        resultado = formPrincipal.NuevoCliente(nuevoCliente);
                    }
                    else
                    {
                        IGrilla formGrilla = this.Owner as IGrilla;
                        if (formGrilla != null)
                        {
                            {
                                resultado = formGrilla.NuevoCliente(nuevoCliente);
                            }
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
            }
        }
        private void txtCorreo_TextChanged(object sender, EventArgs e)
        {

        }

        private int ComprobarCampos()
        {
            //0 No hay Campos vacios
            //1 Tipo Documento vacio
            //2 Número DNI Vacio
            //3 Email Vacio
            //4 Tipo de cliente vacio
            //5 Monto Maximo Vacio
            int Comprobar;
            Comprobar = 0;
                if (String.IsNullOrWhiteSpace(cbTipoDocumento.Text) || 
                string.IsNullOrWhiteSpace(txtDNI.Text) || 
                string.IsNullOrWhiteSpace(txtCorreo.Text) || 
                string.IsNullOrWhiteSpace(cbTipodeCliente.Text) || string.IsNullOrWhiteSpace(txtMontoMaximoaAutorizar.Text))
                {
                if (String.IsNullOrWhiteSpace(cbTipoDocumento.Text))
                {
                    Comprobar = 1;
                }
                else
                {
                    if (string.IsNullOrWhiteSpace(txtDNI.Text))
                    {
                        Comprobar = 2;
                    }
                    else
                    {
                        if (string.IsNullOrWhiteSpace(txtCorreo.Text))
                        {
                            Comprobar = 3;
                        }
                        else
                        {
                            if (string.IsNullOrWhiteSpace(cbTipodeCliente.Text))
                            {
                                Comprobar = 4;
                            }
                            else
                            {
                                Comprobar = 5;

                            }
                        }
                    }
                }

                }


         
            return Comprobar;
        }

        private void cbTipoDocumento_SelectedIndexChanged(object sender, EventArgs e)
        {
      

        }

        private void cbTipodeCliente_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
