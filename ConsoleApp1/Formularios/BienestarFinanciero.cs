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

        private void armarGrilla()
        {
            this.dgvPrestamos.AutoGenerateColumns = false;
            this.dgvPrestamos.ColumnCount = 11;

            this.dgvPrestamos.Columns[0].HeaderText = "N° Credito";
            this.dgvPrestamos.Columns[0].DataPropertyName = "NumCredito";

            this.dgvPrestamos.Columns[1].HeaderText = "Fecha";
            this.dgvPrestamos.Columns[1].DataPropertyName = "FechaCredito";

            this.dgvPrestamos.Columns[2].HeaderText = "Cliente";
            this.dgvPrestamos.Columns[2].DataPropertyName = "NombCliente";

            this.dgvPrestamos.Columns[3].HeaderText = "ComercioAdherido";
            this.dgvPrestamos.Columns[3].DataPropertyName = "UbicComercio";

            this.dgvPrestamos.Columns[4].HeaderText = "Sucursal";
            this.dgvPrestamos.Columns[4].DataPropertyName = "UbicSucursal";

            this.dgvPrestamos.Columns[5].HeaderText = "Monto";
            this.dgvPrestamos.Columns[5].DataPropertyName = "MontoCredito";

            this.dgvPrestamos.Columns[6].HeaderText = "Tasa (%)";
            this.dgvPrestamos.Columns[6].DataPropertyName = "Tasa";

            this.dgvPrestamos.Columns[7].HeaderText = "Tasa ($)";
            this.dgvPrestamos.Columns[7].DataPropertyName = "MontoInteres";

            this.dgvPrestamos.Columns[8].HeaderText = "CantCuotas";
            this.dgvPrestamos.Columns[8].DataPropertyName = "CantidadCuotas";

            this.dgvPrestamos.Columns[9].HeaderText = "Monto Cuotas";
            this.dgvPrestamos.Columns[9].DataPropertyName = "MontoCuota";

            this.dgvPrestamos.Columns[10].HeaderText = "TotalRecaudado";
            this.dgvPrestamos.Columns[10].DataPropertyName = "TotalPagado";
        }
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
                armarGrilla();
            owner = this.Owner as IMenuPrincipal;
            this.dgvPrestamos.AutoGenerateColumns = false;
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
