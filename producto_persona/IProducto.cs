using System;
using System.Collections.Generic;
using System.Text;

namespace producto_persona
{
    interface IProducto
    {
        string NombreDeDueno();
        string CantidadDeProducto();
        string llega();
        string registro();
        string MarcaDeProducto();
        string NumeroDeProducto();
        string CiudadDeDestino();
        string DireccionDondeDelEnvio();
        string MiNombre();
        string MiApellido();
        string MiCorreo();
        string MiNumero();
        string ProductoCodigo();
        string ProductoMarca();
        string TipoDeProducto();
    }
}
