using Rastreo_de_Paquetes.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;

namespace Rastreo_de_Paquetes
{
    class Program
    {
        static void Main(string[] args)
        {
            ILeerArchivo leerArchivo = new LeerArchivo();
            IConvertirDatosArchivo convertirDatosArchivo = new ConvertirDatosArchivo();

            string ruta = Directory.GetCurrentDirectory() + @"\texto.txt";
            string [] datosArchivos = leerArchivo.ObtenerDatosArchivo(ruta);
            List<Pedidos> listaPedidos = convertirDatosArchivo.ConvertirAListaPedidos(datosArchivos);

           


            Console.ReadKey();
        }
    }
}
