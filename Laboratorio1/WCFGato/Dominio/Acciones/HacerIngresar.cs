using System;

namespace Dominio.Acciones
{
    public class HacerIngresar
    {
        public bool CrearIngresar(char[,] Matriz, char ficha, int fila, int columna)
        {
            bool elResultado = false;
            bool limites = false;
            var losLimites = new Dominio.Validaciones.DentroDeLimites();
            limites = losLimites.EstaDentro(fila, columna, Matriz.Length+1);
            if (limites)
            {
                for (int i = 0; i < Matriz.Length; i++)
                {
                    if (fila == i + 1)
                    {
                        for (int j = 0; j < Matriz.Length; j++)
                        {
                            if (columna == j + 1)
                            {
                                Matriz[i, j] = ficha;
                                elResultado = true;
                            }
                        }
                    }
                }
            }
            return elResultado;
        }
    }
}