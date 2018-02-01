using System;

namespace Laboratorio1.Dominio.Especificaciones
{
    public class RealiceMatriz
    {
        public char[,] RealizarMatriz(int size)
        {
            char[,] laMatriz;
            var laAccion = new Dominio.Acciones.HacerMatriz();
            laMatriz = laAccion.CrearMatriz(size);
            return laMatriz;
        }
    }
}
