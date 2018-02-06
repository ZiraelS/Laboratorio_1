using System;

namespace Dominio.Validaciones
{
    public class ValidarGanador
    {
        public bool EsHorizontal(char[,] matriz, int size, char ficha, int fila, int columna)
        {
            if (columna + 2 < size)
            {
                if (matriz[fila, columna].Equals(ficha) && matriz[fila, columna + 1].Equals(ficha) && matriz[fila, columna + 2].Equals(ficha))
                {
                    return true;
                }
            }
            return false;
        }

        public bool EsVertical(char[,] matriz, int size, char ficha, int fila, int columna)
        {
            if (fila + 2 < size)
            {
                if (matriz[fila, columna].Equals(ficha) && matriz[fila + 1, columna].Equals(ficha) && matriz[fila + 2, columna].Equals(ficha))
                {
                    return true;
                }
            }
            return false;
        }

        public bool EsDiagonalD(char[,] matriz, int size, char ficha, int fila, int columna)
        {
            if (columna + 2 < size && fila +2 < size)
            {
                if (matriz[fila, columna].Equals(ficha) && matriz[fila + 1, columna + 1].Equals(ficha) && matriz[fila + 2, columna + 2].Equals(ficha))
                {
                    return true;
                }
            }
            return false;
        }

        public bool EsDiagonalI(char[,] matriz, int size, char ficha, int fila, int columna)
        {
            if (columna + 2 < size && fila + 2 < size)
            {
                if (matriz[fila, columna].Equals(ficha))
                {
                    if (fila - 1 > 0 && columna - 1 > 0)
                    {
                        if (matriz[fila - 1, columna - 1].Equals(ficha))
                        {
                            if (fila - 2 > 0 && columna - 2 > 0)
                            {
                                if (matriz[fila - 2, columna - 2].Equals(ficha))
                                {
                                    return true;
                                }
                            }
                        }
                    }
                    
                }
                //if (matriz[fila, columna].Equals(ficha) && matriz[fila - 1, columna - 1].Equals(ficha) && matriz[fila - 2, columna - 2].Equals(ficha))
                //{
                //    return true;
                //}
            }
            return false;
        }
    }
}