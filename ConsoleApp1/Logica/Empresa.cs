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
        
        public Resultado validarSucursal(Sucursal pSucursal, bool pSeModifica)
        {
            Resultado result = new Resultado();
            
            if (pSeModifica && ! this.listaSucursal.Exists(x => x.ID == pSucursal.ID))
            {
                result.listaMsjs.Add("Esta sucursal no existe");
            }
            else
            {

            }


            return result;
        }

        //Cargar Sucursal
        public Resultado altaSucursal(Sucursal pSucursal)
        {
            Resultado result = validarSucursal(pSucursal,false);

            if (result.FueCorrecto)
            {
                pSucursal.ID = this.listaSucursal.Max(x => x.ID) + 1;
                listaSucursal.Add(pSucursal);
            }

            return result;
        }

        //ModificarEliminarSucursal
        public Resultado modificarEliminarSucursal(Sucursal pSucursal, bool pSeModifica)
        {
            Resultado result = validarSucursal(pSucursal, true);

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
                        result.FueCorrecto = true;
                    }
                }
            }
            return result;
        }

        // Carga Comercio
        public void altaComercioAdherido(Comercio pComercio)
        {
            //TODO: Validar Comercio
            pComercio.ID = this.listaComercio.Max(x => x.ID) + 1;

            listaComercio.Add(pComercio);
            
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
                        return;
                    }
                    else
                    {
                        item.Baja = true;
                        return;
                    }
                }
            }
        }

        // Cargar LugarPago
        public void altaLugarPago(LugarDePago pLugarPago)
        {
            //TODO: Validar LugarPago
            pLugarPago.ID = this.listaLugarPago.Max(x => x.ID) + 1;

            listaComercio.Add(pLugarPago);
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
                        return;
                    }
                    else
                    {
                        item.Baja = true;
                        return;
                    }
                }
            }
        }
        //Cargar Cliente
        public void altaCliente(Cliente pcliente)
        {
            //TODO: Validar Cliente

            listaCliente.Add(pcliente);
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
                        return;
                    }
                    else
                    {
                        item.Baja = true;
                        return;
                    }
                }
            }
        }


        public void altaPrestamo(Prestamo pPrestamo)
        {
            //TODO: validar Prestamo
            
            pPrestamo.NumCredito = this.listaPrestamo.Max(x => x.NumCredito) + 1;

            listaPrestamo.Add(pPrestamo);
            
        }
    }
}

