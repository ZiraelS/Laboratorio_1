using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Laboratorio1.Dominio.Interfaces
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        char[,] CrearMatriz(int size);

        [OperationContract]
        char DefinirJugador1(char ficha);

        [OperationContract]
        char DefinirJugador2(char ficha);
    }
}
