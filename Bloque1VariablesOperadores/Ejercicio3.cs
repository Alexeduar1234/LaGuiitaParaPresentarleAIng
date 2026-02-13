using System;

namespace EjerciciosTarea.Ejercicios
{
    public class Ejercicio3
    {
        public void Ejecutar()
        {
            // arreglo 'billetes contiene denominaciones disponibles
            int[] billetes = { 500, 100, 50, 20, 10, 5, 2, 1 };
            Console.WriteLine("Ejercicio 3:");
            Console.WriteLine("cambio de lempiras a sus respectivos billetes");
            Console.WriteLine("ingrese una cantidad de lempiras");
            double cantidad = double.Parse(Console.ReadLine());
            //validar que la cantidad sea positiva
            if (cantidad < 0)
            {
                Console.WriteLine("la cantidad que indicaste no es valida, por favor intentalo de nuevo");
                return;
            }
            Console.WriteLine("la cantidad de lempiras que ingresaste es: " + cantidad);
            Console.WriteLine("el cambio de lempiras a billetes es:");
            // Foreach para recorrer el arreglo de billetes y calcular la cantidad de cada billete necesarria
            foreach (int billete in billetes)
            {
                int cantidadBilletes = (int)(cantidad / billete);
            // Si la cantidad de billetes es mayor a 0 se muestra la cantidad de billetes y se realiza la operacion
                if (cantidadBilletes > 0)
                {
                    Console.WriteLine(cantidadBilletes + " billetes de " + billete + " lempiras");
                    cantidad -= cantidadBilletes * billete;
                }
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
