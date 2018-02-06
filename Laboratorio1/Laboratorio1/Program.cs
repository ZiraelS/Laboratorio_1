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
            int size = 0;
            string linea;
            char[,] matriz;
            var wcf = new WCFGato.Service1();

            bool correcto = false;
            do
            { //Crear Matriz
                Console.Write("Defina tamaño de la matriz de Gato entre '3' y '10': ");
                linea = Console.ReadLine();
                size = int.Parse(linea);
                matriz = wcf.CrearMatriz(size);
                if (size > 2)
                {
                    if (size < 11)
                    {
                        correcto = true;
                    }
                }
            } while (correcto != true);


            char j1 = ' ';
            char j2 = ' ';
            char caracter;
            do
            { //Definir Jugadores
                Console.Write("Defina el simbolo del jugador 1, entre 'x' o 'o': ");
                linea = Console.ReadLine();
                caracter = Char.Parse(linea);
                j1 = wcf.DefinirJugador1(caracter);
                j2 = wcf.DefinirJugador2(caracter);
            } while (j1.Equals(' '));


            string vMatriz;
            int turno = 1;
            int fila;
            int columna;
            bool ingreso;
            bool ganoj1 = false;
            bool ganoj2 = false;
            bool salida = false;
            do
            { //Juego (Ingreso y Gane)
                if (turno % 2 != 0)
                {
                    Console.Write("Turno " + turno + ", Jugador 1.");
                }
                else
                {
                    Console.Write("Turno " + turno + ", Jugador 2.");
                }

                vMatriz = wcf.MostrarMatriz(matriz, size);
                Console.Write(vMatriz);


                do
                { //Ingreso
                    Console.Write("Seleccione la fila de ingreso: ");
                    linea = Console.ReadLine();
                    fila = int.Parse(linea);
                    Console.Write("Seleccione la columna de ingreso: ");
                    linea = Console.ReadLine();
                    columna = int.Parse(linea);
                    if (turno % 2 != 0)
                    {
                        ingreso = wcf.IngresarDato(matriz, size, j1, fila, columna);
                    }
                    else
                    {
                        ingreso = wcf.IngresarDato(matriz, size, j2, fila, columna);
                    }
                } while (ingreso != true);


                if (turno % 2 != 0)
                {
                    ganoj1 = wcf.HayGanador(matriz, size, j1);
                }
                else
                {
                    ganoj2 = wcf.HayGanador(matriz, size, j2);
                }


                Console.Write("\n\n");
                turno++;
                if (ganoj1 == true)
                {
                    salida = true;
                }
                else if (ganoj2 == true)
                {
                    salida = true;
                }
                else if (turno == matriz.Length)
                {
                    salida = true;
                }
            } while (salida == false);


            if (ganoj1 == true)
            {
                Console.Write("Felicidades Jugador 1, has ganado");
            }
            else if (ganoj2 == true)
            {
                Console.Write("Felicidades Jugador 2, has ganado");
            }
            else
            {
                Console.Write("Empate");
            }

            Console.ReadLine();// System Pause
        }
    }
}

//test
//int size = 3;
//string linea;
//char[,] matriz;
//var wcf = new WCFGato.Service1();
//matriz = wcf.CrearMatriz(size);
//char j1 = wcf.DefinirJugador1('x');
//char j2 = wcf.DefinirJugador2('x');
//test

//Dudas
//do
//{ //Crear Matriz
//    Console.Write("Defina tamaño de la matriz de Gato entre '3' y '10': ");
//    linea = Console.ReadLine();
//    size = int.Parse(linea);
//    matriz = wcf.CrearMatriz(size);
//} while (size > 2 && size < 11);

//while (ganoj1 == false || ganoj2 == false || turno != matriz.Length);