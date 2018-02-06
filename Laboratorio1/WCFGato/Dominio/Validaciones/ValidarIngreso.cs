using System;

namespace Dominio.Validaciones
{
    public class ValidarIngreso
    {
        public bool EstaDentro(int fila, int columna, int size)
        {
            return fila < size+1 && columna < size+1;
        }

        public bool EstaVacio(char[,] matriz, int fila, int columna)
        {
            return matriz[fila, columna].Equals('_');
        }
    }
}