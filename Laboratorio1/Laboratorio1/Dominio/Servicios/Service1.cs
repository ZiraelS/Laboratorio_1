using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Laboratorio1.Dominio.Servicios
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class Service1 : IService1
    {
        public char[,] CrearMatriz(int size)
        {
            char[,] laMatriz;
            var laEspecificacion = new Dominio.Especificaciones.RealiceMatriz();
            laMatriz = laEspecificacion.RealizarMatriz(size);
            return laMatriz;
        }

        public char DefinirJugador1(char ficha)
        {
            char elJugador1;
            var laEspecificacion = new Dominio.Especificaciones.RealiceJugador1();
            elJugador1 = laEspecificacion.RealizarJugador1(ficha);
            return elJugador1;
        }

        public char DefinirJugador2(char fichaJ1)
        {
            char elJugador2;
            var laEspecificacion = new Dominio.Especificaciones.RealiceJugador2();
            elJugador2 = laEspecificacion.RealizarJugador2(fichaJ1);
            return elJugador2;
        }
    }
}
