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
    public partial class GrillaPrestamos : Form

    {
        
        public GrillaPrestamos()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btNuevo_Click(object sender, EventArgs e)
        {
            AltaPrestamo formNuevoPrestamo = new AltaPrestamo(null);
            formNuevoPrestamo.Owner = this;
            formNuevoPrestamo.ShowDialog();
        }

        private void GrillaPrestamos_Load(object sender, EventArgs e)
        {

        }

    }
}
