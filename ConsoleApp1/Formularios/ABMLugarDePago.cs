using Formularios.Interfaces;
using Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formularios
{
    public partial class ABMLugarDePago : Form
    {
        IMenuPrincipal owner;
        bool modificacion = false;
        LugarDePago lugar;

        public void HabilitarDeshabilitar(bool EstaActivo)
        {
            txtCiudad.Enabled = EstaActivo;
            txtCodigoPostal.Enabled = EstaActivo;
            txtDireccion.Enabled = EstaActivo;
            txtRazonSocial.Enabled = EstaActivo;
            lbCiudad.Enabled = EstaActivo;
            lbCodPostal.Enabled = EstaActivo;
            lbDireccion.Enabled = EstaActivo;
            lbRazonSocial.Enabled = EstaActivo;
            btGuardar.Enabled = EstaActivo;
            btCancelar.Enabled = EstaActivo;
            cbSucursal.Enabled = EstaActivo;
        }
        private void ActualizardgvLugares()
        {
            if (owner != null)
            {
                this.dgvLugares.DataSource = owner.ObtenerLugarDePago(null);
            }
        }

        public ABMLugarDePago()
        {
            InitializeComponent();
            HabilitarDeshabilitar(false);
        }

        private void ABMLugarDePago_Load(object sender, EventArgs e)
        {
            dgvLugares.AutoGenerateColumns = true;
            owner = this.Owner as IMenuPrincipal;
            ActualizardgvLugares();
            HabilitarDeshabilitar(false);
        }

        private void btAgregarNuevo_Click(object sender, EventArgs e)
        {
            modificacion = false;
            HabilitarDeshabilitar(true);
            dgvLugares.Enabled = false;
            lugar = new LugarDePago();
        }
        private void btModificar_Click(object sender, EventArgs e)
        {
            if (dgvLugares.SelectedRows.Count == 1)
            {
                modificacion = true;
                HabilitarDeshabilitar(true);
                dgvLugares.Enabled = false;
                lugar = dgvLugares.SelectedRows[0].DataBoundItem as LugarDePago;

                txtCiudad.Text = lugar.Ciudad;
                txtCodigoPostal.Text = lugar.CodPostal.ToString();
                txtDireccion.Text = lugar.Direccion;
                txtRazonSocial.Text = lugar.RazonSocial;

                cbSucursal.Checked = lugar.EsSucursal;

            }
        }
        private void btEliminar_Click(object sender, EventArgs e)
        {
            if (dgvLugares.SelectedRows.Count == 1)
            {
                var result = MessageBox.Show("Seguro que desea eliminar este Lugar de Pago?", "CUIDADO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    if (owner != null)
                    {
                        owner.ModificacionEliminacionLugarPago(dgvLugares.SelectedRows[0].DataBoundItem as LugarDePago, false);
                        ActualizardgvLugares();
                    }
                }
            }
        }

        private void btGuardar_Click(object sender, EventArgs e)
        {
            if (true)
            {
                lugar.Ciudad = txtCiudad.Text;
                lugar.CodPostal = int.Parse(txtCodigoPostal.Text);
                lugar.Direccion = txtDireccion.Text;
                lugar.RazonSocial = txtRazonSocial.Text;
                lugar.EsSucursal = cbSucursal.Checked;

                if (modificacion)
                {
                    owner.ModificacionEliminacionLugarPago(lugar, true);
                }
                else
                {
                    owner.NuevoLugarPago(lugar);
                }

                ActualizardgvLugares();
                HabilitarDeshabilitar(false);
                dgvLugares.Enabled = true;

                txtCiudad.Text = "";
                txtCodigoPostal.Text = "";
                txtDireccion.Text = "";
                txtRazonSocial.Text = "";
                cbSucursal.Checked = false;
            }
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            lugar = null;
            modificacion = false;
            HabilitarDeshabilitar(false);
            dgvLugares.Enabled = true;

            txtCiudad.Text = "";
            txtCodigoPostal.Text = "";
            txtDireccion.Text = "";
            txtRazonSocial.Text = "";
            cbSucursal.Checked = false;
        }

        
    }
}
