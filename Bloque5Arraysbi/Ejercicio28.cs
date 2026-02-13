using System;

namespace EjerciciosTarea.Ejercicios
{
    public class Ejercicio28
    {
        public void Ejecutar()
        {
            Console.WriteLine("Ejercicio 28:");
            Console.WriteLine("Matriz de notas por parcial");

            // notas[i,j] almacena la nota del estudiante i en el parcial j
            // promedioPorEstudiante[i] guarda el promedio del estudiante i
            
            Console.WriteLine("Ingrese la cantidad de estudiantes:");
            int cantidadEstudiantes = int.Parse(Console.ReadLine());

            double[,] notas = new double[cantidadEstudiantes, 3];
            double[] promedioPorEstudiante = new double[cantidadEstudiantes];
            double[] promedioPorParcial = new double[3];

            // Ingreso de notas
            for (int i = 0; i < cantidadEstudiantes; i++)
            {
                Console.WriteLine("\nEstudiante " + (i + 1));

                for (int j = 0; j < 3; j++)
                {
                    Console.Write("Nota del parcial " + (j + 1) + ": ");
                    notas[i, j] = double.Parse(Console.ReadLine());
                }
            }

            // Promedio por estudiante
            double mejorPromedioEstudiante = 0;
            int mejorEstudiante = 0;

            for (int i = 0; i < cantidadEstudiantes; i++)
            {
                double suma = 0;

                for (int j = 0; j < 3; j++)
                {
                    suma += notas[i, j];
                }

                promedioPorEstudiante[i] = suma / 3;
                Console.WriteLine("Promedio del estudiante " + (i + 1) + ": " + promedioPorEstudiante[i]);

                if (promedioPorEstudiante[i] > mejorPromedioEstudiante)
                {
                    mejorPromedioEstudiante = promedioPorEstudiante[i];
                    mejorEstudiante = i + 1;
                }
            }

            // Promedio por parcial
            double menorPromedioParcial = 100;
            int parcialMasDificil = 0;

            for (int j = 0; j < 3; j++)
            {
                double sumaParcial = 0;

                for (int i = 0; i < cantidadEstudiantes; i++)
                {
                    sumaParcial += notas[i, j];
                }

                promedioPorParcial[j] = sumaParcial / cantidadEstudiantes;
                Console.WriteLine("Promedio del parcial " + (j + 1) + ": " + promedioPorParcial[j]);

                if (promedioPorParcial[j] < menorPromedioParcial)
                {
                    menorPromedioParcial = promedioPorParcial[j];
                    parcialMasDificil = j + 1;
                }
            }

            Console.WriteLine("\nEl estudiante con mejor promedio es: Estudiante " + mejorEstudiante);
            Console.WriteLine("El parcial mas dificil fue: Parcial " + parcialMasDificil);

            Pausa();
        }

        private void Pausa()
        {
            Console.WriteLine("Presiona Enter para continuar...");
            Console.ReadLine();
        }
    }
}

