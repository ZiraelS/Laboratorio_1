using System;

namespace Dominio.Validaciones
{
    public class Dimenciones
    {
        //public bool Dimencion(int size)
        //{
        //    return size < 2 && size > 11;
        //}

        public bool Dimencion(int size)
        {
            if (size > 2)
            {
                if (size < 11)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
