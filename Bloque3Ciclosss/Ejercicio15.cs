using System;

namespace EjerciciosTarea.Ejercicios
{
    public class Ejercicio15
    {
        public void Ejecutar()
        {
            Console.WriteLine("Ejercicio 15:");
            Console.WriteLine("Tabla de multiplicar extendida");
            Console.WriteLine("por favor, ingresa el numero que quieras, del que quieres saber sus multiplos hasta el 12:");
            int numero = int.Parse(Console.ReadLine());
            for (int i = 1; i <= 12; i++)
            {
                int resultado = numero * i;
                Console.WriteLine("Resultado: ");
                Console.WriteLine(numero + " x " + i + " = " + resultado);
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
