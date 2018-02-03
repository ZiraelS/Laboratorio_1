using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WCFGato
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

        [OperationContract]
        string MostrarMatriz(char[,] Matriz);

        [OperationContract]
        bool IngresarDato(char[,] Matriz, char ficha, int fila, int columna);

        //[OperationContract]
        //bool HayGanador(int[] i, int j);

        //[OperationContract]
        //bool DefinirSiHayGanador(int[,] i, int j);



        //WCF
        [OperationContract]
        string GetData(int value);

        [OperationContract]
        CompositeType GetDataUsingDataContract(CompositeType composite);

        // TODO: Add your service operations here
    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class CompositeType
    {
        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }
    }
}
