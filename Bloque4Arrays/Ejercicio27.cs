using System;

namespace EjerciciosTarea.Ejercicios
{
    public class Ejercicio27
    {
        public void Ejecutar()
        {
            Console.WriteLine("Ejercicio 27: Registro de temperaturas semanales\n");

            double[] temperaturas = new double[7];

            for (int i = 0; i < temperaturas.Length; i++)
            {
                Console.Write($"Ingrese la temperatura del día {i + 1}: ");
                temperaturas[i] = double.Parse(Console.ReadLine());
            }
            double sumaTemperaturas = 0;
            foreach (double t in temperaturas)
            {
                sumaTemperaturas += t;
            }
            double promedioSemanal = sumaTemperaturas / temperaturas.Length;

            double temperaturaMaxima = temperaturas[0];
            double temperaturaMinima = temperaturas[0];
            int diaMax = 1, diaMin = 1;

            for (int i = 1; i < temperaturas.Length; i++)
            {
                if (temperaturas[i] > temperaturaMaxima)
                {
                    temperaturaMaxima = temperaturas[i];
                    diaMax = i + 1;
                }
                if (temperaturas[i] < temperaturaMinima)
                {
                    temperaturaMinima = temperaturas[i];
                    diaMin = i + 1;
                }
            }

            Console.WriteLine($"Promedio semanal: {promedioSemanal:F2}°C");

            Console.WriteLine("Días sobre el promedio:");
            for (int i = 0; i < temperaturas.Length; i++)
            {
                if (temperaturas[i] > promedioSemanal)
                {
                    Console.WriteLine($"- Día {i + 1}: {temperaturas[i]}°C");
                }
            }

            Console.WriteLine($"\nDía más caluroso: Día {diaMax} con {temperaturaMaxima}°C");
            Console.WriteLine($"Día más frío: Día {diaMin} con {temperaturaMinima}°C");

            Console.WriteLine("\nVariación entre días consecutivos:");
            for (int i = 0; i < temperaturas.Length - 1; i++)
            {
                double variacion = temperaturas[i + 1] - temperaturas[i];
                Console.WriteLine($"Día {i + 1} a Día {i + 2}: {variacion:+0.00;-0.00}°C");
            }

            Pausa();
        }

        private void Pausa()
        {
            Console.WriteLine("\nPresiona Enter para continuar...");
            Console.ReadLine();
        }
    }
}