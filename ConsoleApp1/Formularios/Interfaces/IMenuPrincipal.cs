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

        List<Cliente> ObtenerCliente(int? dni, TipoDocumento? tipo);
        List<Prestamo> ObtenerPrestamo(int? Id);
        List<Sucursal> ObtenerSucursal(int? Id);
        List<Comercio> ObtenerComercio(int? Id);
        List<LugarDePago> ObtenerLugarDePago(int? Id);

        Resultado NuevoCliente(Cliente cliente);

        Resultado ModificacionEliminacionCliente(Cliente cliente, bool pSeModifica);

        Resultado NuevoPrestamo(Prestamo prestamo);


        Resultado NuevaSucursal(Sucursal sucursal);

        Resultado ModificacionEliminacionSucursal(Sucursal sucursal, bool pSeModifica);



        Resultado NuevoComercio(Comercio comercio);

        Resultado ModificacionEliminacionComercio(Comercio comercio, bool pSeModifica);



        Resultado NuevoLugarPago(LugarDePago lugar);

        Resultado ModificacionEliminacionLugarPago(LugarDePago lugar, bool pSeModifica);

        Resultado ActualizarPagos(Prestamo prestamo,LugarDePago lugar);



        float ObtenerMontoTotalPrestado();
        float ObtenerPromedioTasas();
        float ObtenerMontoTotalRecaudado();
    }
}
