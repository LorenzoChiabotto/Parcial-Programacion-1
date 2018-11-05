using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class Pago
    {
        public bool Pagado { get; set; }
        public DateTime FechaCobro { get; set; }
        public LugarDePago LugarPago{ get; set; }

        public Pago(DateTime fecha)
        {
            this.FechaCobro = fecha;
            this.Pagado = false;
        }
        
    }
}
