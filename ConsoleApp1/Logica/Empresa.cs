using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Logica
{
    public enum TipoDocumento { DNI, LC, LE }
    public enum Sexo { MASCULINO, FEMENINO }
    public class Empresa
    {
        private string path = @"C:\Users\USER\Desktop\CommitCorreciones\Archivos";

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
            result.FueCorrecto = true;
            string regexLetras, regexDomicilio;

            if (pSeModifica && !this.getSucursales().Exists(x => x.ID == pSucursal.ID))
            {
                result.listaMsjs.Add("Esta sucursal no existe");
                result.FueCorrecto = false;
            }
            if (pSucursal.TasaInteres > 100 && pSucursal.TasaInteres < 0)
            {
                result.listaMsjs.Add("La tasa de interes no es valida, debe contener un valor entre 0 y 100");
                result.FueCorrecto = false;
            }
            regexLetras = "[a-zA-ZñÑ\\s ]";
            regexDomicilio = "^.*(?=.*[0-9])(?=.*[a-zA-ZñÑ\\s]).*$";

            if (!Regex.IsMatch(pSucursal.Ciudad, regexLetras))
            {
                result.listaMsjs.Add("La Ciudad no es valida");
                result.FueCorrecto = false;
            }
            if (!Regex.IsMatch(pSucursal.Direccion, regexDomicilio))
            {
                result.listaMsjs.Add("La dirección es invalida");
                result.FueCorrecto = false;
            }
            return result;
        }

        public Resultado validarComercio(Comercio pComercio, bool pSeModifica)
        {
            Resultado result = new Resultado();
            result.FueCorrecto = true;

            if (pSeModifica && !this.getComercios().Exists(x => x.ID == pComercio.ID))
            {
                result.listaMsjs.Add("Este comercio no existe");
                result.FueCorrecto = false;
            }

            return result;
        }

        public Resultado validarCliente(Cliente pCliente, bool pSeModifica)
        {
            string regexLetras, regexDomicilio, regexCorreo, regexTelefonos, regexFechas, regexNumerosa;

            Resultado result = new Resultado();
            result.FueCorrecto = true;

            if (pSeModifica && !this.getClientes(null,null).Exists(x => x.TipoDoc == pCliente.TipoDoc && x.Documento == pCliente.Documento))
            {
                result.listaMsjs.Add("Esta sucursal no existe");
                result.FueCorrecto = false;
            }
            else
            {
                if (!pSeModifica && this.getClientes(null,null).Exists(x => (x.TipoDoc == pCliente.TipoDoc) && (x.Documento == pCliente.Documento)))
                {
                    result.listaMsjs.Add("Este Cliente ya existe");
                    result.FueCorrecto = false;
                }
            }
            regexLetras = "[a-zA-ZñÑ\\s ]";
            regexNumerosa = "^[. 0-9]+$";
            regexCorreo = "^(([\\w-]+\\.)+[\\w-]+|([a-zA-Z]{1}|[\\w-]{2,}))@(([a-zA-Z]+[\\w-]+\\.){1,2}[a-zA-Z]{2,4})$";
            regexTelefonos = "^[+-]?\\d+(\\.\\d+)?$";
            regexDomicilio = "^.*(?=.*[0-9])(?=.*[a-zA-ZñÑ\\s]).*$";
            regexFechas = "(0[1-9]|[12][0-9]|3[01])[/](0[1-9]|1[012])[/]((175[7-9])|(17[6-9][0-9])|(1[8-9][0-9][0-9])|([2-9][0-9][0-9][0-9]))";


            if (!Regex.IsMatch(pCliente.NombreCompleto, regexLetras))
            {
                result.listaMsjs.Add("El nombre no es valido");
                result.FueCorrecto = false;
            }
            if (!(Regex.IsMatch(pCliente.Email, regexCorreo)))
            {
                result.listaMsjs.Add("Formato de Mail Incorrecto");
                result.FueCorrecto = false;
            }

            if ((pCliente.Celular != "") && !(Regex.IsMatch(pCliente.Celular, regexTelefonos)))
            {
                result.listaMsjs.Add("El celular no es valido");
                result.FueCorrecto = false;
            }
            if ((pCliente.FechaNacimiento != DateTime.MinValue) &&  (pCliente.FechaNacimiento < DateTime.Now))
            {
                if (!Regex.IsMatch(pCliente.FechaNacimiento.ToString(), regexFechas) )
                {
                    result.listaMsjs.Add("La fecha nacimiento no es valida");
                    result.FueCorrecto = false;
                }
            }
            else
            {
                if ((pCliente.FechaNacimiento != DateTime.MinValue) && Regex.IsMatch(pCliente.FechaNacimiento.ToString(), regexFechas))
                {
                    result.listaMsjs.Add("La fecha nacimiento debe ser menor al día de hoy");
                    result.FueCorrecto = false;
                }
            }
            if ((pCliente.Domicilio != "") && !Regex.IsMatch(pCliente.Domicilio, regexDomicilio))
            {
                    result.listaMsjs.Add("El domicilio no es valido");
                    result.FueCorrecto = false;
            }
            if ((pCliente.CodPostal != 0) && !Regex.IsMatch(pCliente.CodPostal.ToString(), regexNumerosa))
            {
                    result.listaMsjs.Add("El CodigoPostal no es valido");
                    result.FueCorrecto = false;
            }
            if ((pCliente.Localidad != "") && !Regex.IsMatch(pCliente.Localidad, regexLetras))
            {
                    result.listaMsjs.Add("La localidad no es valida");
                    result.FueCorrecto = false;
            }

            return result;
        }

        public Resultado validarPrestamo(Prestamo prestamo)
        {
            Resultado result = new Resultado();
            result.FueCorrecto = true;
            string regexNumerosa;


            if (prestamo.FechaCredito != DateTime.Today)
            {
                result.listaMsjs.Add("La fecha de prestamo no es valida, solo se pueden brindar prestamos del dia actual");
                result.FueCorrecto = false;
            }
            if (prestamo.Cliente == null)
            {
                result.listaMsjs.Add("Este cliente no existe");
                result.FueCorrecto = false;
            }
            if (prestamo.ComercioAdherido == null)
            {
                result.listaMsjs.Add("Este comercio no existe");
                result.FueCorrecto = false;
            }
            if (prestamo.Sucursal == null)
            {
                result.listaMsjs.Add("Esta sucursal no existe");
                result.FueCorrecto = false;
            }

            if (prestamo.MontoCredito <= 0)
            {
                result.listaMsjs.Add("El monto de credito no puede ser menor a 0");
                result.FueCorrecto = false;
            }
            if (prestamo.Cliente != null) { 
                if ((prestamo.MontoCredito + (prestamo.MontoCredito * prestamo.Tasa) / 100 ) > prestamo.Cliente.MontoMaximoAutorizar)
                {
                    result.listaMsjs.Add($"El monto de credito más la tasa de interés no puede ser superior al monto máximo autorizado para el cliente (${prestamo.Cliente.MontoMaximoAutorizar})");
                    result.FueCorrecto = false;
                }
            }
            if (prestamo.CantidadCuotas <= 0)
            {
                result.listaMsjs.Add("La cantidad de cuotas debe ser superior a 0");
                result.FueCorrecto = false;
            }
            regexNumerosa = "^[0-9]+$";
            if (prestamo.Cliente != null)
            {
                if (!Regex.IsMatch(prestamo.Cliente.Documento.ToString(), regexNumerosa))
                {
                    result.listaMsjs.Add("El Documento no es valido");
                    result.FueCorrecto = false;
                }
            }
            if (!Regex.IsMatch(prestamo.CantidadCuotas.ToString(), regexNumerosa))
            {
                result.listaMsjs.Add("La cantidad de cuotas no son validas");
                result.FueCorrecto = false;
            }

            return result;
        }

        public Resultado validarPago(Prestamo prestamo,LugarDePago lugar)
        {
            Resultado result = new Resultado();
            result.FueCorrecto = true;

            if (prestamo.Completado())
            {
                result.listaMsjs.Add("Este prestamo no tiene cuotas pendientes");
                result.FueCorrecto = false;
            }
            if (lugar == null)
            {
                result.listaMsjs.Add("Este lugar de pago no existe");
                result.FueCorrecto = false;
            }

            return result;
        }
        //Cargar Sucursal
        public Resultado altaSucursal(Sucursal pSucursal)
        {
            Resultado result = validarSucursal(pSucursal,false);

            listaSucursal = getSucursales();

            if (listaSucursal.Count == 0)
            {
                pSucursal.ID = 1;
            }
            else
            {
                pSucursal.ID = this.listaSucursal.Max(x => x.ID) + 1;
            }

            if (result.FueCorrecto)
            {
                listaSucursal.Add(pSucursal);
                guardarSucursales();
            }

            return result;
        }

        //ModificarEliminarSucursal
        public Resultado modificarEliminarSucursal(Sucursal pSucursal, bool pSeModifica)
        {
            listaSucursal = getSucursales();
            Resultado result = validarSucursal(pSucursal, true);;

            if (result.FueCorrecto) { 
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
                            break;
                        }
                        else
                        {
                            item.Baja = true;
                            break;
                        }
                    }
                }
                guardarSucursales();
            }
            return result;
        }

        // Carga Comercio
        public Resultado altaComercioAdherido(Comercio pComercio)
        {
            Resultado resultado = validarComercio(pComercio, false);
            listaComercio = getComercios();
            if (listaComercio.Count == 0)
            {
                pComercio.ID = 1;
            }
            else
            {
                pComercio.ID = this.listaComercio.Max(x => x.ID) + 1;
            }

            if (resultado.FueCorrecto) {
                listaComercio.Add(pComercio);
                guardarComercios();
            }
            return resultado;
        }

        //ModificarEliminarComercioAdherido
        public Resultado modificarEliminarComercio(Comercio pComercio, bool pSeModifica)
        {
            listaComercio = getComercios();

            Resultado result = validarComercio(pComercio,true);

            if (result.FueCorrecto)
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
                guardarComercios();
            }
            return result;
        }

        
        // Cargar LugarPago
        public Resultado altaLugarPago(LugarDePago pLugarPago)
        {
            Resultado resultado = validarComercio(pLugarPago, false);
            listaLugarPago = getLugaresPago();
            if (listaLugarPago.Count ==0)
            {
                pLugarPago.ID = 1;
            }
            else
            {
                pLugarPago.ID = this.listaLugarPago.Max(x => x.ID) + 1; ;
            }
            
            if (resultado.FueCorrecto) { 
                listaLugarPago.Add(pLugarPago);
                guardarLugaresPago();
            }
            return resultado;
        }

        //ModificarEliminarLugarPago
        public Resultado modificarEliminarLugarPago(LugarDePago pLugarDePago, bool pSeModifica)
        {
            listaLugarPago = getLugaresPago();
            Resultado result = new Resultado();
            result.FueCorrecto = true;

            if (result.FueCorrecto)
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
                            result.FueCorrecto = true;
                        }
                        else
                        {
                            item.Baja = true;
                            result.FueCorrecto = true;
                        }
                    }
                }
                guardarLugaresPago();
            }

            return result;
        }
        
        
        //Cargar Cliente
        public Resultado altaCliente(Cliente pcliente)
        {
            listaCliente = getClientes(null,null);
            Resultado resultado = validarCliente(pcliente,false);

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
            listaCliente = getClientes(null,null);

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

        //Alta prestamo
        public Resultado altaPrestamo(Prestamo pPrestamo)
        {
            Resultado resultado = validarPrestamo(pPrestamo);
            listaPrestamo = getPrestamo();

            if (listaPrestamo.Count == 0)
            {
                listaPrestamo = new List<Prestamo>();
                pPrestamo.NumCredito = 1;
            }
            else
            {
                pPrestamo.NumCredito = this.listaPrestamo.Max(x => x.NumCredito) + 1;
            }
            if (resultado.FueCorrecto)
            {
                listaPrestamo.Add(pPrestamo);
                guardarPrestamos();
            }
            return resultado;
        }
        //ActualizarPago
        public Resultado actualizarPago(Prestamo prestamo, LugarDePago lugar)
        {
            listaPrestamo = getPrestamo();

            Resultado resultado = validarPago(prestamo,lugar);
            if (resultado.FueCorrecto) {
                prestamo.RealizarPago(lugar);
                foreach (var item in listaPrestamo)
                {
                    if (item.NumCredito == prestamo.NumCredito)
                    {
                        item.ListaPagos = prestamo.ListaPagos;
                        resultado.FueCorrecto = true;
                        guardarPrestamos();
                        return resultado;
                    }
                }
            }
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

        public List<Cliente> getClientes(int? dni, TipoDocumento? tipo)
        {
            try
            {
                string conte;
                using (StreamReader reader = new StreamReader(path + "Clientes.txt"))
                {
                    conte = reader.ReadToEnd();
                }

                return JsonConvert.DeserializeObject<List<Cliente>>(conte)
                    .Where(x => x.Baja != true)
                    .Where(x => dni.HasValue ? x.Documento == dni : true)
                    .Where(y => tipo.HasValue ? y.TipoDoc == tipo : true)
                    .ToList();
            }
            catch (Exception)
            {
                return new List<Cliente>();
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
                return new List<Sucursal>();
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
                return new List<Comercio>();
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
                return new List<LugarDePago>();
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
                return new List<Prestamo>();
            }
        }
        public List<Prestamo> getPrestamo(DateTime desde, DateTime hasta, string nombre, bool? vip)
        {
            List<Prestamo> lista = getPrestamo();

            lista = lista.Where(x => x.FechaCredito >= desde && x.FechaCredito <= hasta).ToList();

            lista = lista.Where(x => x.Cliente.NombreCompleto.ToUpper().Contains(nombre.ToUpper())).ToList();
            if (vip.HasValue)
            {
                lista = lista.Where(x => x.Cliente.EsVip == vip).ToList();
            }
            return lista;
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



        public float obtenerMontoTotalPrestado()
        {
            return getPrestamo().Sum(x => x.MontoCredito);
        }
        public float obtenerPromedioTasas()
        {
            if(getPrestamo().Count() > 0) { 
                return getPrestamo().Average(x => x.Tasa);
            }
            return 0;
        }
        public float obtenerMontoTotalRecaudado()
        {
            return getPrestamo().Sum(x => x.ListaPagos.Where(y=>y.Pagado).Sum(z=>x.MontoCuota));
        }

    }
}