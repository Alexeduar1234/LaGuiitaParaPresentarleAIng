using System;

namespace EjerciciosTarea.ejercicios
{
    public class Ejercicio12
    {
        public void Ejecutar()
        {
            Console.WriteLine("Ejercicio 12:");
            Console.WriteLine("Año bisiesto y dias del mes");

            Console.WriteLine("Ingresa el año:");
            int anioIngresado = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingresa el mes (1-12):");
            int mesIngresado = int.Parse(Console.ReadLine());

            bool esBisiesto = false;

            if ((anioIngresado % 4 == 0 && anioIngresado % 100 != 0) || (anioIngresado % 400 == 0))
            {
                esBisiesto = true;
                Console.WriteLine("Es un año bisiesto.");
            }
            else
            {
                Console.WriteLine("No es un año bisiesto.");
            }

            int diasDelMes = 0;

            if (mesIngresado == 1 || mesIngresado == 3 || mesIngresado == 5 ||
                mesIngresado == 7 || mesIngresado == 8 || mesIngresado == 10 || mesIngresado == 12)
            {
                diasDelMes = 31;
            }
            else if (mesIngresado == 4 || mesIngresado == 6 ||
                     mesIngresado == 9 || mesIngresado == 11)
            {
                diasDelMes = 30;
            }
            else if (mesIngresado == 2)
            {
                if (esBisiesto)
                    diasDelMes = 29;
                else
                    diasDelMes = 28;
            }
            else
            {
                Console.WriteLine("Mes invalido.");
                Pausa();
                return;
            }

            Console.WriteLine("El mes tiene " + diasDelMes + " dias.");

            Pausa();
        }

        private void Pausa()
        {
            Console.WriteLine("Presiona Enter para continuar...");
            Console.ReadLine();
        }
    }
}
