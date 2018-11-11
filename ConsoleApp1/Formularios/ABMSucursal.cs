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
        public ABMSucursal()
        {
            InitializeComponent();
        }

        private void ABMSucursal_Load(object sender, EventArgs e)
        {
            HabilitarDeshabilitar(false);
        }

        private void btAgregarNuevo_Click(object sender, EventArgs e)
        {
            HabilitarDeshabilitar(true);
            dgvSucursal.Enabled = false;
           
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            HabilitarDeshabilitar(false);
            dgvSucursal.Enabled = true;
        }
        public void HabilitarDeshabilitar(bool EstaActivo)
        {
            txtCiudad.Enabled = EstaActivo;
            txtCodigoPostal.Enabled = EstaActivo;
            txtDireccion.Enabled = EstaActivo;
            txtLocalidad.Enabled = EstaActivo;
            lbCiudad.Enabled = EstaActivo;
            lbCodPostal.Enabled = EstaActivo;
            lbDireccion.Enabled = EstaActivo;
            lbTasaDeInteres.Enabled = EstaActivo;
            btGuardar.Enabled = EstaActivo;
            btCancelar.Enabled = EstaActivo;
        }

        private void btGuardar_Click(object sender, EventArgs e)
        {
            HabilitarDeshabilitar(false);
            dgvSucursal.Enabled = true;
        }

        private void btModificar_Click(object sender, EventArgs e)
        {

        }
    }
}
