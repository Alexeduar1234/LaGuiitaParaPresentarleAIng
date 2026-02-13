using System;


namespace EjerciciosTarea.ejercicios
{
    public class Ejercicio11
    {
        
        public void Ejecutar()
        {
            Console.WriteLine("Ejercicio 11:");
            Console.WriteLine("bienvenido a la calculadora de descuentos");;
            Console.WriteLine("por favor, ingresa el Total que pagaras :");
            double Pagaras = double.Parse(Console.ReadLine());
            if (Pagaras >= 2500)
            {
                Console.WriteLine("tu descuento es del 15%");
                Console.WriteLine("tu total a pagar es: " + (Pagaras * 0.85));
            }
            else if (Pagaras >= 1000 && Pagaras < 2499)
            {
                Console.WriteLine("tu descuento es del 10%");
                Console.WriteLine("tu total a pagar es: " + (Pagaras * 0.90));
            }
            else if (Pagaras >= 500 && Pagaras < 999)
            {
                Console.WriteLine("tu descuento es del 5%");
                Console.WriteLine("tu total a pagar es: "+ (Pagaras * 0.95));
            }
            else if (Pagaras >= 0 && Pagaras < 499)
            {
                Console.WriteLine("no tienes descuento");
                Console.WriteLine("tu total a pagar es: " + Pagaras);
            }
            else if (Pagaras < 0)
            {
                Console.WriteLine("el valor ingresado no es valido, por favor intentalo de nuevo");
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