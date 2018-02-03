using System;

namespace Dominio.Acciones
{
    public class HacerMostrarMatriz
    {
        public string CrearMostrarMatriz(char[,] matriz)
        {
            string elResultado = " ";
            for (int i = 0; i < matriz.Length; i++)
            {
                for (int j = 0; j < matriz.Length; j++)
                {
                    elResultado = elResultado + matriz[i, j] + " | ";
                }
                elResultado = elResultado + "\n";
            }
            return elResultado;
        }
    }
}