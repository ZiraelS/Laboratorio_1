using System;

namespace Laboratorio1.Dominio.Acciones
{
    public class HacerMatriz
    {
        public char[,] CrearMatriz(int size)
        {
            char[,] laMatriz = new char[0, 0];
            var laValidacion = new Dominio.Validaciones.Comprobar();
            bool valida = laValidacion.Dimencion(size);
            if (valida)
            {
                laMatriz = new char[size, size];
                for (int i = 0; i < size; i++)
                {
                    for (int j = 0; j < size; j++)
                    {
                        laMatriz[i, j] = '_';
                    }
                }
                return laMatriz;
            }
            return laMatriz;
        }
    }
}
