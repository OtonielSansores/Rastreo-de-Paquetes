using System;

namespace Rastreo_de_Paquetes
{
    public class Pedidos
    {
        public string Origen { get; set; }
        public string Destino { get; set; }
        public double Distancia { get; set; }
        public string Paqueteria { get; set; }
        public string MedioTransporte { get; set; }
        public DateTime FechaYHoraPedido { get; set; }
    }
}
