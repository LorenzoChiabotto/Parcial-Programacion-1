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
        Cliente cliente;
        IGrilla ownerGrilla;
        IMenuPrincipal ownerMenu;

        public AltaCliente(Cliente cl)
        {
            cliente = cl;
            InitializeComponent();
        }

        private void AltaCliente_Load(object sender, EventArgs e)
        {
            ownerGrilla = this.Owner as IGrilla;
            ownerMenu = this.Owner as IMenuPrincipal;

            if (cliente.Documento == 0)
            {
                // FILL CAMPOS CON DATOS DE CLIENTES
            }
        }

        private void bGuardar_Click(object sender, EventArgs e)
        {
            switch (ComprobarCampos())
            {
                case 0:

                    Resultado resultado = new Resultado();

                    // nuevoCliente.TipoDoc = cbTipoDocumento;
                    cliente.Documento = Convert.ToInt32(txtDNI.Text);

                    cliente.NombreCompleto = txtNombreCompleto.Text;
                    cliente.Email = txtCorreo.Text;
                    cliente.Celular = txtCelular.Text;
                    // nuevoCliente.Sexo = rbHombre;
                    cliente.Domicilio = txtDomicilio.Text;
                    cliente.CodPostal = int.Parse(txtCodigoPostal.Text);
                    cliente.Localidad = txtLocalidad.Text;
                    //nuevoCliente.FechaNacimiento = mkTxtFechaNacimiento.text
                    cliente.MontoMaximoAutorizar = int.Parse(txtMontoMaximoaAutorizar.Text);
                    //Falta el alta del tipo de cliente nuevoCliente.

                    if (ownerGrilla != null)
                    {
                        if(cliente.Documento != 0)
                        {
                            resultado = ownerGrilla.NuevoCliente(cliente);
                        }
                        else
                        {
                            resultado = ownerGrilla.ModificacionCliente(cliente,true);
                        }
                    }
                    else
                    {
                        if (ownerMenu != null)
                        {
                            {
                                resultado = ownerMenu.NuevoCliente(cliente);
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
    }
}
