using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EjerciciosTarea.Bloque2EstructurasDeControl
{
    public class Ejercicio9
    {
                public void Ejecutar()
        {
            Console.WriteLine("Ejercicio 9:");
            Console.WriteLine("bienvenido a tu clasificadora de triangulos de confianza");
            Console.WriteLine("Por favor indica si quiere identificar tu triangulo por medio de sus lados o por medio de sus angulos");
            Console.WriteLine("1. Lados");
            Console.WriteLine("2. Angulos");
            int opcion = int.Parse(Console.ReadLine());
            switch (opcion)
            {
                case 1:
                    Console.WriteLine("Has seleccionado identificar por medio de los lados");
                    Console.WriteLine("Por favor, ingresa el valor del primer lado del triangulo:");
                    double lado1 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Por favor, ingresa el valor del segundo lado del triangulo:");
                    double lado2 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Por favor, ingresa el valor del tercer lado del triangulo:");
                    double lado3 = double.Parse(Console.ReadLine());
                    if (lado1 == lado2 && lado2 == lado3)
                    {
                        Console.WriteLine("Tu triangulo es equilatero");
                    }
                    else if (lado1 == lado2 || lado2 == lado3 || lado1 == lado3)
                    {
                        Console.WriteLine("Tu triangulo es isosceles");
                    }
                    else
                    {
                        Console.WriteLine("Tu triangulo es escaleno");
                    }
                    break;
                    
                    
                case 2:
                    Console.WriteLine("Has seleccionado identificar por medio de los angulos");
                    Console.WriteLine("Por favor, ingresa el valor del primer angulo del triangulo:");
                    double angulo1 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Por favor, ingresa el valor del segundo angulo del triangulo:");
                    double angulo2 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Por favor, ingresa el valor del tercer angulo del triangulo:");
                    double angulo3 = double.Parse(Console.ReadLine());
                    //si dos de los angulos son iguales, el triangulo es isosceles
                    if (angulo1 == 90 || angulo2 == 90 || angulo3 == 90)
                    {
                        Console.WriteLine("Tu triangulo es rectangulo");
                    }
                    else if (angulo1 > 90 || angulo2 > 90 || angulo3 > 90)
                    {
                        Console.WriteLine("Tu triangulo es obtusangulo");
                    }
                    else
                    {
                        Console.WriteLine("Tu triangulo es acutangulo");
                    }
                break;

            
        }Pausa();
        }

        private void Pausa()
        {
            Console.WriteLine("Presiona Enter para continuar...");
            Console.ReadLine();
        }
    }
}