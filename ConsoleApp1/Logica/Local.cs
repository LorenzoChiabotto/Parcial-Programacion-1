using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class Local
    {
        public int ID { get; set; }
        public string Ciudad { get; set; }
        public string Direccion { get; set; }
        public int CodPostal { get; set; }
        public bool Baja { get; set; }

        public Local()
        {

        }
        public Local(int id, string ciudad, string direccion, int codP)
        {
            this.ID = id;
            this.Ciudad = ciudad;
            this.Direccion = direccion;
            this.CodPostal = codP;
        }

        public string Ubicacion
        {
            get
            {
                return $"{this.Ciudad} - {this.Direccion}";
            }
        }
    }
}
