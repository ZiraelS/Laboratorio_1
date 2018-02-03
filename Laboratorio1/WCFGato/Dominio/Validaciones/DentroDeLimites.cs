using System;

namespace Dominio.Validaciones
{
    public class DentroDeLimites
    {
        public bool EstaDentro(int fila, int columna, int size)
        {
            return fila < size && columna < size;
        }
    }
}