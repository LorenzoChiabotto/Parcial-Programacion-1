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
    public partial class GrillaClientes : Form,IGrilla
    {
        public GrillaClientes()
        {
            InitializeComponent();


        }

        private void GrillaClientes_Load(object sender, EventArgs e)
        {
            IMenuPrincipal owner = this.Owner as IMenuPrincipal;
            this.dgvClientes.AutoGenerateColumns = true;
            if (owner != null)
            {
                dgvClientes.DataSource = owner.ObtenerCliente(null);
            }


        }
        private void ActualizardgvClientes()
        {
          IMenuPrincipal formCliente = this.Owner as IMenuPrincipal;

            if (formCliente != null)
            {
                this.dgvClientes.DataSource = formCliente.ObtenerCliente(null);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var column = this.dgvClientes.Columns[e.ColumnIndex];
            var row = this.dgvClientes.Rows[e.RowIndex];
        }
        public Resultado NuevoCliente(Cliente cliente)
        {

            Resultado resultado = new Resultado();
            IMenuPrincipal formPrincipal = this.Owner as IMenuPrincipal;
            if (formPrincipal != null)
            {
                resultado = formPrincipal.NuevoCliente(cliente);

                if (resultado.FueCorrecto)
                {
                    ActualizardgvClientes();
                }
            }
            return resultado;
        }

        public Resultado ModificacionCliente(Cliente cliente, bool pSeModifica)
        {
            Resultado resultado = new Resultado();
            IMenuPrincipal formPrincipal = this.Owner as IMenuPrincipal;
            if (formPrincipal != null)
            {
                resultado = formPrincipal.NuevoCliente(cliente);

                if (resultado.FueCorrecto)
                {
                    ActualizardgvClientes();
                }
            }
            return resultado;
        }

        private void btNuevo_Click(object sender, EventArgs e)
        {
            AltaCliente formNuevoCliente = new AltaCliente();
            formNuevoCliente.Owner = this;
            formNuevoCliente.ShowDialog();
        }
    }
}
