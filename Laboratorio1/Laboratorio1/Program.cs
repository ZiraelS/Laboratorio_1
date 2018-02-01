using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Defino variables
            int size = 0;
            string linea;

            do
            { //Pregunta de que tamaño quiere la matriz
                Console.Write("Defina tamaño de la matriz de Gato entre 3 y 10" + System.Environment.NewLine);
                linea = Console.ReadLine();
                size = int.Parse(linea);
            } while (size < 2 && size > 11);

            char[,] matriz = new char[size, size];//Defino la matriz

            for (int i = 0; i < size; i++) //Llena la matriz con espacios en blanco
            {
                for (int j = 0; j < size; j++)
                {
                    matriz[i, j] = '_';
                }
            }

            //Definir el simbolo de los jugadores
            //*
            //Definir el simbolo de los jugadores

            //Defino variables
            int turno = 1;
            int x;
            int y;
            bool ganox = false;
            bool ganoy = false;
            bool user = true;

            do
            { //Ciclo de juego hasta que se encuentre un ganador

                Console.Write("Turno " + turno + System.Environment.NewLine + System.Environment.NewLine);

                for (int i = 0; i < size; i++) //Muestra
                {
                    for (int j = 0; j < size; j++)
                    {
                        Console.Write(matriz[i, j] + " | ");
                    }
                    Console.Write(System.Environment.NewLine);
                }

                Console.Write(System.Environment.NewLine);
                Console.Write(System.Environment.NewLine);

                //Pregunto en que fila y columna quiere ingresar el dato
                Console.Write("Seleccione la fila de ingreso");
                linea = Console.ReadLine();
                x = int.Parse(linea);
                Console.Write("Seleccione la columna de ingreso");
                linea = Console.ReadLine();
                y = int.Parse(linea);

                for (int i = 0; i < size; i++) //Inserta dato
                {
                    if (x == i + 1)
                    {
                        for (int j = 0; j < size; j++)
                        {
                            if (y == j + 1)
                            {
                                //Validar que usuario esta jugando
                                matriz[i, j] = 'X';
                                //Validar que usuario esta jugando
                            }
                        }
                        Console.Write(System.Environment.NewLine);
                    }
                }

                //Validar si se gano
                //*
                //Validar si se gano

                Console.Write(System.Environment.NewLine);
                Console.Write(System.Environment.NewLine);
                turno++;
            } while (ganox != true || ganoy != true);

            Console.Write("Felicidades Jugador");

            Console.ReadLine();// System Pause
        }
    }
}
