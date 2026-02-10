using System;

namespace EjerciciosTarea.Ejercicios
{
    public class Ejercicio3
    {
        public void Ejecutar()
        {
            Console.WriteLine("Ejercicio 3:");
            Console.WriteLine("cambio de lempiras a sus respectivos billetes");
            Console.WriteLine("ingrese una cantidad de lempiras");
            double cantidad = double.Parse(Console.ReadLine());
            if (cantidad < 0)
            {
                Console.WriteLine("la cantidad que indicaste no es valida, por favor intentalo de nuevo");
                return;
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
