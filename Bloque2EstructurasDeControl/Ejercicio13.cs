using System;

namespace EjerciciosTarea.Ejercicios
{
    public class Ejercicio13
    {
        public void Ejecutar()
        {
            Console.WriteLine("Ejercicio 13:");
            Console.WriteLine("Validador de fechas");

            Console.WriteLine("Ingresa el dia:");
            int diaIngresado = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingresa el mes:");
            int mesIngresado = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingresa el año:");
            int anioIngresado = int.Parse(Console.ReadLine());

            bool esBisiesto = false;
            if ((anioIngresado % 4 == 0 && anioIngresado % 100 != 0) || (anioIngresado % 400 == 0))
            {
                esBisiesto = true;
            }

            int diasDelMes = 0;

            if (mesIngresado < 1 || mesIngresado > 12)
            {
                Console.WriteLine("Mes invalido.");
                Pausa();
                return;
            }

            // Determinar dias del mes
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

            if (diaIngresado >= 1 && diaIngresado <= diasDelMes)
            {
                Console.WriteLine("La fecha es valida.");
            }
            else
            {
                Console.WriteLine("La fecha no es valida.");
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
