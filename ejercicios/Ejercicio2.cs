using System;

namespace EjerciciosTarea.Ejercicios
{
    public class Ejercicio2
    {
        public void Ejecutar()
        {
            int opcion = 0;
            Console.WriteLine("Ejercicio 2:");
            Console.WriteLine("---------calculadora de conversion de temperaturas---------");
            Console.WriteLine("1. Celsius a Fahrenheit");
            Console.WriteLine("2. Fahrenheit a Celsius");
            Console.WriteLine("3. Celsius a Kelvin");
            opcion = int.Parse(Console.ReadLine());
            switch (opcion)
            {
                case 1:
                    Console.WriteLine("Has seleccionado Celsius a Fahrenheit");
                    Console.WriteLine("Ingresa la temperatura en Celsius:");
                    double celsius = double.Parse(Console.ReadLine());
                    double fahrenheit = (celsius * 9 / 5) + 32;
                    Console.WriteLine("la conversion es de:" + fahrenheit + " °F");
                    break;
                case 2:
                    Console.WriteLine("Has seleccionado Fahrenheit a Celsius");
                    Console.WriteLine("Ingresa la temperatura en Fahrenheit:");
                    fahrenheit = double.Parse(Console.ReadLine());
                    celsius = (fahrenheit - 32) * 5 / 9;
                    Console.WriteLine("la conversion es de:" + celsius + " °C");
                    break;
                case 3:
                    Console.WriteLine("Has seleccionado Celsius a Kelvin");
                    Console.WriteLine("Ingresa la temperatura en Celsius:");
                    celsius = double.Parse(Console.ReadLine());
                    double kelvin = celsius + 273.15;
                    Console.WriteLine("la conversion es de:" + kelvin + " K");
                    break;
                default:
                    Console.WriteLine("Opción inválida");
                    break;
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
