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

        Resultado NuevoCliente(Cliente paciente);

        Resultado ModificacionEliminacionCliente(Cliente paciente, bool pSeModifica);


    }
}
