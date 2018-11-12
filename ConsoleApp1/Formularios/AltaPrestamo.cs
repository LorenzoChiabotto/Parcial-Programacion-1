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
            //validar
            Prestamo prestamo = new Prestamo(cliente, comercio, sucursal, float.Parse(txtMontoCredito.Text), sucursal.TasaInteres, int.Parse(txtCuotas.Text));
          
            if(owner != null)
            {
                owner.NuevoPrestamo(prestamo);
                this.Close();
            }
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
    }
}
