using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
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

            foreach (var item in getSucursales())
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

                        result.FueCorrecto = true;
                    }
                    else
                    {
                        item.Baja = true;
                        result.FueCorrecto = true;
                    }
                }
            }

            if (result.FueCorrecto)
            {
                // guardararchivo
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
        public Resultado modificarEliminarComercio(Comercio pComercio, bool pSeModifica)
        {
            Resultado result = new Resultado();
            foreach (var item in getComercios())
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
                        result.FueCorrecto = true;
                    }
                    else
                    {
                        item.Baja = true;
                        result.FueCorrecto = true;
                    }
                }
            }

            if (result.FueCorrecto)
            {
                // guardararchivo
            }
            return result;
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
        public Resultado altaCliente(Cliente pcliente)
        {
            //TODO: Validar Cliente
            Resultado resultado = new Resultado();

            listaCliente.Add(pcliente);
            resultado.FueCorrecto = true;
            return resultado;
          
        }


        //ModificarEliminarCliente
        public Resultado modificarEliminarCliente(Cliente pCliente, bool pSeModifica)
        {
            Resultado resultado = new Resultado();
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
                        resultado.FueCorrecto = true;
                        return resultado;
                    }
                    else
                    {
                        item.Baja = true;
                        resultado.FueCorrecto = true;
                        return resultado;
                    }
                }
            }
            return resultado;
        }


        public void altaPrestamo(Prestamo pPrestamo)
        {
            //TODO: validar Prestamo
            
            pPrestamo.NumCredito = this.listaPrestamo.Max(x => x.NumCredito) + 1;

            listaPrestamo.Add(pPrestamo);
            
        }


        // ARCHIVOS

        public void crearArchivos()
        {
            FileStream file;
            string path = @"C:\Users\USER\Desktop\TPNETCHIABOMUSSO\ConsoleApp1\Clientes.txt";
            if (!File.Exists(path))
            {
                file = File.Create(path);
                file.Close();
            }

            path = @"C:\Users\USER\Desktop\TPNETCHIABOMUSSO\ConsoleApp1\Sucursales.txt";
            if (!File.Exists(path))
            {
                file = File.Create(path);
                file.Close();
            }

            path = @"C:\Users\USER\Desktop\TPNETCHIABOMUSSO\ConsoleApp1\Comercios.txt";
            if (!File.Exists(path))
            {
                file = File.Create(path);
                file.Close();
            }

            path = @"C:\Users\USER\Desktop\TPNETCHIABOMUSSO\ConsoleApp1\LugaresDePago.txt";
            if (!File.Exists(path))
            {
                file = File.Create(path);
                file.Close();
            }

            path = @"C:\Users\USER\Desktop\TPNETCHIABOMUSSO\ConsoleApp1\Prestamos.txt";
            if (!File.Exists(path))
            {
                file = File.Create(path);
                file.Close();
            }
        }

        public List<Cliente> getClientes()
        {
            try
            {
                string path = @"C:\Users\USER\Desktop\TPNETCHIABOMUSSO\ConsoleApp1\Clientes.txt";   

                string conte;
                using (StreamReader reader = new StreamReader(path))
                {
                    conte = reader.ReadToEnd();
                }

                return JsonConvert.DeserializeObject<List<Cliente>>(conte);
            }
            catch (Exception)
            {

                return null;
            }
            
        }
        public List<Sucursal> getSucursales()
        {
            try
            {
                string path = @"C:\Users\USER\Desktop\TPNETCHIABOMUSSO\ConsoleApp1\Sucursales.txt";

                string conte;
                using (StreamReader reader = new StreamReader(path))
                {
                    conte = reader.ReadToEnd();
                }

                return JsonConvert.DeserializeObject<List<Sucursal>>(conte);
            }
            catch (Exception)
            {
                return null;
            }
        }
        public List<Comercio> getComercios()
        {
            try
            {
                string path = @"C:\Users\USER\Desktop\TPNETCHIABOMUSSO\ConsoleApp1\Comercio.txt";

                string conte;
                using (StreamReader reader = new StreamReader(path))
                {
                    conte = reader.ReadToEnd();
                }

                return JsonConvert.DeserializeObject<List<Comercio>>(conte);
            }
            catch (Exception)
            {
                return null;
            }
        }
        public List<LugarDePago> getLugaresPago()
        {
            try
            {
                string path = @"C:\Users\USER\Desktop\TPNETCHIABOMUSSO\ConsoleApp1\LugaresDePagos.txt";

                string conte;
                using (StreamReader reader = new StreamReader(path))
                {
                    conte = reader.ReadToEnd();
                }

                return JsonConvert.DeserializeObject<List<LugarDePago>>(conte);
            }
            catch (Exception)
            {
                return null;
            }
        }
        public List<Prestamo> getPrestamo()
        {
            try
            {
                string path = @"C:\Users\USER\Desktop\TPNETCHIABOMUSSO\ConsoleApp1\Prestamos.txt";

                string conte;
                using (StreamReader reader = new StreamReader(path))
                {
                    conte = reader.ReadToEnd();
                }

                return JsonConvert.DeserializeObject<List<Prestamo>>(conte);
            }
            catch (Exception)
            {
                return null;
            }
        }
        public List<Cliente> ObtenerCliente(int? dni)
        {
           
            return listaCliente.Where(x => dni.HasValue ? x.Documento == dni : true).ToList();

        }


    }
}