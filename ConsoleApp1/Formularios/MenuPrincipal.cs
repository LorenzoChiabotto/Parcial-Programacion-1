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
            Form NuevoCLiente = new AltaCliente(new Cliente());
            NuevoCLiente.Owner = this;
            NuevoCLiente.ShowDialog();

        }

        private void listadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form ListaCliente = new GrillaClientes();
            ListaCliente.Owner = this;
            ListaCliente.ShowDialog();
        }

        private void nuevoPrestamoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form NuevoPrestamo = new AltaPrestamo(null);
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

        //Cliente
        public List<Cliente> ObtenerCliente(int? dni, TipoDocumento? tipo)
        {
            if(dni.HasValue && tipo.HasValue)
            {
                return NuevaEmpresa.getClientes(dni,tipo);
            }
            return NuevaEmpresa.getClientes(null,null);
           
        }

        public Resultado NuevoCliente(Cliente cliente)
        {
            return NuevaEmpresa.altaCliente(cliente);
        }

       public Resultado ModificacionEliminacionCliente(Cliente cliente, bool pSeModifica)
        {
            return NuevaEmpresa.modificarEliminarCliente(cliente, pSeModifica);
        }

        //Prestamo
        public List<Prestamo> ObtenerPrestamo(int? Num)
        {
            return NuevaEmpresa.getPrestamo();

        }

        public Resultado NuevoPrestamo(Prestamo prestamo)
        {
            return NuevaEmpresa.altaPrestamo(prestamo);
        }

        //Sucursales
        public List<Sucursal> ObtenerSucursal(int? Id)
        {
            return NuevaEmpresa.getSucursales();
        }

        public Resultado NuevaSucursal(Sucursal sucursal)
        {
            return NuevaEmpresa.altaSucursal(sucursal);
        }

        public Resultado ModificacionEliminacionSucursal(Sucursal sucursal, bool pSeModifica)
        {
            return NuevaEmpresa.modificarEliminarSucursal(sucursal, pSeModifica);
        }

        //Comercios
        public List<Comercio> ObtenerComercio(int? Id)
        {
            return NuevaEmpresa.getComercios();
        }

        public Resultado NuevoComercio(Comercio comercio)
        {
            return NuevaEmpresa.altaComercioAdherido(comercio);
        }

        public Resultado ModificacionEliminacionComercio(Comercio comercio, bool pSeModifica)
        {
            return NuevaEmpresa.modificarEliminarComercio(comercio, pSeModifica);
        }

        //Lugar de Pago
        public List<LugarDePago> ObtenerLugarDePago(int? Id)
        {
            return NuevaEmpresa.getLugaresPago();
        }
        
        public Resultado NuevoLugarPago(LugarDePago lugar)
        {
            return NuevaEmpresa.altaLugarPago(lugar);
        }

        public Resultado ModificacionEliminacionLugarPago(LugarDePago lugar, bool pSeModifica)
        {
            return NuevaEmpresa.modificarEliminarLugarPago(lugar, pSeModifica);
        }
    }
}
