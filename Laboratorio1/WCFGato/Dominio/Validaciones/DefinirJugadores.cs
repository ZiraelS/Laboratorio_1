namespace Dominio.Validaciones
{
    public class DefinirJugadores
    {
        public bool CaracterJugador(char ficha)
        {
            return ficha.Equals('x') || ficha.Equals('o');
        }
    }
}