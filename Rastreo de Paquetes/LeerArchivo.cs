using Rastreo_de_Paquetes.Interfaces;
using System.IO;

namespace Rastreo_de_Paquetes
{
    public class LeerArchivo : ILeerArchivo
    {
        public string[] ObtenerDatosArchivo(string ruta)
        {
            string[] datosArchivoTexto = File.ReadAllLines(ruta);
            return datosArchivoTexto;
        }

    }
}
