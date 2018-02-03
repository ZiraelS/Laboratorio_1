using System;

namespace Dominio.Validaciones
{
    public class Dimenciones
    {
        public bool Dimencion(int size)
        {
            return size < 2 && size > 11;
        }
    }
}
