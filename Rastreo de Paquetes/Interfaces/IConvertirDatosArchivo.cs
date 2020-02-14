using System.Collections.Generic;

namespace Rastreo_de_Paquetes.Interfaces
{
    public interface IConvertirDatosArchivo
    {
        List<Pedidos> ConvertirAListaPedidos(string[] datosArchivo);
    }
}
