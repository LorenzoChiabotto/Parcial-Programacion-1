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
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void altaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form NuevoCLiente = new AltaCliente();
            NuevoCLiente.Owner = this;
            NuevoCLiente.ShowDialog();
            
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void listadoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void nuevoPrestamoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form NuevoPrestamo = new AltaPrestamo();
            NuevoPrestamo.Owner = this;
            NuevoPrestamo.ShowDialog();

           
        }

        private void sucursalesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form NuevaSucursal = new ABMSucursal();
            NuevaSucursal.Owner = this;
            NuevaSucursal.ShowDialog();
        }

        private void comercioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form Comercio = new ABMComercioAdherido();
            Comercio.Owner = this;
            Comercio.ShowDialog();
        }

        private void lugaresDePagoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form LugarDePago = new ABMLugarDePago();
            LugarDePago.Owner = this;
            LugarDePago.ShowDialog();
        }
    }
}
