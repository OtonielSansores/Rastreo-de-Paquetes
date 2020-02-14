using Rastreo_de_Paquetes.Interfaces;
using System;
using System.Collections.Generic;

namespace Rastreo_de_Paquetes
{
    public class ObtenerMensaje : IObtenerMensaje
    {
        private readonly IProcesamiento _procesamiento;
        private readonly IMedioTrasnporte _medioTrasnporte;
        public ObtenerMensaje(IProcesamiento procesamiento, IMedioTrasnporte medioTrasnporte)
        {
            _procesamiento = procesamiento;
            _medioTrasnporte = medioTrasnporte;
        }
        public Expresiones ExpresionesMensaje(DateTime fechaEntrega, DateTime fechaActual)
        {
            Expresiones expresiones = new Expresiones();
            if (fechaEntrega < fechaActual)
            {
                expresiones.Expresion1 = "salió";
                expresiones.Expresion2 = "llegó";
                expresiones.Expresion3 = "hace";
                expresiones.Expresion4 = "tuvo";
                expresiones.ColorMensaje = "verde";
            }
            else
            {
                expresiones.Expresion1 = "ha salido";
                expresiones.Expresion2 = "llegará";
                expresiones.Expresion3 = "dentro de";
                expresiones.Expresion4 = "tendrá";
                expresiones.ColorMensaje = "amarillo";
            }
            return expresiones;
        }

        public Mensaje FormatoMensaje(Expresiones expresiones, string origen, string destino, int rangoTiempo, double costoEnvio, string paqueteria)
        {
            Mensaje mensaje = new Mensaje();
            mensaje.Texto = string.Format("Tu paquete {0} de {1} y {2} a {3} {4} {5} y {6} un costo de {7} (Cualquier reclamación con {8})", 
                                         expresiones.Expresion1, origen, expresiones.Expresion2, destino, expresiones.Expresion3, rangoTiempo, 
                                         expresiones.Expresion4, costoEnvio, paqueteria);
            mensaje.color = expresiones.ColorMensaje;
            return mensaje;
            
        }

        public void MensajeTransporteIncorrecto(string paqueteria, string medioTrasnporte)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(string.Format("{0} no ofrece el servicio de transporte {1}, " +
                "te recomendamos cotizar en otra empresa.", paqueteria, medioTrasnporte));
        }
        public void MensajePaqueteriaNoExistente(string paqueteria)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(string.Format("La paqueteria: {0} no se encuentra registrada en " +
                "nuestra red de distribución.", paqueteria));
        }

        public List<Mensaje> ObtenerListaMensajes(List<Pedidos> pedidos)
        {
            List<Mensaje> listMensajes = new List<Mensaje>();
            foreach (Pedidos pedido in pedidos)
            {
                Mensaje mensaje = new Mensaje();
                double velocidad = _medioTrasnporte.VelocidadEntrega();
                double tiempoTraslado = _procesamiento.TiempoTraslado(pedido.Distancia, velocidad);
                DateTime fechaEntrega = _procesamiento.FechaEntrega(pedido.FechaYHoraPedido, tiempoTraslado);
                int margenUtilidad = _procesamiento.ObtenerMargenUtilidad(pedido.MedioTransporte, pedido.Paqueteria);
                double costoEnvio = _procesamiento.CostoEnvio(_medioTrasnporte.CostoXkm(), pedido.Distancia, margenUtilidad);
                listMensajes.Add(mensaje);
            }
            return listMensajes;
        }
    }
}
