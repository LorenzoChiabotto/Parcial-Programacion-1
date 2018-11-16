﻿using Formularios.Interfaces;
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

            lblComercio.Text = $"{prestamo.ComercioAdherido.Ciudad} - {prestamo.ComercioAdherido.Direccion}";
            lblCuotas.Text = $"{prestamo.CuotasPagas()} / {prestamo.CantidadCuotas}";
            lblFecha.Text = $"{prestamo.FechaCredito.ToShortDateString()}";
            lblMonto.Text = $"$ {prestamo.MontoCredito}";
            lblNroPrestamo.Text = $"{prestamo.NumCredito}";
            lblSucursal.Text = $"{prestamo.Sucursal.Ubicacion}";
            lblTasa.Text = $"{prestamo.Tasa}%";
            lbMontoCuota.Text = $"${prestamo.MontoCuota}";


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
            owner = this.Owner as IGrillaPrestamos;

            if(owner != null)
            {
                cbLugarPago.DataSource = owner.ObtenerLugaresDePago();
                cbLugarPago.DisplayMember = "RazonSocial";

                CargarDetallePrestamo();

                lblNombre.Text = $"{prestamo.Cliente.NombreCompleto}";
                lblNroDoc.Text = $"{prestamo.Cliente.Documento}";
                lblTipoDoc.Text = $"{prestamo.Cliente.TipoDoc.ToString()}";

            }
        }

        private void btRealizarPago_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(cbLugarPago.Text)) { 
                if(owner != null)
                {
                    Resultado resultado = owner.ActualizarPagos(prestamo,cbLugarPago.SelectedItem as LugarDePago);

                    if (resultado.FueCorrecto)
                    {
                        CargarDetallePrestamo();
                        MessageBox.Show("Pago Realizado con éxito");
                    }
                }
            }
        }

        private void cbLugarPago_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
