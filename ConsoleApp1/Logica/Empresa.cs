using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public enum TipoDocumento { DNI, LC, LE}
    public enum Sexo { MASCULINO, FEMENINO}
    public class Empresa
    {
        public List<Cliente> listaCliente = new List<Cliente>();





        public void altaCliente(TipoDocumento tipo, int documento, string nombre, string email, bool esVip, float montoMax,
            string celular, DateTime nacimiento, Sexo sexo, string domicilio, int codPostal, string localidad)
        {
            //TODO: ALTA CLIENTE Validar tipo y nro de doc

            Cliente cliente = new Cliente(tipo, documento, nombre, email, esVip, montoMax, celular,
                                            nacimiento, sexo, domicilio, codPostal, localidad);
            listaCliente.Add(cliente);
        }

        public void modificarCliente()
        {
            //TODO: modificarCliente
        }


        public void altaPrestamo(int numC, Comercio comercio, Sucursal sucursal, float montoCr, int cantCu)
        {
            //TODO: ALTA PRESTAMO
            //tomar fecha de hoy para date
        }

    }
}
