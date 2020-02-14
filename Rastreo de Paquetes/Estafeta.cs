using Rastreo_de_Paquetes.Chain;

namespace Rastreo_de_Paquetes
{
    public class Estafeta : ICadenaPaqueteria
    {
        private  ICadenaPaqueteria _paqueteria;
                
       
        public void SiguientePaqueteria(ICadenaPaqueteria paqueteria)
        {
            _paqueteria = paqueteria;
        }

        public int ObtenerMargenUtilidad(string medioTrasporte, string paqueteria)
        {
            if ((medioTrasporte == "Tren" && paqueteria == "Estafeta") || (medioTrasporte == "Barco" && paqueteria == "Estafeta"))
            {
                return 20;
            }
            else
            {
                return _paqueteria.ObtenerMargenUtilidad(medioTrasporte, paqueteria);
            }
        }        
    }
}
