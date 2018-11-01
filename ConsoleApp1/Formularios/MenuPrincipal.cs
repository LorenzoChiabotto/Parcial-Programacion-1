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
    }
}
