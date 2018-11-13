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
    public partial class GrillaPrestamos : Form,IGrillaPrestamos
    {
        IMenuPrincipal owner;
        Prestamo prestamo;
        private void armarGrilla()
        {
            this.dgvPrestamos.AutoGenerateColumns = false;
            this.dgvPrestamos.ColumnCount = 10;

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
        }
        private void ActualizardgvPrestamos()
        {
            if (owner != null)
            {
                this.dgvPrestamos.DataSource = owner.ObtenerPrestamo(null);
            }
        }

        public GrillaPrestamos()
        {
            InitializeComponent();
        }

        private void GrillaPrestamos_Load(object sender, EventArgs e)
        {
            owner = this.Owner as IMenuPrincipal;
            prestamo = null;
            armarGrilla();
            ActualizardgvPrestamos();
        }

        private void btDetalle_Click(object sender, EventArgs e)
        {
            if(dgvPrestamos.SelectedRows.Count == 1)
            {
                prestamo = dgvPrestamos.SelectedRows[0].DataBoundItem as Prestamo;
                Form detalle = new DetallePrestamo(prestamo);
                detalle.Owner = this;
                detalle.ShowDialog();
            }
        }

        private void btFiltrar_Click(object sender, EventArgs e)
        {
            DateTime desde, hasta;

            if (owner != null)
            {
                DateTime.TryParse(this.mskDesde.Text, out desde);
                if (desde == null)
                {
                    desde = new DateTime(0001, 01, 01);
                }
                DateTime.TryParse(this.mskHasta.Text, out hasta);
                if (hasta == DateTime.MinValue)
                {
                    hasta = new DateTime(9999, 12, 31);
                }
                if (rbTodos.Checked)
                {
                    this.dgvPrestamos.DataSource = owner.ObtenerPrestamo(desde,hasta,txtNombre.Text,null);
                }
                else
                {
                    this.dgvPrestamos.DataSource = owner.ObtenerPrestamo(desde, hasta, txtNombre.Text, rbVip.Checked?true:false);
                }
            }
        }
        

        public Resultado ActualizarPagos(Prestamo prestamo,LugarDePago lugar)
        {
            return owner.ActualizarPagos(prestamo,lugar);
        }

        public List<LugarDePago> ObtenerLugaresDePago()
        {
            return owner.ObtenerLugarDePago(null);
        }

        private void txt_Documento_KeyPress(object sender, KeyPressEventArgs e)
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

    }
}
