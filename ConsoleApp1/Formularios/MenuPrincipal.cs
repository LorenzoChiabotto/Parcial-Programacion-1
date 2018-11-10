using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using Logica;
using Formularios.Interfaces;
using Newtonsoft.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Reflection;

namespace Formularios
{
    public partial class MenuPrincipal : Form, IMenuPrincipal
    {
        Empresa NuevaEmpresa = new Empresa();
        private List<Cliente> ListaCliente { get; set; }

        public Empresa Empresa
        {
            get
            {
                return this.NuevaEmpresa;
            }
        }

        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void altaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form NuevoCLiente = new AltaCliente();
            NuevoCLiente.Owner = this;
            NuevoCLiente.ShowDialog();

        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void listadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form ListaCliente = new GrillaClientes();
            ListaCliente.Owner = this;
            ListaCliente.ShowDialog();
        }

        private void nuevoPrestamoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form NuevoPrestamo = new AltaPrestamo();
            NuevoPrestamo.Owner = this;
            NuevoPrestamo.ShowDialog();


        }

        private void sucursalesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form NuevaSucursal = new ABMSucursal();
            NuevaSucursal.Owner = this;
            NuevaSucursal.ShowDialog();
        }

        private void comercioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form Comercio = new ABMComercioAdherido();
            Comercio.Owner = this;
            Comercio.ShowDialog();
        }

        private void lugaresDePagoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form LugarDePago = new ABMLugarDePago();
            LugarDePago.Owner = this;
            LugarDePago.ShowDialog();
        }

        private void listadoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form ListaPrestamo = new GrillaPrestamos();
            ListaPrestamo.Owner = this;
            ListaPrestamo.ShowDialog();
        }


        public List<Cliente> ObtenerCliente(int? dni)
        {
            return NuevaEmpresa.ObtenerCliente(dni);
           
        }

        public Resultado NuevoCliente(Cliente cliente)
        {
            return NuevaEmpresa.altaCliente(cliente);
        }

       public Resultado ModificacionEliminacionCliente(Cliente cliente, bool pSeModifica)
        {
            return NuevaEmpresa.modificarEliminarCliente(cliente, pSeModifica);
        }
    }
}
