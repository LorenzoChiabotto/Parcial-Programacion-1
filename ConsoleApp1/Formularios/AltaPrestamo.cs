using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Formularios.Interfaces;
using Logica;
using System.Globalization;

namespace Formularios
{
    public partial class AltaPrestamo : Form
    {

        IMenuPrincipal owner;
        Cliente cliente;
        Sucursal sucursal;
        Comercio comercio;
        float monto;
      
        public AltaPrestamo(Cliente cl)
        {
            InitializeComponent();
            cliente = cl;
        }

        private void AltaPrestamo_Load(object sender, EventArgs e)
        {
            monto = 0;
            owner = this.Owner as IMenuPrincipal;

            txtFechaCredito.Text = DateTime.Now.ToString("dd/MM/yyyy");
            txtFechaCredito.Enabled = false;
            if (owner != null)
            {
                cbComercio.DataSource = owner.ObtenerComercio(null);
                cbComercio.DisplayMember = "RazonSocial";
                cbSucursal.DataSource = owner.ObtenerSucursal(null);
                cbSucursal.DisplayMember = "Ubicacion";

                foreach (var item in Enum.GetValues(typeof(TipoDocumento)))
                {
                    cbTipoDocumento.Items.Add(item);
                }
            }

            if (cliente != null)
            {
                cbTipoDocumento.SelectedItem = cliente.TipoDoc;
                txtDocumento.Text = cliente.Documento.ToString();
            }
        }

        private void btGuardar_Click(object sender, EventArgs e)
        {
            Resultado resultado;
            Prestamo prestamo = new Prestamo(cliente, comercio, sucursal, float.Parse(txtMontoCredito.Text), sucursal.TasaInteres, int.Parse(txtCuotas.Text));

            if (owner != null)
            {
                resultado = owner.NuevoPrestamo(prestamo);
            }
            else
            {
                resultado = new Resultado();
                resultado.FueCorrecto = false;
                resultado.listaMsjs.Add("Error inesperado");
            }

            if (resultado.FueCorrecto)
            {
                MessageBox.Show("La Operacion se realizo con exito");
                this.Close();
            }
            else
            {

            }
        }
        private int VerificarCampos()
        {
            //0 No hay Campos vacios
            //1 Tipo Documento vacio
            //2 Número DNI Vacio
            //3 Comercio Vacio
            //4 Sucursal Vacio
            //5 Monto Credito Vaccio
            //6 Cuotas Vacio
            int Codigo;
            Codigo = 0;
            if (String.IsNullOrWhiteSpace(cbTipoDocumento.Text) ||
            string.IsNullOrWhiteSpace(txtDocumento.Text) ||
            string.IsNullOrWhiteSpace(cbComercio.Text) ||
            string.IsNullOrWhiteSpace(cbSucursal.Text) || 
            string.IsNullOrWhiteSpace(txtMontoCredito.Text) || 
            string.IsNullOrWhiteSpace(txtCuotas.Text))
            {
                if (String.IsNullOrWhiteSpace(cbTipoDocumento.Text))
                {
                    Codigo = 1;
                }
                else
                {
                    if (string.IsNullOrWhiteSpace(txtDocumento.Text))
                    {
                        Codigo = 2;
                    }
                    else
                    {
                        if (string.IsNullOrWhiteSpace(cbComercio.Text))
                        {
                            Codigo = 3;
                        }
                        else
                        {
                            if (string.IsNullOrWhiteSpace(txtMontoCredito.Text))
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
            return Codigo;
        }

        private void cbSucursal_SelectedIndexChanged(object sender, EventArgs e)
        {
            sucursal = cbSucursal.SelectedItem as Sucursal;

            lblValorTasa.Text = $"{sucursal.TasaInteres.ToString()}% - (${monto*(sucursal.TasaInteres/100)})";
        }

        private void cbComercio_SelectedIndexChanged(object sender, EventArgs e)
        {
            comercio = cbComercio.SelectedItem as Comercio;
        }

        private void txtMontoCredito_TextChanged(object sender, EventArgs e)
        {
            monto = float.Parse(txtMontoCredito.Text);
            if(sucursal != null)
            {
                lblValorTasa.Text = $"{sucursal.TasaInteres.ToString()}% - (${monto * (sucursal.TasaInteres / 100)})";
            }
        }

        private void txtDocumento_TextChanged(object sender, EventArgs e)
        {
            cliente = owner.ObtenerCliente(int.Parse(txtDocumento.Text), (TipoDocumento)cbTipoDocumento.SelectedItem).FirstOrDefault();
        }

        private void txtDNI_keypress(object sender, KeyPressEventArgs e)
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

        private void txt_MontoCreditoKeyPress(object sender, KeyPressEventArgs e)
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

        private void txt_MontoKeyPress(object sender, KeyPressEventArgs e)
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
    }
}
