using System;

namespace EjerciciosTarea.ejercicios
{
    public class Ejercicio6
    {
          public void Ejecutar()
        {
            Console.WriteLine("Ejercicio 1:");
            Console.WriteLine("bienvenido a la calculadora de areas y perimetros de figuras geometricas");
            Console.WriteLine("selecciona la figura geometrica que deseas calcular:");
            Console.WriteLine("1. Circulo");
            Console.WriteLine("2. Triangulo");
            Console.WriteLine("3. Rectangulo");
            Console.WriteLine("4.trapecio");
            // Leer opción del usuario y convertirla a double
            double opcion = double.Parse(Console.ReadLine());
            // Switch para ejecutar el cálculo según la figura seleccionada
            switch (opcion)
            {
                case 1:
                    Console.WriteLine("Has seleccionado Circulo");
                    Console.WriteLine("Ingresa el radio del circulo:");
                    double radio = double.Parse(Console.ReadLine());
                    // Formula area circulo: π * r²
                    double areaCirculo = 3.1416 * radio * radio;
                    // Formula perimetro circulo: 2 * π * r
                    double perimetroCirculo = 2 * 3.1416 * radio;
                    Console.WriteLine("El area del circulo es: " + areaCirculo);
                    Console.WriteLine("El perimetro del circulo es: " + perimetroCirculo);
                    break;
                case 2:
                    Console.WriteLine("Has seleccionado Triangulo");
                    Console.WriteLine("Ingresa la base del triangulo:");
                    double baseTriangulo = double.Parse(Console.ReadLine());
                    Console.WriteLine("Ingresa la altura del triangulo:");
                    double alturaTriangulo = double.Parse(Console.ReadLine());
                    Console.WriteLine("Ingresa el lado 1 del triangulo:");
                    double lado1Triangulo = double.Parse(Console.ReadLine());
                    Console.WriteLine("Ingresa el lado 2 del triangulo:");
                    double lado2Triangulo = double.Parse(Console.ReadLine());
                    Console.WriteLine("Ingresa el lado 3 del triangulo:");
                    double lado3Triangulo = double.Parse(Console.ReadLine());
                    // Formula area triangulo: (base * altura) / 2
                    double areaTriangulo = (baseTriangulo * alturaTriangulo) / 2;
                    // Formula perimetro: suma de los tres lados
                    double perimetroTriangulo = lado1Triangulo + lado2Triangulo + lado3Triangulo;
                    Console.WriteLine("El area del triangulo es: " + areaTriangulo);
                    Console.WriteLine("El perimetro del triangulo es: " + perimetroTriangulo);
                    break;
                case 3:
                    Console.WriteLine("Has seleccionado Rectangulo");
                    Console.WriteLine("Ingresa la base del rectangulo:");
                    double baseRectangulo = double.Parse(Console.ReadLine());
                    Console.WriteLine("Ingresa la altura del rectangulo:");
                    double alturaRectangulo = double.Parse(Console.ReadLine());
                    // Formula area rectangulo: base * altura
                    double areaRectangulo = baseRectangulo * alturaRectangulo;
                    // Formula perimetro rectangulo: 2 * (base + altura)
                    double perimetroRectangulo = 2 * (baseRectangulo + alturaRectangulo);
                    Console.WriteLine("El area del rectangulo es: " + areaRectangulo);
                    Console.WriteLine("El perimetro del rectangulo es: " + perimetroRectangulo);
                    break;
                case 4:
                    Console.WriteLine("Has seleccionado Trapecio");
                    Console.WriteLine("Ingresa la base mayor del trapecio:");
                    double baseMayorTrapecio = double.Parse(Console.ReadLine());
                    Console.WriteLine("Ingresa la base menor del trapecio:");
                    double baseMenorTrapecio = double.Parse(Console.ReadLine());
                    Console.WriteLine("Ingresa la altura del trapecio:");
                    double alturaTrapecio = double.Parse(Console.ReadLine());
                    Console.WriteLine("Ingresa el lado 1 del trapecio:");
                    double lado1Trapecio = double.Parse(Console.ReadLine());
                    Console.WriteLine("Ingresa el lado 2 del trapecio:");
                    double lado2Trapecio = double.Parse(Console.ReadLine());
                    // Formula area trapecio: ((base mayor + base menor) / 2) * altura
                    double areaTrapecio = ((baseMayorTrapecio + baseMenorTrapecio) / 2) * alturaTrapecio;
                    // Formula perimetro: suma de todas las bases y lados
                    double perimetroTrapecio = baseMayorTrapecio + baseMenorTrapecio + lado1Trapecio + lado2Trapecio;
                    Console.WriteLine("El area del trapecio es: " + areaTrapecio);
                    Console.WriteLine("El perimetro del trapecio es: " + perimetroTrapecio);
                    break;

            }            Pausa();
        }

        private void Pausa()
        {
            Console.WriteLine("Presiona Enter para continuar...");
            Console.ReadLine();
        }

    }
}