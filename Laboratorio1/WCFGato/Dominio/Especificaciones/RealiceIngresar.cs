using System;

namespace Dominio.Especificaciones
{
    public class RealiceIngresar
    {
        public bool RealizarIngresar(char[,] Matriz, int size, char ficha, int fila, int columna)
        {
            bool elResultado;
            var laAccion = new Dominio.Acciones.HacerIngresar();
            elResultado = laAccion.CrearIngresar(Matriz, size, ficha, fila, columna);
            return elResultado;
        }
    }
}