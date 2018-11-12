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
    public partial class ABMSucursal : Form
    {
        IMenuPrincipal owner;
        bool modificacion = false;
        Sucursal sucursal;

        public void HabilitarDeshabilitar(bool EstaActivo)
        {
            txtCiudad.Enabled = EstaActivo;
            txtCodigoPostal.Enabled = EstaActivo;
            txtDireccion.Enabled = EstaActivo;
            txtTasa.Enabled = EstaActivo;
            lbCiudad.Enabled = EstaActivo;
            lbCodPostal.Enabled = EstaActivo;
            lbDireccion.Enabled = EstaActivo;
            lbTasaDeInteres.Enabled = EstaActivo;
            btGuardar.Enabled = EstaActivo;
            btCancelar.Enabled = EstaActivo;
        }
        private void ActualizardgvSucursales()
        {
            if (owner != null)
            {
                this.dgvSucursal.DataSource = owner.ObtenerSucursal(null);
            }
        }

        public ABMSucursal()
        {
            InitializeComponent();
        }

        private void ABMSucursal_Load(object sender, EventArgs e)
        {
            dgvSucursal.AutoGenerateColumns = true;
            owner = this.Owner as IMenuPrincipal;
            ActualizardgvSucursales();
            HabilitarDeshabilitar(false);
        }

        private void btAgregarNuevo_Click(object sender, EventArgs e)
        {
            modificacion = false;
            HabilitarDeshabilitar(true);
            dgvSucursal.Enabled = false;
            sucursal = new Sucursal();           
        }
        private void btModificar_Click(object sender, EventArgs e)
        {
            if(dgvSucursal.SelectedRows.Count == 1)
            {
                modificacion = true;
                HabilitarDeshabilitar(true);
                dgvSucursal.Enabled = false;
                sucursal = dgvSucursal.SelectedRows[0].DataBoundItem as Sucursal;

                txtCiudad.Text = sucursal.Ciudad;
                txtCodigoPostal.Text = sucursal.CodPostal.ToString();
                txtDireccion.Text = sucursal.Direccion;
                txtTasa.Text = sucursal.TasaInteres.ToString();

            }
        }
        private void btEliminar_Click(object sender, EventArgs e)
        {
            if (dgvSucursal.SelectedRows.Count == 1)
            {
                var result = MessageBox.Show("Seguro que desea eliminar esta Sucursal?", "CUIDADO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    if (owner != null)
                    {
                        owner.ModificacionEliminacionSucursal(dgvSucursal.SelectedRows[0].DataBoundItem as Sucursal, false);
                        ActualizardgvSucursales();
                    }
                }
            }
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            sucursal = null;
            modificacion = false;
            HabilitarDeshabilitar(false);
            dgvSucursal.Enabled = true;

            txtCiudad.Text = "";
            txtCodigoPostal.Text = "";
            txtDireccion.Text = "";
            txtTasa.Text = "";
        }
        private void btGuardar_Click(object sender, EventArgs e)
        {
            Resultado resultado;

            sucursal.Ciudad = txtCiudad.Text;
            sucursal.CodPostal = int.Parse(txtCodigoPostal.Text);
            sucursal.Direccion = txtDireccion.Text;
            sucursal.TasaInteres = float.Parse(txtTasa.Text);
            if(owner != null)
            {
                if (modificacion)
                {
                    resultado = owner.ModificacionEliminacionSucursal(sucursal,true);
                }
                else
                {
                    resultado = owner.NuevaSucursal(sucursal);
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
                ActualizardgvSucursales();
                HabilitarDeshabilitar(false);
                dgvSucursal.Enabled = true;

                txtCiudad.Text = "";
                txtCodigoPostal.Text = "";
                txtDireccion.Text = "";
                txtTasa.Text = "";

                MessageBox.Show("La Operacion se realizo con exito");
            }
            else
            {

            }
        }

        private void txt_CPKeyPress(object sender, KeyPressEventArgs e)
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

        private void txtTasa_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txt_SucursalKeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space))
            {

                e.Handled = true;
                return;
            }
        }
    }
}
