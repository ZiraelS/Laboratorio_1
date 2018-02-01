using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio1.Dominio.Validaciones
{
    public class Comprobar
    {
        public bool Dimencion(int size)
        {
            return size < 2 && size > 11;
        }

        public bool CaracterJugador(char ficha)
        {
            return ficha.Equals('x') || ficha.Equals('o');
        }
    }
}
