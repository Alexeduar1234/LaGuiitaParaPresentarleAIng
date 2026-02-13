using System;

namespace EjerciciosTarea.Ejercicios
{
    public class Ejercicio17
    {
        public void Ejecutar()
        {
            Console.WriteLine("Ejercicio 17:");
            Console.WriteLine("Serie de Fibonacci");
            Console.WriteLine("por favor, ingresa el numero de numeros de la serie que quieres visualizar :");
            int Cantidad = int.Parse(Console.ReadLine());
            int a = 0, b = 1, c;
            Console.WriteLine("Serie de Fibonacci:");
            for (int i = 1; i <= Cantidad; i++)
            {
                Console.Write(a + " ");
                c = a + b;
                a = b;
                b = c;
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
