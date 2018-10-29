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


        public Prestamo(int numC, DateTime fecha, Comercio comercio, Sucursal sucursal, float montoCr, float tasa, int cantCu)
        {
            this.NumCredito = numC;
            this.FechaCredito = fecha;
            this.ComercioAdherido = comercio;
            this.Sucursal = sucursal;
            this.MontoCredito = montoCr;
            this.Tasa = this.Sucursal.TasaInteres;
            //TODO: Calcular montoCuota y armar ListaPagos
            this.CantidadCuotas = cantCu;
        }

    }
}
