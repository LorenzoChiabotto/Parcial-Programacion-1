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
        private void armarGrilla()
        {
            this.dgvLugares.AutoGenerateColumns = false;
            this.dgvLugares.ColumnCount = 4;

            this.dgvLugares.Columns[0].HeaderText = "Razon Social";
            this.dgvLugares.Columns[0].DataPropertyName = "RazonSocial";

            this.dgvLugares.Columns[1].HeaderText = "Codigo Postal";
            this.dgvLugares.Columns[1].DataPropertyName = "CodPostal";

            this.dgvLugares.Columns[2].HeaderText = "Direccion";
            this.dgvLugares.Columns[2].DataPropertyName = "Direccion";

            this.dgvLugares.Columns[3].HeaderText = "Ciudad";
            this.dgvLugares.Columns[3].DataPropertyName = "Ciudad";
        }

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
            armarGrilla();
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
            Resultado resultado;
            if (string.IsNullOrWhiteSpace(txtCiudad.Text) ||
                string.IsNullOrWhiteSpace(txtCodigoPostal.Text) ||
                string.IsNullOrWhiteSpace(txtDireccion.Text) ||
                string.IsNullOrWhiteSpace(txtRazonSocial.Text))
            {
                MessageBox.Show("Complete todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                lugar.Ciudad = txtCiudad.Text;
                lugar.CodPostal = int.Parse(txtCodigoPostal.Text);
                lugar.Direccion = txtDireccion.Text;
                lugar.RazonSocial = txtRazonSocial.Text;
                lugar.EsSucursal = cbSucursal.Checked;

                if (owner != null)
                {
                    if (modificacion)
                    {
                        resultado = owner.ModificacionEliminacionLugarPago(lugar, true);
                    }
                    else
                    {
                        resultado = owner.NuevoLugarPago(lugar);
                    }
                }
                else
                {
                    resultado = new Resultado();
                    resultado.FueCorrecto = false;
                    resultado.listaMsjs.Add("error inesperado");
                }

                if (resultado.FueCorrecto)
                {
                    ActualizardgvLugares();
                    HabilitarDeshabilitar(false);
                    dgvLugares.Enabled = true;

                    txtCiudad.Text = "";
                    txtCodigoPostal.Text = "";
                    txtDireccion.Text = "";
                    txtRazonSocial.Text = "";
                    cbSucursal.Checked = false;

                    MessageBox.Show("La Operacion se realizo con exito");
                }
                else
                {
                    string msg = "No se a podido guardar el Lugar de Pago: \n";
                    foreach (string item in resultado.listaMsjs)
                    {
                        msg += $"      -{item}\n";
                    }
                    MessageBox.Show(msg, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
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

        private void txtCiudad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space))
            {

                e.Handled = true;
                return;
            }
        }

        private void txtRazonSocial_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space))
            {

                e.Handled = true;
                return;
            }
        }

        private void txtCodigoPostal_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_CP_KeyPress(object sender, KeyPressEventArgs e)
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
    }
}
