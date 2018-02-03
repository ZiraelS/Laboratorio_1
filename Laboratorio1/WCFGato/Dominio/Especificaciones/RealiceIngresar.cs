using System;

namespace Dominio.Especificaciones
{
    public class RealiceIngresar
    {
        public bool RealizarIngresar(char[,] Matriz, char ficha, int fila, int columna)
        {
            bool elResultado;
            var laAccion = new Dominio.Acciones.HacerIngresar();
            elResultado = laAccion.CrearIngresar(Matriz, ficha, fila, columna);
            return elResultado;
        }
    }
}