using System;

namespace Dominio.Acciones
{
    public class HacerGanador
    {
        public bool CrearGanador(char[,] matriz, int size, char ficha)
        {
            bool elResultado = false;
            bool horizontal = false;
            bool vertical = false;
            bool diagonalD = false;
            bool diagonalI = false;
            var validacion = new Dominio.Validaciones.ValidarGanador();
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    horizontal = validacion.EsHorizontal(matriz, size, ficha, i, j);
                    vertical = validacion.EsVertical(matriz, size, ficha, i, j);
                    diagonalD = validacion.EsDiagonalD(matriz, size, ficha, i, j);
                    diagonalI = validacion.EsDiagonalI(matriz, size, ficha, i, j);
                    if (horizontal == true || vertical == true || diagonalD == true || diagonalI == true)
                    {
                        return elResultado = true;
                    }
                }
            }
            return elResultado;
        }
    }
}