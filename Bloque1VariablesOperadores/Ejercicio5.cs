using System;

namespace EjerciciosTarea.ejercicios
{
    public class Ejercicio5
    {
        public void Ejecutar()
        {
            Console.WriteLine("Ejercicio 5:");
            Console.WriteLine("Calculadora de diferencia entre 2 horas (formato 24h)");

            Console.WriteLine("Ingrese la primera hora (formato HH:mm:ss):");
            string primeraHoraTexto = Console.ReadLine();

            Console.WriteLine("Ingrese la segunda hora (formato HH:mm:ss):");
            string segundaHoraTexto = Console.ReadLine();

            TimeSpan primeraHora;
            TimeSpan segundaHora;

            try
            {
                primeraHora = TimeSpan.Parse(primeraHoraTexto);
                segundaHora = TimeSpan.Parse(segundaHoraTexto);
            }
            catch
            {
                Console.WriteLine("El formato ingresado no es valido.");
                Pausa();
                return;
            }

            TimeSpan diferenciaTiempo;

            // Si la segunda hora es mayor, significa que paso medianoche
            if (segundaHora >= primeraHora)
            {
                diferenciaTiempo = segundaHora - primeraHora;
            }
            else
            {
                diferenciaTiempo = (TimeSpan.FromHours(24) - primeraHora) + segundaHora;
            }

            Console.WriteLine("Diferencia:");
            Console.WriteLine("Horas: " + diferenciaTiempo.Hours);
            Console.WriteLine("Minutos: " + diferenciaTiempo.Minutes);
            Console.WriteLine("Segundos: " + diferenciaTiempo.Seconds);

            Pausa();
        }

        private void Pausa()
        {
            Console.WriteLine("Presiona Enter para continuar...");
            Console.ReadLine();
        }
    }
}
