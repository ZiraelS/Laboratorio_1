using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WCFGato
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
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

        public string MostrarMatriz(char[,] Matriz)
        {
            string elResultado = " ";
            var laEspecificacion = new Dominio.Especificaciones.RealiceMostrarMatriz();
            elResultado = laEspecificacion.RealizarMostrarMatriz(Matriz);
            return elResultado;
        }

        public bool IngresarDato(char[,] Matriz, char ficha, int fila, int columna)
        {
            bool elResultado = false;
            var laEspecificacion = new Dominio.Especificaciones.RealiceIngresar();
            elResultado = laEspecificacion.RealizarIngresar(Matriz, ficha, fila, columna);
            return elResultado;
        }



        //WCF
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }
    }
}
