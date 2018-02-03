using System;

namespace Dominio.Especificaciones
{
    public class RealiceMostrarMatriz
    {
        public string RealizarMostrarMatriz(char[,] matriz)
        {
            string elResultado = " ";
            var laAccion = new Dominio.Acciones.HacerMostrarMatriz();
            elResultado = laAccion.CrearMostrarMatriz(matriz);
            return elResultado;
        }
    }
}