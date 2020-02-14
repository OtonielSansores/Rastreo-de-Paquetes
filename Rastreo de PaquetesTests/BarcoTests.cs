using Microsoft.VisualStudio.TestTools.UnitTesting;
using Rastreo_de_Paquetes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rastreo_de_Paquetes.Tests
{
    [TestClass()]
    public class BarcoTests
    {
        [TestMethod()]
        public void CostoEnvio_ParametrosCero_DebeRegresarCero()
        {
            //Arrange 
            Barco barco = new Barco();

            //Act
            //double resultado = barco.CostoEnvio(0, 0, 0);

            //Assert
            //Assert.AreEqual(0, resultado);
        }
    }
}