﻿using Formularios.Interfaces;
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
    public partial class ABMComercioAdherido : Form
    {
        IMenuPrincipal owner;
        bool modificacion = false;
        Comercio comercio;

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
        }
        private void ActualizardgvComercios()
        {
            if (owner != null)
            {
                this.dgvComercio.DataSource = owner.ObtenerComercio(null);
            }
        }

        public ABMComercioAdherido()
        {
            InitializeComponent();
        }

        private void ABMComercioAdherido_Load(object sender, EventArgs e)
        {
            dgvComercio.AutoGenerateColumns = true;
            owner = this.Owner as IMenuPrincipal;
            ActualizardgvComercios();
            HabilitarDeshabilitar(false);
        }


        private void btAgregarNuevo_Click(object sender, EventArgs e)
        {
            modificacion = false;
            comercio = new Comercio();

            dgvComercio.Enabled = false;
            HabilitarDeshabilitar(true);
        }
        private void btModificar_Click(object sender, EventArgs e)
        {
            if (dgvComercio.SelectedRows.Count == 1)
            {
                modificacion = true;
                HabilitarDeshabilitar(true);
                dgvComercio.Enabled = false;
                comercio = dgvComercio.SelectedRows[0].DataBoundItem as Comercio;

                txtCiudad.Text = comercio.Ciudad;
                txtCodigoPostal.Text = comercio.CodPostal.ToString();
                txtDireccion.Text = comercio.Direccion;
                txtRazonSocial.Text = comercio.RazonSocial;

            }
        }
        private void btEliminar_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Seguro que desea eliminar este Comercio?", "CUIDADO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (owner != null)
                {
                    owner.ModificacionEliminacionComercio(dgvComercio.SelectedRows[0].DataBoundItem as Comercio, false);
                    ActualizardgvComercios();
                }
            }
        }

        private void btGuardar_Click(object sender, EventArgs e)
        {
            if (true)
            {
                comercio.Ciudad = txtCiudad.Text;
                comercio.CodPostal = int.Parse(txtCodigoPostal.Text);
                comercio.Direccion = txtDireccion.Text;
                comercio.RazonSocial = txtRazonSocial.Text;

                if (modificacion)
                {
                    owner.ModificacionEliminacionComercio(comercio, true);
                }
                else
                {
                    owner.NuevoComercio(comercio);
                }

                ActualizardgvComercios();
                HabilitarDeshabilitar(false);
                dgvComercio.Enabled = true;

                txtCiudad.Text = "";
                txtCodigoPostal.Text = "";
                txtDireccion.Text = "";
                txtRazonSocial.Text = "";
            }
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            comercio = null;
            modificacion = false;
            HabilitarDeshabilitar(false);
            dgvComercio.Enabled = true;

            txtCiudad.Text = "";
            txtCodigoPostal.Text = "";
            txtDireccion.Text = "";
            txtRazonSocial.Text = "";
        }

        private void txtCP_keypress(object sender, KeyPressEventArgs e)
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

        private void txt_Ciudad_KeyPress(object sender, KeyPressEventArgs e)
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
    }
}
