using Rastreo_de_Paquetes.Chain;

namespace Rastreo_de_Paquetes
{
    public class UltimaEmpresa : ICadenaPaqueteria
    {
        private readonly ICadenaPaqueteria _paqueteria;
        public UltimaEmpresa(ICadenaPaqueteria paqueteria)
        {
            _paqueteria = paqueteria;
        }
        private int margenUtilidad = 0;
        public int MargenUtilidad()
        {
            return margenUtilidad;
        }

        public void MargenUtilidad(int value)
        {
            margenUtilidad = value;
        }

        public int ObtenerMargenUtilidad(string medioTrasporte, string paqueteria)
        {
            return margenUtilidad;
        }

        public void SiguientePaqueteria(ICadenaPaqueteria paqueteria)
        {
            _paqueteria.SiguientePaqueteria(paqueteria);
        }
    }
}
