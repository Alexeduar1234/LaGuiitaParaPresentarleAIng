using System;

namespace EjerciciosTarea.Ejercicios
{
    public class Ejercicio23
    {
        public void Ejecutar()
        {
            Console.WriteLine("Ejercicio 23:");
            Console.WriteLine("Estadisticas de calificaciones");
            int cantidadCalificaciones;

            Console.Write("Ingrese la cantidad de calificaciones: ");
            while (!int.TryParse(Console.ReadLine(), out cantidadCalificaciones) || cantidadCalificaciones <= 0)
            {
                Console.Write("Valor invalido. Ingrese un numero mayor que 0: ");
            }

            double[] calificaciones = new double[cantidadCalificaciones];

            for (int i = 0; i < cantidadCalificaciones; i++)
            {
                Console.Write($"Ingrese la calificacion #{i + 1}: ");
                while (!double.TryParse(Console.ReadLine(), out calificaciones[i]) || calificaciones[i] < 0 || calificaciones[i] > 100)
                {
                    Console.Write("Valor invalido. Ingrese una calificacion entre 0 y 100: ");
                }
            }

            double sumaCalificaciones = 0;
            double calificacionMaxima = calificaciones[0];
            double calificacionMinima = calificaciones[0];
            int cantidadAprobados = 0;
            int cantidadReprobados = 0;


            for (int i = 0; i < cantidadCalificaciones; i++)
            {
                sumaCalificaciones += calificaciones[i];

                if (calificaciones[i] > calificacionMaxima)
                    calificacionMaxima = calificaciones[i];

                if (calificaciones[i] < calificacionMinima)
                    calificacionMinima = calificaciones[i];

                if (calificaciones[i] >= 60)
                    cantidadAprobados++;
                else
                    cantidadReprobados++;
            }

            double promedioCalificaciones = sumaCalificaciones / cantidadCalificaciones;

            double sumaCuadradosDiferencias = 0;

            for (int i = 0; i < cantidadCalificaciones; i++)
            {
                sumaCuadradosDiferencias += Math.Pow(calificaciones[i] - promedioCalificaciones, 2);
            }

            double desviacionEstandar = Math.Sqrt(sumaCuadradosDiferencias / cantidadCalificaciones);

            Console.WriteLine("===== RESULTADOS =====");
            Console.WriteLine($"Promedio: {promedioCalificaciones:F2}");
            Console.WriteLine("Calificacion maxima:" + calificacionMaxima);
            Console.WriteLine("Calificacion minima:" + calificacionMinima);
            Console.WriteLine("Cantidad de aprobados:" + cantidadAprobados);
            Console.WriteLine("Cantidad de reprobados:" + cantidadReprobados);
            Console.WriteLine("Desviacion estandar:" + desviacionEstandar);

            Pausa();
        }

        private void Pausa()
        {
            Console.WriteLine("Presiona Enter para continuar...");
            Console.ReadLine();
        }
    }
}
