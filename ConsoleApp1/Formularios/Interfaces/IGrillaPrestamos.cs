using Logica;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formularios.Interfaces
{
    interface IGrillaPrestamos
    {
        Resultado ActualizarPagos(Prestamo prestamo);

        List<LugarDePago> ObtenerLugaresDePago();
    }
}
