using System;

namespace Dominio.Especificaciones
{
    public class RealiceJugador2
    {
        public char RealizarJugador2(char fichaJ1)
        {
            char elJugador2;
            var laAccion = new Dominio.Acciones.HacerJugador2();
            elJugador2 = laAccion.CrearJugador2(fichaJ1);
            return elJugador2;
        }
    }
}