using Rastreo_de_Paquetes.Interfaces;

namespace Rastreo_de_Paquetes.Factory
{
    public abstract class CrearTransporte
    {
        public IMedioTrasnporte NuevoTrasnporte(string medioTrasnporte)
        {
            IMedioTrasnporte nuevoTrasporte = new Barco();
            switch (medioTrasnporte)
            {
                case "Barco":
                    nuevoTrasporte = new Barco();
                    break;
                case "Avión":
                    nuevoTrasporte = new Avion();
                    break;
                case "Tren":
                    nuevoTrasporte = new Tren();
                    break;
            }
            return nuevoTrasporte;
        }
    }
}
