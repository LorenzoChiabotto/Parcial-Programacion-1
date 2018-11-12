using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class Comercio:Local
    {
        public string RazonSocial { get; set; }

        public Comercio()
        {

        }
        public Comercio(int id, string ciudad, string direccion, int codP, string razonSocial)
        {
            this.ID = id;
            this.Ciudad = ciudad.ToUpper();
            this.Direccion = direccion.ToUpper();
            this.CodPostal = codP;

            this.RazonSocial = razonSocial.ToUpper();
        }
    }
}
