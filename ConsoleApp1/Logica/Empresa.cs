using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public enum TipoDocumento { DNI, LC, LE }
    public enum Sexo { MASCULINO, FEMENINO }
    public class Empresa
    {
        public List<Cliente> listaCliente = new List<Cliente>();
        public List<Prestamo> listaPrestamo = new List<Prestamo>();
        public List<Sucursal> listaSucursal = new List<Sucursal>();
        public List<Comercio> listaComercio = new List<Comercio>();
        public List<LugarDePago> listaLugarPago = new List<LugarDePago>();


        //Cargar Sucursal
        public void altaSucursal(Sucursal pSucursal)
        {
            Sucursal sucursal = new Sucursal();
            sucursal.ID = pSucursal.ID;
            sucursal.Ciudad = pSucursal.Ciudad;
            sucursal.Direccion = pSucursal.Direccion;
            sucursal.CodPostal = pSucursal.CodPostal;
            sucursal.TasaInteres = pSucursal.TasaInteres;
            sucursal.Baja = false;

        }

        //ModificarEliminarSucursal
        public void modificarEliminarSucursal(Sucursal pSucursal, bool pSeModifica)
        {
            foreach (var item in listaSucursal)
            {

                if (item.ID == pSucursal.ID)
                {
                    if (pSeModifica)
                    {
                        item.ID = pSucursal.ID;
                        item.Ciudad = pSucursal.Ciudad;
                        item.Direccion = pSucursal.Direccion;
                        item.CodPostal = pSucursal.CodPostal;
                        item.TasaInteres = pSucursal.TasaInteres;
                    }
                    else
                    {
                        item.Baja = true;
                    }
                }
            }
        }

        // Carga Comercio
        public void altaComercioAdherido(Comercio pComercio)
        {
            Comercio Data = new Comercio();
            Data.ID = pComercio.ID;
            Data.Ciudad = pComercio.Ciudad;
            Data.Direccion = pComercio.Direccion;
            Data.CodPostal = pComercio.CodPostal;
            Data.RazonSocial = pComercio.RazonSocial;
            Data.Baja = false;

            listaComercio.Add(Data);
        }
        //ModificarEliminarComercioAdherido
        public void modificarEliminarComercio(Comercio pComercio, bool pSeModifica)
        {
            foreach (var item in listaComercio)
            {
                if (item.ID == pComercio.ID)
                {
                    if (pSeModifica)
                    {
                        item.ID = pComercio.ID;
                        item.Ciudad = pComercio.Ciudad;
                        item.Direccion = pComercio.Direccion;
                        item.CodPostal = pComercio.CodPostal;
                        item.RazonSocial = pComercio.RazonSocial;
                    }
                    else
                    {
                        item.Baja = true;
                    }
                }
            }
        }

        // Cargar LugarPago
        public void altaLugarPago(LugarDePago pLugarPago)
        {
            LugarDePago Data = new LugarDePago();
            Data.ID = pLugarPago.ID;
            Data.Ciudad = pLugarPago.Ciudad;
            Data.Direccion = pLugarPago.Direccion;
            Data.CodPostal = pLugarPago.CodPostal;
            Data.RazonSocial = pLugarPago.RazonSocial;
            Data.EsSucursal = pLugarPago.EsSucursal;
            Data.Baja = false;

            listaComercio.Add(Data);
        }

        //ModificarEliminarLugarPago
        public void modificarEliminarComercio(LugarDePago pLugarDePago, bool pSeModifica)
        {
            foreach (var item in listaLugarPago)
            {
                if (item.ID == pLugarDePago.ID)
                {
                    if (pSeModifica)
                    {
                        item.ID = pLugarDePago.ID;
                        item.Ciudad = pLugarDePago.Ciudad;
                        item.Direccion = pLugarDePago.Direccion;
                        item.CodPostal = pLugarDePago.CodPostal;
                        item.RazonSocial = pLugarDePago.RazonSocial;
                        item.EsSucursal = pLugarDePago.EsSucursal;
                    }
                    else
                    {
                        item.Baja = true;
                    }
                }
            }
        }
        //Cargar Cliente
        public void altaCliente(Cliente pcliente)
        {
            //Falta ver el tema de validaar que no sea el mismo
            Cliente NuevoCliente = new Cliente();
            NuevoCliente.TipoDoc = pcliente.TipoDoc;
            NuevoCliente.Documento = pcliente.Documento;
            NuevoCliente.NombreCompleto = pcliente.NombreCompleto;
            NuevoCliente.Email = pcliente.Email;
            NuevoCliente.Celular = pcliente.Celular;
            NuevoCliente.FechaNacimiento = pcliente.FechaNacimiento;
            NuevoCliente.Sexo = pcliente.Sexo;
            NuevoCliente.Domicilio = pcliente.Domicilio;
            NuevoCliente.CodPostal = pcliente.CodPostal;
            NuevoCliente.Localidad = pcliente.Localidad;
            NuevoCliente.EsVip = pcliente.EsVip;
            NuevoCliente.MontoMaximoAutorizar = pcliente.MontoMaximoAutorizar;
            NuevoCliente.Baja = false;
            listaCliente.Add(NuevoCliente);
        }


        //ModificarEliminarCliente
        public void modificarEliminarCliente(Cliente pCliente, bool pSeModifica)
        {
            //TODO: modificarCliente
            foreach (var item in listaCliente)
            {
                if (item.Documento == pCliente.Documento)
                {
                    if (pSeModifica)
                    {
                        item.TipoDoc = pCliente.TipoDoc;
                        item.Documento = pCliente.Documento;
                        item.NombreCompleto = pCliente.NombreCompleto;
                        item.Email = pCliente.Email;
                        item.Celular = pCliente.Celular;
                        item.FechaNacimiento = pCliente.FechaNacimiento;
                        item.Sexo = pCliente.Sexo;
                        item.Domicilio = pCliente.Domicilio;
                        item.CodPostal = pCliente.CodPostal;
                        item.Localidad = pCliente.Localidad;
                        item.EsVip = pCliente.EsVip;
                        item.MontoMaximoAutorizar = pCliente.MontoMaximoAutorizar;
                    }
                    else
                    {
                        item.Baja = true;
                    }
                }
            }
        }


        public void altaPrestamo(Prestamo pPrestamo)
        {
            //TODO: ALTA PRESTAMO
            //tomar fecha de hoy para date
            Prestamo NuevoPrestamo = new Prestamo();
            NuevoPrestamo.NumCredito = this.listaCliente.Count + 1;
            NuevoPrestamo.FechaCredito = DateTime.Now;
            NuevoPrestamo.ComercioAdherido = pPrestamo.ComercioAdherido;
            NuevoPrestamo.Sucursal = pPrestamo.Sucursal;
            NuevoPrestamo.MontoCredito = pPrestamo.MontoCredito;
            NuevoPrestamo.Tasa = pPrestamo.Tasa;
            NuevoPrestamo.MontoCuota = pPrestamo.MontoCuota;
            NuevoPrestamo.CantidadCuotas = pPrestamo.CantidadCuotas;

            listaPrestamo.Add(NuevoPrestamo);
        }


    }
}

