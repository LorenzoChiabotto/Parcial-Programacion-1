using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logica;

namespace Formularios.Interfaces
{
    public interface IMenuPrincipal
    {

        List<Cliente> ObtenerCliente(int? dni);
        List<Prestamo> ObtenerPrestamo(int? Id); 

        Resultado NuevoCliente(Cliente cliente);

        Resultado ModificacionEliminacionCliente(Cliente cliente, bool pSeModifica);

        Resultado NuevoPrestamo(Prestamo prestamo);
   


    }
}
