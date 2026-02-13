using System;


namespace EjerciciosTarea.ejercicios
{
    public class Ejercicio10
    {
        
        public void Ejecutar()
        {
            Console.WriteLine("Ejercicio 10:");
            Console.WriteLine("bienvenido al sistema de calificaciones de la UNAH (casi siempre esta caido)");;
            Console.WriteLine("por favor, ingresa tu calificacion en numeros (0-100) :");
            double calificacion = double.Parse(Console.ReadLine());

            if (calificacion >= 90 && calificacion <= 100)
            {
                Console.WriteLine("tu calificacion es A");
                Console.WriteLine("aprobo con excelencia");
            }
            else if (calificacion >= 80 && calificacion < 90)
            {
                Console.WriteLine("tu calificacion es B");
                Console.WriteLine("Aprobo");
            }
            else if (calificacion >= 70 && calificacion < 80)
            {
                Console.WriteLine("tu calificacion es C");
                Console.WriteLine("Aprobo");
            }
            else if (calificacion >= 65 && calificacion < 70)
            {
                Console.WriteLine("tu calificacion es D");
                Console.WriteLine("Aprobo raspando");
            }
            else if (calificacion >= 0 && calificacion < 65)
            {
                Console.WriteLine("tu calificacion es E");
                Console.WriteLine("Reprobo");
            }
            else 
            {
                Console.WriteLine("la calificacion que indicaste no es valida, por favor intentalo de nuevo");
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