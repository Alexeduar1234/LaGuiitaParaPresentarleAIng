using System;

namespace EjerciciosTarea.Ejercicios
{
    public class Ejercicio19
    {
        public void Ejecutar()
        {
            Console.WriteLine("Ejercicio 19:");
            Console.WriteLine("Multiplicar matrices 2x2");
            Random random = new Random();
            int numeroAdescubrir = random.Next(1, 101);
            int intentos = 0;
            int numeroUsuario = 0;
            Console.WriteLine("Bienvenido al juego de adivinanza! pensare un numero entre 1 y 100.Intenta adivinarlo.");
            Console.WriteLine("recuerda que solo tienes 7 intentos para adivinar el numero");
            while (numeroUsuario != numeroAdescubrir)
            {
                Console.WriteLine("Ingresa tu intento:");
                numeroUsuario = int.Parse(Console.ReadLine());
                intentos++;

                if (intentos > 7)
                {
                    Console.WriteLine("Lo siento, has agotado tus intentos. El numero era: " + numeroAdescubrir);
                    break;
                }
                else if (numeroUsuario < numeroAdescubrir)
                {
                    Console.WriteLine("Demasiado bajo! Intenta de nuevo.");
                }
                else if (numeroUsuario > numeroAdescubrir)
                {
                    Console.WriteLine("Demasiado alto! Intenta de nuevo.");
                }
                else
                {
                    Console.WriteLine("Felicidades! Has adivinado el numero en " + intentos + " intentos.");
                    break;
                }

            
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
