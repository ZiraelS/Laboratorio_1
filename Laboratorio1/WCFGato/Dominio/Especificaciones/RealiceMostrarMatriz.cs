using System;

namespace Dominio.Especificaciones
{
    public class RealiceMostrarMatriz
    {
        public string RealizarMostrarMatriz(char[,] matriz, int size)
        {
            string elResultado = " ";
            var laAccion = new Dominio.Acciones.HacerMostrarMatriz();
            elResultado = laAccion.CrearMostrarMatriz(matriz, size);
            return elResultado;
        }
    }
}