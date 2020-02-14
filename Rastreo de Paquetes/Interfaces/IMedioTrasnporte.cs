namespace Rastreo_de_Paquetes.Interfaces
{
    public interface IMedioTrasnporte
    {
        double VelocidadEntrega();
        void VelocidadEntrega(double value);

        double CostoXkm();
        void CostoXkm(double value);
    }
}
