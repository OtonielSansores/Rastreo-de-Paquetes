using Rastreo_de_Paquetes.Interfaces;
using System;
using System.Collections.Generic;

namespace Rastreo_de_Paquetes
{
    public class ConvertirDatosArchivo : IConvertirDatosArchivo
    {
        public List<Pedidos> ConvertirAListaPedidos(string[] datosArchivo)
        {

            List<Pedidos> listaPedidos = new List<Pedidos>();
            string[] dato;
            foreach (string datoArchivo in datosArchivo)
            {
                if (!ValidarDatosArchivo(datoArchivo))
                {
                    dato = datoArchivo.Split(',');
                    Pedidos pedido = new Pedidos();
                    pedido.Origen = dato[0];
                    pedido.Destino = dato[1];
                    pedido.Distancia = Convert.ToDouble(dato[2]);
                    pedido.Paqueteria = dato[3];
                    pedido.MedioTransporte = dato[4];
                    pedido.FechaYHoraPedido = DateTime.Parse(dato[5]);

                    listaPedidos.Add(pedido);
                }
            }

            return listaPedidos;
        }

        private bool ValidarDatosArchivo(string datoArchivo)
        {
            return String.IsNullOrWhiteSpace(datoArchivo);
        }
    }
}
