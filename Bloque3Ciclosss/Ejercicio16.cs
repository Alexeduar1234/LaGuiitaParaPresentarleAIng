using System;

namespace EjerciciosTarea.Ejercicios
{
    public class Ejercicio16
    {
        public void Ejecutar()
        {
            Console.WriteLine("Ejercicio 16:");
            Console.WriteLine("Numeros primos en un rango");
            Console.WriteLine("Por favor, ingresa el primer numero del rango:");
            int Numero1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Por favor, ingresa el segundo numero del rango:");
            int Numero2 = int.Parse(Console.ReadLine());

            // Por si el usuario ingresa el rango al reves
            if (Numero1 > Numero2)
            {
                int temporal = Numero1;
                Numero1 = Numero2;
                Numero2 = temporal;
            }

            Console.WriteLine("Los numeros primos entre " + Numero1 + " y " + Numero2 + " son:");

            for (int i = Numero1; i <= Numero2; i++)
            {
                if (EsPrimo(i))
                {
                    Console.WriteLine(i);
                }
            }

            Pausa();
        }

        private bool EsPrimo(int numero)
        {
            if (numero <= 1)
                return false;

            for (int i = 2; i < numero; i++)
            {
            if (numero % i == 0){return false;}
            }

            return true;
        }

        private void Pausa()
        {
            Console.WriteLine("Presiona Enter para continuar...");
            Console.ReadLine();
        }
    }
}
