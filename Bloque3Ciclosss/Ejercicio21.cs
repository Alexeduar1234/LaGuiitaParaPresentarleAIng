using System;

namespace EjerciciosTarea.Ejercicios
{
    public class Ejercicio21
    {
        public void Ejecutar()
        {
            Console.WriteLine("Ejercicio 21:");
            Console.WriteLine("Patron de Asteriscos");
            Console.WriteLine("Por favor indica que figura quieres visualizar");
            Console.WriteLine("1. Triangulo");
            Console.WriteLine("2. Triangulo invertido");
            Console.WriteLine("3. Rombo");
            Console.WriteLine("4. Cuadrado hueco");
            Console.Write("Seleccione una opcion: ");

            int opcion;

            while (!int.TryParse(Console.ReadLine(), out opcion) || opcion < 1 || opcion > 4)
            {
                Console.Write("Opcion invalida. Ingrese un numero del 1 al 4: ");
            }

            int tamaño;
            Console.Write("Ingrese el tamaño (minimo 3): ");

            while (!int.TryParse(Console.ReadLine(), out tamaño) || tamaño < 3)
            {
                Console.Write("Valor invalido. Ingrese un numero mayor o igual a 3: ");
            }

            Console.WriteLine();

            switch (opcion)
            {
                case 1:
                    for (int i = 1; i <= tamaño; i++)
                    {
                        for (int j = 1; j <= i; j++)
                        {
                            Console.Write("*");
                        }
                        Console.WriteLine();
                    }
                    break;

                case 2:
                    for (int i = tamaño; i >= 1; i--)
                    {
                        for (int j = 1; j <= i; j++)
                        {
                            Console.Write("*");
                        }
                        Console.WriteLine();
                    }
                    break;

                case 3:
                    for (int i = 1; i <= tamaño; i++)
                    {
                        for (int espacio = 1; espacio <= tamaño - i; espacio++)
                            Console.Write(" ");

                        for (int estrella = 1; estrella <= (2 * i - 1); estrella++)
                            Console.Write("*");

                        Console.WriteLine();
                    }
                    for (int i = tamaño - 1; i >= 1; i--)
                    {
                        for (int espacio = 1; espacio <= tamaño - i; espacio++)
                            Console.Write(" ");

                        for (int estrella = 1; estrella <= (2 * i - 1); estrella++)
                            Console.Write("*");

                        Console.WriteLine();
                    }
                    break;

                case 4:
                    for (int i = 1; i <= tamaño; i++)
                    {
                        for (int j = 1; j <= tamaño; j++)
                        {
                            if (i == 1 || i == tamaño || j == 1 || j == tamaño)
                                Console.Write("*");
                            else
                                Console.Write(" ");
                        }
                        Console.WriteLine();
                    }
                    break;
            }

            Pausa();
        }

        private void Pausa()
        {
            Console.WriteLine("Presiona Enter para continuar...");
            Console.ReadLine();
        }
    }
}