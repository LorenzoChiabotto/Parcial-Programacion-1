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
        public ABMComercioAdherido()
        {
            InitializeComponent();
            HabilitarDeshabilitar(false);
        }

        private void btAgregarNuevo_Click(object sender, EventArgs e)
        {
            dgvComercio.Enabled = true;
            HabilitarDeshabilitar(true);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ABMComercioAdherido_Load(object sender, EventArgs e)
        {
            
            
            
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
            lbRazonSocial.Enabled = EstaActivo;
            btGuardar.Enabled = EstaActivo;
            btCancelar.Enabled = EstaActivo;
        }

    }
}
