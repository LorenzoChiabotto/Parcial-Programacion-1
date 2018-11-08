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
        
        Empresa Empresa { get; }

        //Clientes
        void GuardarClientes(Cliente parametro_clientes);
        void Modificar_EliminarClientes(Cliente ClienteModElim,bool pSeModifica);

        // Prestamo
        void altaPrestamo(Prestamo pPrestamo);
    
        //Lugar de Pago
        void altaLugarPago(LugarDePago pLugarPago);

        //Sucursal
        Resultado altaSucursal(Sucursal pSucursal);
        Resultado modificarEliminarSucursal(Sucursal pSucursal, bool pSeModifica);

        //Comercio Adherido

        void altaComercioAdherido(Comercio pComercio);
        Resultado modificarEliminarComercio(Comercio pComercio, bool pSeModifica)

    }
}
