using System;

namespace EjerciciosTarea.ejercicios
{
    public class Ejercicio4
    {
         public void Ejecutar()
        {
            Console.WriteLine("Ejercicio 4:");
            Console.WriteLine("Calculadora de prestamos simples");
            Console.WriteLine("ingrese el monto del prestamo:");
            double monto = double.Parse(Console.ReadLine());
            if (monto <= 0)
            {
                Console.WriteLine("el monto que indicaste no es valido, por favor intentalo de nuevo");
                return;
            }
            Console.WriteLine("ingrese la tasa de interes anual (en porcentaje):");
            double tasaInteresAnual = double.Parse(Console.ReadLine());
            if (tasaInteresAnual < 0)
            {
                Console.WriteLine("la tasa de interes que indicaste no es valida, por favor intentalo de nuevo");
                return;
            }
            Console.WriteLine("ingrese el plazo del prestamo en meses:");
            int plazoMeses = int.Parse(Console.ReadLine());
            if (plazoMeses <= 0)
            {
                Console.WriteLine("el plazo que indicaste no es valido, por favor intentalo de nuevo");
                return;
            }
            double tasaInteresMensual = tasaInteresAnual / 12 / 100;
            double interesTotal = monto * tasaInteresMensual * plazoMeses;
            double montoTotal = monto + interesTotal;
            Console.WriteLine("el monto total a pagar al final del plazo es: " + montoTotal);
            Console.WriteLine("el interes total a pagar es: " + interesTotal);
            Console.WriteLine("el pago mensual es: " + (montoTotal / plazoMeses));
            Pausa();
        }

        private void Pausa()
        {
            Console.WriteLine("Presiona Enter para continuar...");
            Console.ReadLine();
        }
    }
}

