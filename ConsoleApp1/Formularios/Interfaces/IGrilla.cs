using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logica;

namespace Formularios.Interfaces
{
    interface IGrilla
    {
        Resultado NuevoCliente(Cliente cliente);

        Resultado ModificacionCliente(Cliente cliente, bool pSeModifica);
    }
}
