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

        //Cliente

        //Alta 
        public void GuardarClientes(Cliente parametro_clientes)
        {
            NuevaEmpresa.altaCliente(parametro_clientes);
        }
        //Modificar - Eliminar
        public void Modificar_EliminarClientes(Cliente ClienteModElim, bool pSeModifica)
        {
            NuevaEmpresa.modificarEliminarCliente(ClienteModElim, pSeModifica);
        }

        // Prestamo
        public void altaPrestamo(Prestamo pPrestamo)
        {
            NuevaEmpresa.altaPrestamo(pPrestamo);
        }

        //Lugar de Pago
        public void altaLugarPago(LugarDePago pLugarPago)
        {
            NuevaEmpresa.altaLugarPago(pLugarPago);
        }

        //Sucursal
        public Resultado altaSucursal(Sucursal pSucursal)
        {
            return NuevaEmpresa.altaSucursal(pSucursal);
        }
        public Resultado modificarEliminarSucursal(Sucursal pSucursal, bool pSeModifica)
        {
            return NuevaEmpresa.modificarEliminarSucursal(pSucursal, pSeModifica);
        }
        //Comercio Adherido

        public void altaComercioAdherido(Comercio pComercio)
        {
            NuevaEmpresa.altaComercioAdherido(pComercio);
        }
        public Resultado modificarEliminarComercio(Comercio pComercio, bool pSeModifica)
        {
            return NuevaEmpresa.modificarEliminarComercio(pComercio, pSeModifica);
        }


    }
}
