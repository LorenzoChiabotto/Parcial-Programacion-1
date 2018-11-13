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
    public partial class GrillaClientes : Form,IGrillaCliente
    {
        IMenuPrincipal owner;

        private void armarGrilla()
        {
            this.dgvClientes.AutoGenerateColumns = false;
            this.dgvClientes.ColumnCount = 10;

            this.dgvClientes.Columns[0].HeaderText = "TipoDocumento";
            this.dgvClientes.Columns[0].DataPropertyName = "tipoDoc";

            this.dgvClientes.Columns[1].HeaderText = "NroDoc";
            this.dgvClientes.Columns[1].DataPropertyName = "Documento";

            this.dgvClientes.Columns[2].HeaderText = "Nombre";
            this.dgvClientes.Columns[2].DataPropertyName = "NombreCompleto";

            this.dgvClientes.Columns[3].HeaderText = "E-mail";
            this.dgvClientes.Columns[3].DataPropertyName = "Email";

            this.dgvClientes.Columns[4].HeaderText = "Celular";
            this.dgvClientes.Columns[4].DataPropertyName = "Celular";

            this.dgvClientes.Columns[5].HeaderText = "Nacimiento";
            this.dgvClientes.Columns[5].DataPropertyName = "FechaNacimiento";

            this.dgvClientes.Columns[6].HeaderText = "Sexo";
            this.dgvClientes.Columns[6].DataPropertyName = "tipoSexo";

            this.dgvClientes.Columns[7].HeaderText = "Domicilio";
            this.dgvClientes.Columns[7].DataPropertyName = "vivienda";

            this.dgvClientes.Columns[8].HeaderText = "TipoCliente";
            this.dgvClientes.Columns[8].DataPropertyName = "TipoCliente";

            this.dgvClientes.Columns[9].HeaderText = "Monto Maximo";
            this.dgvClientes.Columns[9].DataPropertyName = "MontoMaximoAutorizar";
        }

        private void ActualizardgvClientes()
        {
            if (owner != null)
            {
                this.dgvClientes.DataSource = owner.ObtenerCliente(null,null);
            }
        }

        public GrillaClientes()
        {
            InitializeComponent();
        }

        private void GrillaClientes_Load(object sender, EventArgs e)
        {
            owner = this.Owner as IMenuPrincipal;
            armarGrilla();
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

        private void btNuevoPrestamo_Click(object sender, EventArgs e)
        {
            if (dgvClientes.SelectedRows.Count == 1)
            {
                if (owner != null)
                {
                    AltaPrestamo nuevoPrestamo = new AltaPrestamo(dgvClientes.SelectedRows[0].DataBoundItem as Cliente);
                    nuevoPrestamo.Owner = this.Owner;
                    nuevoPrestamo.ShowDialog();

                }
            }

        }
    }
}
