using Formularios.Interfaces;
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
    public partial class BienestarFinanciero : Form
    {
        IMenuPrincipal owner;
        private void ActualizardgvPrestamos()
        {
            if (owner != null)
            {
                this.dgvPrestamos.DataSource = owner.ObtenerPrestamo(null);
            }
        }
        public BienestarFinanciero()
        {
            InitializeComponent();
        }

        private void BienestarFinanciero_Load(object sender, EventArgs e)
        {
            owner = this.Owner as IMenuPrincipal;
            this.dgvPrestamos.AutoGenerateColumns = true;
            ActualizardgvPrestamos();

            if (owner != null)
            {
                txtMontoRecaudado.Text = $"$ {owner.ObtenerMontoTotalRecaudado()} ";
                txtMontoTotal.Text = $"$ {owner.ObtenerMontoTotalPrestado()}";
                txtPromedioTasa.Text = $"{owner.ObtenerPromedioTasas()}%";
            }
        }
    }
}
