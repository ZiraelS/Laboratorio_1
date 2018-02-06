using System;

namespace Dominio.Especificaciones
{
    public class RealiceGanador
    {
        public bool RealizarGanador(char[,] matriz, int size, char ficha)
        {
            bool elResultado;
            var laAccion = new Dominio.Acciones.HacerGanador();
            elResultado = laAccion.CrearGanador(matriz, size, ficha);
            return elResultado;
        }
    }
}