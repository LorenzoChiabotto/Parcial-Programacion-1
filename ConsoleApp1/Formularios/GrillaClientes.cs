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
        IMenuPrincipal owner;
        private void ActualizardgvClientes()
        {
            if (owner != null)
            {
                this.dgvClientes.DataSource = owner.ObtenerCliente(null);
            }
        }

        public GrillaClientes()
        {
            InitializeComponent();
        }

        private void GrillaClientes_Load(object sender, EventArgs e)
        {
            owner = this.Owner as IMenuPrincipal;
            
            this.dgvClientes.AutoGenerateColumns = true;
            ActualizardgvClientes();
        }
        
        public Resultado NuevoCliente(Cliente cliente)
        {

            Resultado resultado = new Resultado();
            if (owner != null)
            {
                resultado = owner.NuevoCliente(cliente);

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
            if (owner != null)
            {
                resultado = owner.ModificacionEliminacionCliente(cliente,pSeModifica);

                if (resultado.FueCorrecto)
                {
                    ActualizardgvClientes();
                }
            }
            return resultado;
        }

        private void btNuevo_Click(object sender, EventArgs e)
        {
            AltaCliente formNuevoCliente = new AltaCliente(new Cliente());
            formNuevoCliente.Owner = this;
            formNuevoCliente.ShowDialog();
        }

        private void btEliminar_Click(object sender, EventArgs e)
        {
            if (dgvClientes.SelectedRows.Count == 1) { 
                var result = MessageBox.Show("Seguro que desea eliminar este Cliente?", "CUIDADO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    if (owner != null)
                    {
                        owner.ModificacionEliminacionCliente(dgvClientes.SelectedRows[0].DataBoundItem as Cliente, false);
                        ActualizardgvClientes();
                    }
                }
            }
        }

        private void btModificar_Click(object sender, EventArgs e)
        {
            if (dgvClientes.SelectedRows.Count == 1)
            {
                if (owner != null)
                { 
                    AltaCliente NuevaModificacion = new AltaCliente(dgvClientes.SelectedRows[0].DataBoundItem as Cliente,true);
                    NuevaModificacion.Owner = this;
                    NuevaModificacion.ShowDialog();
           
                }
            }      

        }
    }
}
