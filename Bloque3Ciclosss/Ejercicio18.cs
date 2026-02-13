using System;
using System.Numerics;

namespace EjerciciosTarea.Ejercicios
{
    public class Ejercicio18
    {
        public void Ejecutar()
        {
            Console.WriteLine("Ejercicio 18:");
            Console.WriteLine("Bienvenido a tu calculadora de factoriales y permutaciones");
            Console.WriteLine("Por favor, indica un numero para calcular el factorial:");
            int numeroN = int.Parse(Console.ReadLine());

            Console.WriteLine("El factorial del numero es: " + Factorial(numeroN));

            Console.WriteLine("Ahora, por favor, ingresa un numero para calcular su permutacion (r):");
            int numeroR = int.Parse(Console.ReadLine());

            Console.WriteLine("La permutacion de " + numeroN + " y " + numeroR + " es: " 
                              + Permutacion(numeroN, numeroR));

            Pausa();
        }

        private long Factorial(int numero)
        {
            if (numero == 0 || numero == 1)
                return 1;

            int resultado = 1;

            for (int i = 2; i <= numero; i++)
            {
                resultado *= i;
            }

            return resultado;
        }

        private int Permutacion(int total, int seleccion)
        {
            if (seleccion > total)
                return 0;

            int resultado = 1;

            for (int i = total; i > total - seleccion; i--)
            {
                resultado *= i;
            }

            return resultado;
        }

        private void Pausa()
        {
            Console.WriteLine("Presiona Enter para continuar...");
            Console.ReadLine();
        }
    }
}