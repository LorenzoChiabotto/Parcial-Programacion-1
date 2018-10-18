using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    class Prestamo
    {
        public int NumCredito { get; set; }
        public DateTime FechaCredito { get; set; }
        public Comercio ComercioAdherido { get; set; }
        public Sucursal sucursal { get; set; }
        public float MontoCredito { get; set; }
        //Ver propiedad Tasa.
        public float Tasa { get; set; }
        public float MontoCuota { get; set; }
        public int CantidadCuotas { get; set; }

    }
}
