using System;

namespace Dominio.Acciones
{
    public class HacerMostrarMatriz
    {
        public string CrearMostrarMatriz(char[,] matriz, int size)
        {
            string elResultado = "";
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    elResultado = elResultado + matriz[i, j] + " | ";
                }
                elResultado = elResultado + " \n";
            }
            Console.Write("\n\n");
            return elResultado;
        }
    }
}