using Rastreo_de_Paquetes.Chain;

namespace Rastreo_de_Paquetes
{
    public class Fedex : ICadenaPaqueteria
    {
        private ICadenaPaqueteria _paqueteria;
       
        private int margenUtilidad = 50;
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
            if(medioTrasporte == "Barco" && paqueteria == "Fedex")
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