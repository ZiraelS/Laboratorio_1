using System;

namespace Laboratorio1.Dominio.Acciones
{
    public class HacerJugador2
    {
        public char CrearJugador2(char fichaJ1)
        {
            char elJugador2 = ' ';
            var laValidacion = new Dominio.Validaciones.Comprobar();
            bool valida = laValidacion.CaracterJugador(fichaJ1);
            if (valida)
            {
                if (fichaJ1.Equals('x'))
                {
                    elJugador2 = 'o';
                }
                else
                {
                    elJugador2 = 'x';
                }
                return elJugador2;
            }
            return elJugador2;
        }
    }
}