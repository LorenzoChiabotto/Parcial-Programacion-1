using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class Pago
    {
        public int Numero { get; set; }
        public bool Pagado { get; set; }
        public DateTime FechaCobro { get; set; }
        public LugarDePago LugarPago{ get; set; }

        public Pago(DateTime fecha, int Num)
        {
            this.FechaCobro = fecha;
            this.Pagado = false;
            this.Numero = Num;
        }
        

        public string Estado
        {
            get { return this.Pagado ? "Pagado" : "Pendiente"; }
        }

        public string Lugar
        {
            get { return this.LugarPago != null ? $"{this.LugarPago.RazonSocial} ({this.LugarPago.Ubicacion})" : "-"; }
        }
    }
}
