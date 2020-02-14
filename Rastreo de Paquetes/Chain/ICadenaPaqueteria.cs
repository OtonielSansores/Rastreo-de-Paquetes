namespace Rastreo_de_Paquetes.Chain
{
    public interface ICadenaPaqueteria
    {
        void SiguientePaqueteria(ICadenaPaqueteria paqueteria);
        int ObtenerMargenUtilidad(string medioTrasporte, string paqueteria);

    }
}
