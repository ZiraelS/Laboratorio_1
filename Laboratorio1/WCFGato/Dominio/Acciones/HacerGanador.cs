using System;

namespace Dominio.Acciones
{
    public class HacerGanador
    {
        public bool CrearGanador(char[,] matriz, int size, char ficha)
        {
            bool elResultado = false;
            var validacion = new Dominio.Validaciones.ValidarGanador();
            char[] vectorH = new char[size];
            char[] vectorV = new char[size];
            char[] vectorDD = new char[size];
            char[] vectorDI = new char[size];
            for (int i = 0; i < size; i++)
            {
                vectorDD[i] = ' ';
                vectorDI[i] = ' ';
            }
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    vectorH[j] = matriz[i, j];
                }
                elResultado = validacion.HayGanador(vectorH, 3, ficha);
                if (elResultado == true)
                {
                    return elResultado;
                }
            }

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    vectorV[j] = matriz[j, i];
                }
                elResultado = validacion.HayGanador(vectorV, 3, ficha);
                if (elResultado == true)
                {
                    return elResultado;
                }
            }

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if ((i + 2 < size) && (j + 2 < size))
                    {
                        for (int k = 0; (k < size) && (i + k < size) && (j + k < size); k++)
                        {
                            vectorDD[k] = matriz[i + k, j + k];
                        }
                    }
                    elResultado = validacion.HayGanador(vectorDD, 3, ficha);
                    if (elResultado == true)
                    {
                        return elResultado;
                    }
                }
            }

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if ((i + 2 < size) && (j + 2 < size))
                    {
                        if ((i - 2 >= 0) && (j - 2 >= 0))
                        {
                            for (int k = 0; (k < size) && (i - k < size) && (j - k < size); k++)
                            {
                                vectorDI[k] = matriz[i - k, j - k];
                            }
                        }
                    }
                    elResultado = validacion.HayGanador(vectorDI, 3, ficha);
                    if (elResultado == true)
                    {
                        return elResultado;
                    }
                }
            }
            return elResultado;
        }

        //public bool CrearGanador(char[,] matriz, int size, char ficha)
        //{
        //    bool elResultado = false;
        //    bool horizontal = false;
        //    bool vertical = false;
        //    bool diagonalD = false;
        //    bool diagonalI = false;
        //    var validacion = new Dominio.Validaciones.ValidarGanador();
        //    for (int i = 0; i < size; i++)
        //    {
        //        for (int j = 0; j < size; j++)
        //        {
        //            horizontal = validacion.EsHorizontal(matriz, size, ficha, i, j);
        //            vertical = validacion.EsVertical(matriz, size, ficha, i, j);
        //            diagonalD = validacion.EsDiagonalD(matriz, size, ficha, i, j);
        //            diagonalI = validacion.EsDiagonalI(matriz, size, ficha, i, j);
        //            if (horizontal == true || vertical == true || diagonalD == true || diagonalI == true)
        //            {
        //                return elResultado = true;
        //            }
        //        }
        //    }
        //    return elResultado;
        //}
    }
}