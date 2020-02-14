using System;

namespace Rastreo_de_Paquetes.Interfaces
{
    public interface IProcesamiento
    {
        double TiempoTraslado(double distancia, double velocidad);

        DateTime FechaEntrega(DateTime fechaYhoraPedido, double tiempoTraslado);

        double CostoEnvio(double costoXKm, double distancia, double margenUtilidad);

        int ObtenerMargenUtilidad(string medioTransporte, string paqueteria);
    }
}
