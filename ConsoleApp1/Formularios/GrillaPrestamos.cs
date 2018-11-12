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
            this.dgvPrestamos.AutoGenerateColumns = true;
            ActualizardgvPrestamos();
        }

        private void btNuevo_Click(object sender, EventArgs e)
        {
            AltaPrestamo formNuevoPrestamo = new AltaPrestamo(null);
            formNuevoPrestamo.Owner = this;
            formNuevoPrestamo.ShowDialog();
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
