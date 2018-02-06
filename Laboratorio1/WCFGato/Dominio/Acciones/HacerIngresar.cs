using System;

namespace Dominio.Acciones
{
    public class HacerIngresar
    {
        public bool CrearIngresar(char[,] Matriz, int size, char ficha, int fila, int columna)
        {
            bool elResultado = false;
            bool limites = false;
            bool vacio = false;
            var validacion = new Dominio.Validaciones.ValidarIngreso();
            limites = validacion.EstaDentro(fila, columna, size);
            if (limites)
            {
                for (int i = 0; i < size; i++)
                {
                    if (fila == i + 1)
                    {
                        for (int j = 0; j < size; j++)
                        {
                            if (columna == j + 1)
                            {
                                vacio = validacion.EstaVacio(Matriz, i, j);
                                if (vacio)
                                {
                                    Matriz[i, j] = ficha;
                                    return elResultado = true;
                                }
                                else
                                {
                                    Console.Write("Posicion invalida. \n");
                                    return elResultado;
                                }
                            }
                        }
                    }
                }
            }
            Console.Write("Posicion Invalida. \n");
            return elResultado;
        }
    }
}