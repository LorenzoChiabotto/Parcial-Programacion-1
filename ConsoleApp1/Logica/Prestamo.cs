using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class Prestamo
    {
        public int NumCredito { get; set; }
        public DateTime FechaCredito { get; set; }
        public Cliente Cliente { get; set; }
        public Comercio ComercioAdherido { get; set; }
        public Sucursal Sucursal { get; set; }
        public float MontoCredito { get; set; }
        public float Tasa { get; set; }
        public float MontoCuota { get; set; }
        public int CantidadCuotas { get; set; }
        public List<Pago> ListaPagos { get; set; }
        public bool Baja { get; set; }

        public Prestamo()
        {

        }
        public Prestamo(Cliente cl, Comercio comercio, Sucursal sucursal, float montoCr, float tasa, int cantCu)
        {
            this.Cliente = cl;
            this.FechaCredito = DateTime.Today;
            this.ComercioAdherido = comercio;
            this.Sucursal = sucursal;
            this.MontoCredito = montoCr;
            this.Tasa = this.Sucursal.TasaInteres;
            this.CantidadCuotas = cantCu;

            this.MontoCuota = ((float)this.MontoCredito+(this.MontoCredito*this.Tasa/100)) / cantCu;

            ListaPagos = new List<Pago>();
            this.ListaPagos.Add(new Pago(this.FechaCredito.AddDays(60)));

            for (int i = 1; i < this.CantidadCuotas; i++)
            {
                this.ListaPagos.Add(new Pago(this.FechaCredito.AddDays(60).AddMonths(i)));
            }
        }

        public void RealizarPago(LugarDePago lugar)
        {
            Pago pago = this.ListaPagos.Where(x => !x.Pagado).OrderBy(z => z.FechaCobro).ToList().FirstOrDefault();
            if(pago != null)
            {
                pago.Pagado = true;
                pago.LugarPago = lugar;
            }
        }

        public bool Completado()
        {
            if (CuotasPagas() == this.ListaPagos.Count)
            {
                return true;
            }
            return false;
        }

        public int CuotasPagas()
        {
            return this.ListaPagos.Where(x => x.Pagado == true).ToList().Count;
        }

        public string NombCliente
        {
            get { return this.Cliente.NombreCompleto; }
        }
        public string UbicComercio
        {
            get { return this.ComercioAdherido.Ubicacion; }
        }
        public string UbicSucursal
        {
            get { return this.Sucursal.Ubicacion; }
        }
        public float MontoInteres
        {
            get { return this.MontoCredito * this.Tasa / 100; }
        }
    }
}
