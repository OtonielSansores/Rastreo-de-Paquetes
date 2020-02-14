using Rastreo_de_Paquetes.Interfaces;

namespace Rastreo_de_Paquetes
{
    public class Avion : IMedioTrasnporte
    {
        private double velocidadEntrega = 600;
        private double costoXkm = 10;

        public double VelocidadEntrega()
        {
            return velocidadEntrega;
        }

        public void VelocidadEntrega(double value)
        {
            velocidadEntrega = value;
        }


        public double CostoXkm()
        {
            return costoXkm;
        }

        public void CostoXkm(double value)
        {
            costoXkm = value;
        }
    }
}
