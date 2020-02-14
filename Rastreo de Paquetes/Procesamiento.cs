using Rastreo_de_Paquetes.Chain;
using Rastreo_de_Paquetes.Interfaces;
using System;

namespace Rastreo_de_Paquetes
{
    public class Procesamiento : IProcesamiento
    {
        public double CostoEnvio(double costoXKm, double distancia, double margenUtilidad)
        {
            return (costoXKm * distancia) * (1 + ( margenUtilidad / 100));
        }

        public DateTime FechaEntrega(DateTime fechaYhoraPedido, double tiempoTraslado)
        {
            
            return fechaYhoraPedido.AddHours(tiempoTraslado);
        }

        public double TiempoTraslado(double distancia, double velocidad)
        {
            return distancia / velocidad;
        }

        public int ObtenerMargenUtilidad(string medioTransporte, string paqueteria)
        {
            ICadenaPaqueteria estafeta = new Estafeta();
            ICadenaPaqueteria dhl = new Dhl();
            ICadenaPaqueteria fedex = new Fedex();
            estafeta.SiguientePaqueteria(dhl);
            estafeta.SiguientePaqueteria(fedex);

            return estafeta.ObtenerMargenUtilidad(medioTransporte, paqueteria);
        }
    }
}
