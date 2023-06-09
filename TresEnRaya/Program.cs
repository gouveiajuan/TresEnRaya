using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TresEnRaya
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vamos a jugar 3 en raya.");

            while (Resultado == true)
            {
                MostrarTablero();
                Turno();
                Comprobar();
                if (Resultado == false)
                {
                    MostrarTablero();
                    Console.ReadKey();
                    break;
                }
                MostrarTablero();
                Turno2();
                Comprobar();
                if (Resultado == false)
                {
                    MostrarTablero();
                    Console.ReadKey();
                }
            }
        }

        public static char[] Tablero = { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' };
        public static bool Resultado = true;

        static void MostrarTablero()
        {
            Console.WriteLine("   |   |");
            Console.WriteLine(" " + Tablero[0] + " | " + Tablero[1] + " | " + Tablero[2]);
            Console.WriteLine("___|___|___");
            Console.WriteLine("   |   |");
            Console.WriteLine(" " + Tablero[3] + " | " + Tablero[4] + " | " + Tablero[5]);
            Console.WriteLine("___|___|___");
            Console.WriteLine("   |   |");
            Console.WriteLine(" " + Tablero[6] + " | " + Tablero[7] + " | " + Tablero[8]);
            Console.WriteLine("   |   |");
        }

        static void Turno()
        {
            Console.WriteLine("Turno para jugador 1 (X)");
            Console.WriteLine("Indica la posicion segun el orden:" +
            "\n0|1|2" + "\n3|4|5" + "\n6|7|8\n");
            int opcion = int.Parse(Console.ReadLine());

            if (Tablero[opcion] == ' ')

                switch (opcion)
                {
                    case 0:
                        Tablero[0] = 'X';
                        break;
                    case 1:
                        Tablero[1] = 'X';
                        break;
                    case 2:
                        Tablero[2] = 'X';
                        break;
                    case 3:
                        Tablero[3] = 'X';
                        break;
                    case 4:
                        Tablero[4] = 'X';
                        break;
                    case 5:
                        Tablero[5] = 'X';
                        break;
                    case 6:
                        Tablero[6] = 'X';
                        break;
                    case 7:
                        Tablero[7] = 'X';
                        break;
                    case 8:
                        Tablero[8] = 'X';
                        break;
                }
            else
            {
                Console.WriteLine("Ese espacio ya esta ocupado, debes elegir otra opción");
                Turno();
            }
        }
        static void Turno2()
        {
            Console.WriteLine("Turno para jugador 2 (0)");
            Console.WriteLine("Indica la posicion segun el orden:" +
            "\n0|1|2" + "\n3|4|5" + "\n6|7|8\n");
            int opcion = int.Parse(Console.ReadLine());

            if (Tablero[opcion] == ' ')

                switch (opcion)
                {
                    case 0:
                        Tablero[0] = 'O';
                        break;
                    case 1:
                        Tablero[1] = 'O';
                        break;
                    case 2:
                        Tablero[2] = 'O';
                        break;
                    case 3:
                        Tablero[3] = 'O';
                        break;
                    case 4:
                        Tablero[4] = 'O';
                        break;
                    case 5:
                        Tablero[5] = 'O';
                        break;
                    case 6:
                        Tablero[6] = 'O';
                        break;
                    case 7:
                        Tablero[7] = 'O';
                        break;
                    case 8:
                        Tablero[8] = 'O';
                        break;
                }
            else
            {
                Console.WriteLine("Ese espacio ya esta ocupado, debes elegir otra opción");
                Turno2();
            }
        }
        static void Comprobar()
        {
            if (Tablero[0] == 'X' && Tablero[1] == 'X' && Tablero[2] == 'X')
            {
                Console.WriteLine("Ha ganado jugador 1");
                Resultado = false;
            }
            else if (Tablero[3] == 'X' && Tablero[4] == 'X' && Tablero[5] == 'X')
            {
                Console.WriteLine("Ha ganado jugador 1");
                Resultado = false;
            }
            else if (Tablero[6] == 'X' && Tablero[7] == 'X' && Tablero[8] == 'X')
            {
                Console.WriteLine("Ha ganado jugador 1");
                Resultado = false;
            }
            else if (Tablero[0] == 'O' && Tablero[1] == 'O' && Tablero[2] == 'O')
            {
                Console.WriteLine("Ha ganado jugador 2");
                Resultado = false;
            }
            else if (Tablero[3] == 'O' && Tablero[4] == 'O' && Tablero[5] == 'O')
            {
                Console.WriteLine("Ha ganado jugador 2");
                Resultado = false;
            }
            else if (Tablero[6] == 'O' && Tablero[7] == 'O' && Tablero[8] == 'O')
            {
                Console.WriteLine("Ha ganado jugador 2");
                Resultado = false;
            }
            else if (Tablero[0] == 'X' && Tablero[3] == 'X' && Tablero[6] == 'X')
            {
                Console.WriteLine("Ha ganado jugador 1");
                Resultado = false;
            }
            else if (Tablero[1] == 'X' && Tablero[4] == 'X' && Tablero[7] == 'X')
            {
                Console.WriteLine("Ha ganado jugador 1");
                Resultado = false;
            }
            else if (Tablero[2] == 'X' && Tablero[5] == 'X' && Tablero[8] == 'X')
            {
                Console.WriteLine("Ha ganado jugador 1");
                Resultado = false;
            }
            else if (Tablero[0] == 'O' && Tablero[3] == 'O' && Tablero[6] == 'O')
            {
                Console.WriteLine("Ha ganado jugador 2");
                Resultado = false;
            }
            else if (Tablero[1] == 'O' && Tablero[4] == 'O' && Tablero[7] == 'O')
            {
                Console.WriteLine("Ha ganado jugador 2");
                Resultado = false;
            }
            else if (Tablero[2] == 'O' && Tablero[5] == 'O' && Tablero[8] == 'O')
            {
                Console.WriteLine("Ha ganado jugador 2");
                Resultado = false;
            }
            else if (Tablero[0] == 'X' && Tablero[4] == 'X' && Tablero[8] == 'X')
            {
                Console.WriteLine("Ha ganado jugador 1");
                Resultado = false;
            }
            else if (Tablero[2] == 'X' && Tablero[4] == 'X' && Tablero[6] == 'X')
            {
                Console.WriteLine("Ha ganado jugador 1");
                Resultado = false;
            }
            else if (Tablero[0] == 'O' && Tablero[4] == 'O' && Tablero[8] == 'O')
            {
                Console.WriteLine("Ha ganado jugador 2");
                Resultado = false;
            }
            else if (Tablero[2] == 'O' && Tablero[4] == 'O' && Tablero[6] == 'O')
            {
                Console.WriteLine("Ha ganado jugador 2");
                Resultado = false;
            }
            else if (Tablero[0] != ' ' && Tablero[1] != ' ' && Tablero[2] != ' ' &&
                     Tablero[3] != ' ' && Tablero[4] != ' ' && Tablero[5] != ' ' &&
                     Tablero[6] != ' ' && Tablero[7] != ' ' && Tablero[8] != ' ')
            {
                Console.WriteLine("Es un empate");
                Resultado = false;
            }
        }
    }
}