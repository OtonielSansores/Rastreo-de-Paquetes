using Rastreo_de_Paquetes.Chain;

namespace Rastreo_de_Paquetes
{
    public class Dhl : ICadenaPaqueteria
    {
        private  ICadenaPaqueteria _paqueteria;
        
        private int margenUtilidad = 40;
        public int MargenUtilidad()
        {
            return margenUtilidad;
        }

        public void MargenUtilidad(int value)
        {
            margenUtilidad = value;
        }
        public void SiguientePaqueteria(ICadenaPaqueteria paqueteria)
        {
            _paqueteria = paqueteria;
        }
        public int ObtenerMargenUtilidad(string medioTrasporte, string paqueteria)
        {
            if ((medioTrasporte == "Avión" && paqueteria == "DHL")|| (medioTrasporte == "Barco" && paqueteria == "DHL"))
            {
                return margenUtilidad;
            }
            else
            {
                return _paqueteria.ObtenerMargenUtilidad(medioTrasporte, paqueteria);
            }
        }

        
    }
}