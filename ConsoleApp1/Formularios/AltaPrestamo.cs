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
    public partial class AltaPrestamo : Form
    {
      
        public AltaPrestamo()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void AltaPrestamo_Load(object sender, EventArgs e)
        {
            txtFechaCredito.Text = DateTime.Now.ToString("dd/MM/yyyy");
            txtFechaCredito.Enabled = false;

        }

        private void btGuardar_Click(object sender, EventArgs e)
        {

          
        }
    }
}
