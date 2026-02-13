using System;

namespace EjerciciosTarea.Ejercicios
{
    public class Ejercicio29
    {
        public void Ejecutar()
        {
            Console.WriteLine("Ejercicio 29:");
            Console.WriteLine("Juego de Gato (Tic-Tac-Toe)");

            char[,] tablero = new char[3, 3];
            bool jugarOtraVez = true;

            while (jugarOtraVez)
            {
                InicializarTablero(tablero);
                char jugadorActual = 'X';
                bool hayGanador = false;
                int movimientos = 0;

                while (!hayGanador && movimientos < 9)
                {
                    MostrarTablero(tablero);

                    Console.WriteLine("Turno del jugador " + jugadorActual);
                    Console.Write("Fila (1-3): ");
                    int fila = int.Parse(Console.ReadLine()) - 1; // Restamos 1
                    Console.Write("Columna (1-3): ");
                    int columna = int.Parse(Console.ReadLine()) - 1; // Restamos 1

                    // Validar movimiento
                    if (fila < 0 || fila > 2 || columna < 0 || columna > 2)
                    {
                        Console.WriteLine("Posición inválida.");
                        continue;
                    }

                    if (tablero[fila, columna] != ' ')
                    {
                        Console.WriteLine("Esa casilla ya está ocupada.");
                        continue;
                    }

                    tablero[fila, columna] = jugadorActual;
                    movimientos++;

                    if (VerificarGanador(tablero, jugadorActual))
                    {
                        MostrarTablero(tablero);
                        Console.WriteLine("El jugador " + jugadorActual + " ha ganado!");
                        hayGanador = true;
                    }
                    else
                    {
                        // Cambiar jugador
                        jugadorActual = (jugadorActual == 'X') ? 'O' : 'X';
                    }
                }

                if (!hayGanador)
                {
                    MostrarTablero(tablero);
                    Console.WriteLine("Empate!");
                }

                Console.WriteLine("¿Desea jugar otra vez? (s/n)");
                string respuesta = Console.ReadLine();
                if (respuesta.ToLower() != "s")
                {
                    jugarOtraVez = false;
                }
            }

            Pausa();
        }

        private void InicializarTablero(char[,] tablero)
        {
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                    tablero[i, j] = ' ';
        }

        private void MostrarTablero(char[,] tablero)
        {
            Console.WriteLine();
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(" " + tablero[i, 0] + " | " + tablero[i, 1] + " | " + tablero[i, 2]);
                if (i < 2)
                    Console.WriteLine("---|---|---");
            }
            Console.WriteLine();
        }

        private bool VerificarGanador(char[,] tablero, char jugador)
        {
            // Filas y columnas
            for (int i = 0; i < 3; i++)
            {
                if (tablero[i, 0] == jugador && tablero[i, 1] == jugador && tablero[i, 2] == jugador)
                    return true;

                if (tablero[0, i] == jugador && tablero[1, i] == jugador && tablero[2, i] == jugador)
                    return true;
            }

            // Diagonales
            if (tablero[0, 0] == jugador && tablero[1, 1] == jugador && tablero[2, 2] == jugador)
                return true;

            if (tablero[0, 2] == jugador && tablero[1, 1] == jugador && tablero[2, 0] == jugador)
                return true;

            return false;
        }

        private void Pausa()
        {
            Console.WriteLine("Presiona Enter para continuar...");
            Console.ReadLine();
        }
    }
}
