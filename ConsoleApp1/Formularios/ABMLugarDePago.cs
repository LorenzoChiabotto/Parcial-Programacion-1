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
        public ABMLugarDePago()
        {
            InitializeComponent();
            HabilitarDeshabilitar(false);
        }

        private void ABMLugarDePago_Load(object sender, EventArgs e)
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
