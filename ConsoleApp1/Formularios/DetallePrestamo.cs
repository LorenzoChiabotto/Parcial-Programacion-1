using Formularios.Interfaces;
using Logica;
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
    public partial class DetallePrestamo : Form
    {
        Prestamo prestamo;
        IGrillaPrestamos owner;


        private void armarGrilla()
        {
            this.dgvPagos.AutoGenerateColumns = false;
            this.dgvPagos.ColumnCount = 4;

            this.dgvPagos.Columns[0].HeaderText = "Nro";
            this.dgvPagos.Columns[0].DataPropertyName = "Numero";

            this.dgvPagos.Columns[1].HeaderText = "Fecha";
            this.dgvPagos.Columns[1].DataPropertyName = "FechaCobro";


            this.dgvPagos.Columns[2].HeaderText = "Estado";
            this.dgvPagos.Columns[2].DataPropertyName = "Estado";

            this.dgvPagos.Columns[3].HeaderText = "Lugar de Pago";
            this.dgvPagos.Columns[3].DataPropertyName = "Lugar";

        }

        private void ActualizardgvPagos()
        {
            if (prestamo != null)
            {
                this.dgvPagos.DataSource = prestamo.ListaPagos;
                this.dgvPagos.Refresh();
            }
        }

        public void HabilitarDeshabilitar(bool EstaActivo)
        {
            cbLugarPago.Enabled = EstaActivo;
            btRealizarPago.Enabled = EstaActivo;
        }
        public void CargarDetallePrestamo()
        {
            if (!prestamo.Completado())
            {
                HabilitarDeshabilitar(true);
            }
            else
            {
                HabilitarDeshabilitar(false);
            }

            lblComercio.Text = $"{prestamo.ComercioAdherido.RazonSocial} ({prestamo.ComercioAdherido.Ubicacion})";
            lblCuotas.Text = $"{prestamo.CuotasPagas()} / {prestamo.CantidadCuotas}";
            lblFecha.Text = $"{prestamo.FechaCredito.ToShortDateString()}";
            lblMonto.Text = $"$ {prestamo.MontoCredito}";
            lblNroPrestamo.Text = $"{prestamo.NumCredito}";
            lblSucursal.Text = $"{prestamo.Sucursal.Ubicacion}";
            lblTasa.Text = $"{prestamo.Tasa}% (${prestamo.MontoInteres})";
            lbMontoCuota.Text = $"${prestamo.MontoCuota}";
            lblPagado.Text = $"${prestamo.TotalPagado}";

            if (!prestamo.Completado())
            {
                lblFechaPago.Text = prestamo.ListaPagos.Where(x => !x.Pagado).OrderBy(x => x.FechaCobro).FirstOrDefault().FechaCobro.ToShortDateString();
            }
        }

        public DetallePrestamo(Prestamo pr)
        {
            InitializeComponent();

            prestamo = pr;
        }

        private void DetallePrestamo_Load(object sender, EventArgs e)
        {
            armarGrilla();
            owner = this.Owner as IGrillaPrestamos;

            if(owner != null)
            {
                cbLugarPago.DataSource = owner.ObtenerLugaresDePago();
                cbLugarPago.DisplayMember = "RazonSocial";

                CargarDetallePrestamo();

                lblNombre.Text = $"{prestamo.Cliente.NombreCompleto}";
                lblNroDoc.Text = $"{prestamo.Cliente.Documento}";
                lblTipoDoc.Text = $"{prestamo.Cliente.TipoDoc.ToString()}";

                ActualizardgvPagos();
            }
        }

        private void btRealizarPago_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(cbLugarPago.Text)) { 
                if(owner != null)
                {
                    var result = MessageBox.Show($"Seguro que cargar un pago en {((LugarDePago)cbLugarPago.SelectedItem).RazonSocial}?"
                                                    , "CUIDADO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        Resultado resultado = owner.ActualizarPagos(prestamo, cbLugarPago.SelectedItem as LugarDePago);

                        if (resultado.FueCorrecto)
                        {
                            CargarDetallePrestamo();
                            MessageBox.Show("Pago Realizado con éxito");
                            ActualizardgvPagos();
                            lblPagado.Text = $"${prestamo.TotalPagado}";
                        }
                    }
                }
            }
        }

        private void cbLugarPago_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
