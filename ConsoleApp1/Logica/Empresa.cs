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
        public List<Cliente> listaCliente;
        public List<Prestamo> listaPrestamo = new List<Prestamo>();
        public List<Sucursal> listaSucursal = new List<Sucursal>();
        public List<Comercio> listaComercio = new List<Comercio>();
        public List<LugarDePago> listaLugarPago = new List<LugarDePago>();

        public Empresa()
        {
            crearArchivos();
        }

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
            listaSucursal = getSucursales();
            if (listaSucursal == null)
            {
                listaSucursal = new List<Sucursal>();
            }

            Resultado result = validarSucursal(pSucursal,false);

            if (result.FueCorrecto)
            {
                pSucursal.ID = this.listaSucursal.Max(x => x.ID) + 1;
                listaSucursal.Add(pSucursal);
                guardarSucursales();
            }

            return result;
        }

        //ModificarEliminarSucursal
        public Resultado modificarEliminarSucursal(Sucursal pSucursal, bool pSeModifica)
        {
            listaSucursal = getSucursales();
            if (listaSucursal == null)
            {
                listaSucursal = new List<Sucursal>();
            }
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
                guardarSucursales();
            }
            return result;
        }

        // Carga Comercio
        public void altaComercioAdherido(Comercio pComercio)
        {
            listaComercio = getComercios();
            if (listaComercio == null)
            {
                listaComercio = new List<Comercio>();
            }
            //TODO: Validar Comercio
            pComercio.ID = this.listaComercio.Max(x => x.ID) + 1;

            listaComercio.Add(pComercio);
            guardarComercios();
            
        }
        //ModificarEliminarComercioAdherido
        public Resultado modificarEliminarComercio(Comercio pComercio, bool pSeModifica)
        {
            listaComercio = getComercios();
            if (listaComercio == null)
            {
                listaComercio = new List<Comercio>();
            }
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
                guardarComercios();
            }
            return result;
        }

        
        // Cargar LugarPago
        public void altaLugarPago(LugarDePago pLugarPago)
        {

            listaLugarPago = getLugaresPago();
            if (listaLugarPago == null)
            {
                listaLugarPago = new List<LugarDePago>();
            }

            //TODO: Validar LugarPago
            pLugarPago.ID = this.listaLugarPago.Max(x => x.ID) + 1;

            listaLugarPago.Add(pLugarPago);
        }

        //ModificarEliminarLugarPago
        public Resultado modificarEliminarLugarPago(LugarDePago pLugarDePago, bool pSeModifica)
        {
            listaLugarPago = getLugaresPago();
            if (listaLugarPago == null)
            {
                listaLugarPago = new List<LugarDePago>();
            }
            Resultado result = new Resultado();

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
                        result.FueCorrecto = true;
                    }
                    else
                    {
                        item.Baja = true;
                        result.FueCorrecto = true;
                    }
                }
            }

            if(result.FueCorrecto){
                guardarLugaresPago();
            }

            return result;
        }
        
        
        //Cargar Cliente
        public Resultado altaCliente(Cliente pcliente)
        {
            //TODO: Validar Cliente
            listaCliente = getClientes();
            if (listaCliente == null)
            {
                listaCliente = new List<Cliente>();
            }
            Resultado resultado = new Resultado();
            resultado.FueCorrecto = true;

            if (resultado.FueCorrecto)
            {
                listaCliente.Add(pcliente);
                guardarClientes();
            }

            return resultado;

        }
        
        //ModificarEliminarCliente
        public Resultado modificarEliminarCliente(Cliente pCliente, bool pSeModifica)
        {
            listaCliente = getClientes();
            if (listaCliente == null)
            {
                listaCliente = new List<Cliente>();
            }

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
                    }
                    else
                    {
                        item.Baja = true;
                        resultado.FueCorrecto = true;
                    }
                }
            }
            if (resultado.FueCorrecto)
            {
                guardarClientes();
            }
            return resultado;
        }


        public void altaPrestamo(Prestamo pPrestamo)
        {
            listaPrestamo = getPrestamo();
            if (listaPrestamo == null)
            {
                listaPrestamo = new List<Prestamo>();
            }
            //TODO: validar Prestamo

            pPrestamo.NumCredito = this.listaPrestamo.Max(x => x.NumCredito) + 1;

            listaPrestamo.Add(pPrestamo);
            guardarPrestamos();
        }


        // ARCHIVOS

        public void crearArchivos()
        {
            FileStream file;
            string path = @"C:\Users\loren\Desktop\Clientes.txt";
            if (!File.Exists(path))
            {
                file = File.Create(path);
                file.Close();
            }

            path = @"C:\Users\loren\Desktop\Sucursales.txt";
            if (!File.Exists(path))
            {
                file = File.Create(path);
                file.Close();
            }

            path = @"C:\Users\loren\Desktop\Comercios.txt";
            if (!File.Exists(path))
            {
                file = File.Create(path);
                file.Close();
            }

            path = @"C:\Users\loren\Desktop\LugaresDePago.txt";
            if (!File.Exists(path))
            {
                file = File.Create(path);
                file.Close();
            }

            path = @"C:\Users\loren\Desktop\Prestamos.txt";
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
                string path = @"C:\Users\loren\Desktop\Clientes.txt";   

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

        public void guardarClientes()
        {
            string output = JsonConvert.SerializeObject(listaCliente);
            using (StreamWriter file = new System.IO.StreamWriter(@"C:\Users\loren\Desktop\Clientes.txt", false))
            {
                file.Write(output);
            }
        }
        public void guardarSucursales()
        {
            string output = JsonConvert.SerializeObject(listaSucursal);
            using (StreamWriter file = new System.IO.StreamWriter(@"C:\Users\loren\Desktop\Sucursales.txt", false))
            {
                file.Write(output);
            }
        }
        public void guardarComercios()
        {
            string output = JsonConvert.SerializeObject(listaComercio);
            using (StreamWriter file = new System.IO.StreamWriter(@"C:\Users\loren\Desktop\Comercios.txt", false))
            {
                file.Write(output);
            }
        }
        public void guardarLugaresPago()
        {
            string output = JsonConvert.SerializeObject(listaLugarPago);
            using (StreamWriter file = new System.IO.StreamWriter(@"C:\Users\loren\Desktop\LugaresDePago.txt", false))
            {
                file.Write(output);
            }
        }
        public void guardarPrestamos()
        {
            string output = JsonConvert.SerializeObject(listaPrestamo);
            using (StreamWriter file = new System.IO.StreamWriter(@"C:\Users\loren\Desktop\Prestamos.txt", false))
            {
                file.Write(output);
            }
        }
    }
}