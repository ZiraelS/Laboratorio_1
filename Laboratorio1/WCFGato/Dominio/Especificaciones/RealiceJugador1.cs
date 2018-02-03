using System;

namespace Dominio.Especificaciones
{
    public class RealiceJugador1
    {
        public char RealizarJugador1(char ficha)
        {
            char elJugador1;
            var laAccion = new Dominio.Acciones.HacerJugador1();
            elJugador1 = laAccion.CrearJugador1(ficha);
            return elJugador1;
        }
    }
}