using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    class Cliente
    {
        public int DNI { get; set; }
        public string NombreCompleto { get; set; }
        public string Email { get; set; }
        //Ver si poner long o string el Celular
        public string Celular { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public bool Sexo { get; set; }
        public string Domicilio { get; set; }
        public int CodPostal { get; set; }
        public string Localidad { get; set; }
        public bool EsVip { get; set; }
        public float MontoMaximoAutorizar { get; set; }
       
    }
}
