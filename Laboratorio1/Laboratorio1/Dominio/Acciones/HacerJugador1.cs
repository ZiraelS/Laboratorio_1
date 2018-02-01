using System;

namespace Laboratorio1.Dominio.Acciones
{
    public class HacerJugador1
    {
        public char CrearJugador1(char ficha)
        {
            char elJugador1 = ' ';
            var laValidacion = new Dominio.Validaciones.Comprobar();
            bool valida = laValidacion.CaracterJugador(ficha);
            if (valida)
            {
                if (ficha.Equals('x'))
                {
                    elJugador1 = 'x';
                }
                else
                {
                    elJugador1 = 'o';
                }
                return elJugador1;
            }
            return elJugador1;
        }
    }
}