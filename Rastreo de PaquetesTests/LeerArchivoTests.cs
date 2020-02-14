using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;

namespace Rastreo_de_Paquetes.Tests
{
    [TestClass()]
    public class LeerArchivoTests
    {
        [TestMethod()]
        public void ObtenerDatosArchivo_SieteLineasEnElArchivo_DebeContenerSiete()
        {
            //Arrange
            LeerArchivo leerArchivo = new LeerArchivo();
            string ruta = Directory.GetCurrentDirectory() + @"\textoTest.txt";

            //Act
            string[] respuesta = leerArchivo.ObtenerDatosArchivo(ruta);

            //Assert
            Assert.AreEqual(7, respuesta.Length);
        }

    }
}