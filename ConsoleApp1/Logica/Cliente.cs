using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class Cliente
    {
        public TipoDocumento TipoDoc { get; set; }
        public int Documento { get; set; }

        public string NombreCompleto { get; set; }
        public string Email { get; set; }
        //Ver si poner long o string el Celular
        public string Celular { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public Sexo Sexo { get; set; }
        public string Domicilio { get; set; }
        public int CodPostal { get; set; }
        public string Localidad { get; set; }
        public bool EsVip { get; set; }
        public float MontoMaximoAutorizar { get; set; }


        public Cliente(TipoDocumento tipo, int documento, string nombre, string email, bool esVip, float montoMax,
            string celular, DateTime nacimiento, Sexo sexo, string domicilio, int codPostal, string localidad)
        {
            this.TipoDoc = tipo;
            this.Documento = documento;
            this.NombreCompleto = nombre;
            this.Email = email;

            this.EsVip = esVip;
            this.MontoMaximoAutorizar = montoMax;

            this.Celular = celular;
            this.FechaNacimiento = nacimiento;
            this.Sexo = sexo;
            this.Domicilio = domicilio;
            this.CodPostal = codPostal;
            this.Localidad = localidad;
        }
    }
}
