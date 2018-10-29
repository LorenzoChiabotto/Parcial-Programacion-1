using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    class LugarDePago:Comercio
    {
        public bool EsSucursal { get; set; }


        public LugarDePago(int id, string ciudad, string direccion, int codP, string razonSocial, bool esSucur)
        {

            this.ID = id;
            this.Ciudad = ciudad;
            this.Direccion = direccion;
            this.CodPostal = codP;

            this.RazonSocial = razonSocial;

            this.EsSucursal = esSucur;
        }
    }
}
