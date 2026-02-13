using System;

namespace EjerciciosTarea.Ejercicios
{
    public class Ejercicio1
    {
        public void Ejecutar()
        {
            Console.WriteLine("Ejercicio 1:");
            Console.WriteLine("bienvenido a la calculadora de indice de masa corporal (IMC)");
            Console.WriteLine("por favor, indica tu peso en kg :");
            //capturar el valor del peso y altura del usuario
            double peso = double.Parse(Console.ReadLine());
            //validar que el preso sea un valor positivo
            if (peso <= 0)
            {
                Console.WriteLine("el peso que indicaste no es valido, por favor intentalo de nuevo");
                return;
            }
            Console.WriteLine("por favor, indica tu altura en Metros :");
            double altura = double.Parse(Console.ReadLine());
            //validacion de altura positiva
            if (altura <= 0)
            {
                Console.WriteLine("la altura que indicaste no es valida, por favor intentalo de nuevo");
                return;
            }

            double imc = peso / (altura * altura);
            Console.WriteLine("su indice de masa corporal es:" + imc);

            //condiciones para determinar el estado de peso segun el imc de resultado
            if (imc < 18.5) { Console.WriteLine("estas por debajo de tu peso ideal"); }
            else if (imc >= 18.5 && imc < 25) { Console.WriteLine("estas en tu peso ideal"); }
            else if (imc >= 25 && imc < 30) { Console.WriteLine("estas por encima de tu peso ideal"); }
            else { Console.WriteLine("tienes obesidad"); }
            Pausa();
        }

        private void Pausa()
        {
            Console.WriteLine("Presiona Enter para continuar...");
            Console.ReadLine();
        }
    }
}
