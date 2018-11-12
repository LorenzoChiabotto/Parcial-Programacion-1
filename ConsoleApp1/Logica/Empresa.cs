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
        private string path = @"C:\Users\loren\Desktop\";
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
            int id;

            listaSucursal = getSucursales();
            if (listaSucursal == null)
            {
                listaSucursal = new List<Sucursal>();
                id = 1;
            }
            else
            {
                id = this.listaSucursal.Max(x => x.ID) + 1;
            }

            Resultado result = validarSucursal(pSucursal,false);
            result.FueCorrecto = true;
            if (result.FueCorrecto)
            {
                pSucursal.ID = id;
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
            result.FueCorrecto = true;

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

                        result.FueCorrecto = true;
                        break;
                    }
                    else
                    {
                        item.Baja = true;
                        result.FueCorrecto = true;
                        break;
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
        public Resultado altaComercioAdherido(Comercio pComercio)
        {
            Resultado resultado = new Resultado();
            listaComercio = getComercios();
            if (listaComercio == null)
            {
                listaComercio = new List<Comercio>();
            }
            resultado.FueCorrecto = true;

            //TODO: Validar Comercio
            if (resultado.FueCorrecto) { 
                pComercio.ID = this.listaComercio.Max(x => x.ID) + 1;

                listaComercio.Add(pComercio);
                guardarComercios();
            }
            return resultado;
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
        public Resultado altaLugarPago(LugarDePago pLugarPago)
        {
            Resultado resultado = new Resultado();

            listaLugarPago = getLugaresPago();
            if (listaLugarPago == null)
            {
                listaLugarPago = new List<LugarDePago>();
            }

            //TODO: Validar LugarPago

            resultado.FueCorrecto = true;

            if (resultado.FueCorrecto) { 
                pLugarPago.ID = this.listaLugarPago.Max(x => x.ID) + 1;
            
                listaLugarPago.Add(pLugarPago);
                guardarLugaresPago();
            }
            return resultado;
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


        public Resultado altaPrestamo(Prestamo pPrestamo)
        {
            Resultado resultado = new Resultado();
            listaPrestamo = getPrestamo();
            if (listaPrestamo == null)
            {
                listaPrestamo = new List<Prestamo>();
            }
            //TODO: validar Prestamo

            pPrestamo.NumCredito = this.listaPrestamo.Max(x => x.NumCredito) + 1;

            listaPrestamo.Add(pPrestamo);
            guardarPrestamos();
            resultado.FueCorrecto = true;
            return resultado;
        }


        // ARCHIVOS

        public void crearArchivos()
        {
            FileStream file;
            if (!File.Exists(path + "Clientes.txt"))
            {
                file = File.Create(path+ "Clientes.txt");
                file.Close();
            }
            
            if (!File.Exists(path+ "Sucursales.txt"))
            {
                file = File.Create(path + "Sucursales.txt");
                file.Close();
            }
            
            if (!File.Exists(path + "Comercios.txt"))
            {
                file = File.Create(path + "Comercios.txt");
                file.Close();
            }
            
            if (!File.Exists(path + "LugaresDePago.txt"))
            {
                file = File.Create(path + "LugaresDePago.txt");
                file.Close();
            }
            
            if (!File.Exists(path+ "Prestamos.txt"))
            {
                file = File.Create(path + "Prestamos.txt");
                file.Close();
            }
        }

        public List<Cliente> getClientes()
        {
            try
            {
                string conte;
                using (StreamReader reader = new StreamReader(path + "Clientes.txt"))
                {
                    conte = reader.ReadToEnd();
                }

                return JsonConvert.DeserializeObject<List<Cliente>>(conte).Where(x => x.Baja != true).ToList();
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
                string conte;
                using (StreamReader reader = new StreamReader(path + "Sucursales.txt"))
                {
                    conte = reader.ReadToEnd();
                }

                return JsonConvert.DeserializeObject<List<Sucursal>>(conte).Where(x => x.Baja != true).ToList();
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
                string conte;
                using (StreamReader reader = new StreamReader(path + "Comercios.txt"))
                {
                    conte = reader.ReadToEnd();
                }

                return JsonConvert.DeserializeObject<List<Comercio>>(conte).Where(x => x.Baja != true).ToList();
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
                string conte;
                using (StreamReader reader = new StreamReader(path + "LugaresDePago.txt"))
                {
                    conte = reader.ReadToEnd();
                }

                return JsonConvert.DeserializeObject<List<LugarDePago>>(conte).Where(x => x.Baja != true).ToList();
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
                string conte;
                using (StreamReader reader = new StreamReader(path + "Prestamos.txt"))
                {
                    conte = reader.ReadToEnd();
                }

                return JsonConvert.DeserializeObject<List<Prestamo>>(conte).Where(x => x.Baja != true).ToList();
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
            using (StreamWriter file = new System.IO.StreamWriter(path+"Clientes.txt", false))
            {
                file.Write(output);
            }
        }
        public void guardarSucursales()
        {
            string output = JsonConvert.SerializeObject(listaSucursal);
            using (StreamWriter file = new System.IO.StreamWriter(path+"Sucursales.txt", false))
            {
                file.Write(output);
            }
        }
        public void guardarComercios()
        {
            string output = JsonConvert.SerializeObject(listaComercio);
            using (StreamWriter file = new System.IO.StreamWriter(path+"Comercios.txt", false))
            {
                file.Write(output);
            }
        }
        public void guardarLugaresPago()
        {
            string output = JsonConvert.SerializeObject(listaLugarPago);
            using (StreamWriter file = new System.IO.StreamWriter(path+"LugaresDePago.txt", false))
            {
                file.Write(output);
            }
        }
        public void guardarPrestamos()
        {
            string output = JsonConvert.SerializeObject(listaPrestamo);
            using (StreamWriter file = new System.IO.StreamWriter(path+"Prestamos.txt", false))
            {
                file.Write(output);
            }
        }
    }
}