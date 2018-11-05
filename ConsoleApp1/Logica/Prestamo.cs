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
        public Comercio ComercioAdherido { get; set; }
        public Sucursal Sucursal { get; set; }
        public float MontoCredito { get; set; }
        //Ver propiedad Tasa.
        public float Tasa { get; set; }
        public float MontoCuota { get; set; }
        public int CantidadCuotas { get; set; }
        public List<Pago> ListaPagos { get; set; }
        public bool Baja { get; set; }

        public Prestamo()
        {

        }
        public Prestamo(int numC, Comercio comercio, Sucursal sucursal, float montoCr, float tasa, int cantCu)
        {
            this.NumCredito = numC;
            this.FechaCredito = DateTime.Today;
            this.ComercioAdherido = comercio;
            this.Sucursal = sucursal;
            this.MontoCredito = montoCr;
            this.Tasa = this.Sucursal.TasaInteres;
            this.CantidadCuotas = cantCu;

            this.MontoCuota = (float)this.MontoCredito / cantCu;

            this.ListaPagos.Add(new Pago(this.FechaCredito.AddDays(60)));
            for (int i = 0; i < this.CantidadCuotas; i++)
            {
                this.ListaPagos.Add(new Pago(this.ListaPagos
                                                .First()
                                                .FechaCobro.AddMonths(1)));
            }
        }

        public void RealizarPago(LugarDePago lugar)
        {
            Pago pago = this.ListaPagos.Where(x => !x.Pagado).OrderBy(z => z.FechaCobro).ToList().First();
            if(pago != null)
            {
                pago.Pagado = true;
                pago.LugarPago = lugar;
            }
        }
    }
}
