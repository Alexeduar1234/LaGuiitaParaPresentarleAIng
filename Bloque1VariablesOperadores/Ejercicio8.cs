using System;


namespace EjerciciosTarea.ejercicios
{
    public class Ejercicio8
    {
        
        public void Ejecutar()
        {
            Console.WriteLine("Ejercicio 8:");
            Console.WriteLine("bienvenido a la calculadora de salario semanal");
            Console.WriteLine("pro favor, indica las horas que trabajaste durante la semana :");
            double horasTrabajadas = double.Parse(Console.ReadLine());
            if (horasTrabajadas <= 0)
            {
                Console.WriteLine("la cantidad de horas que indicaste no es valida, por favor intentalo de nuevo");
                return;
            }
            Console.WriteLine("Ahora indica cual es el valor de hora que te pagan :");
            double valorHora = double.Parse(Console.ReadLine());
            if (valorHora <= 0)
            {
                Console.WriteLine("la cantidad que indicaste no es valida, por favor intentalo de nuevo");
                return;
            }
            double salarioSemanal = horasTrabajadas * valorHora;
            Console.WriteLine("su salario semanal es:" + salarioSemanal);
            double horasExtras = horasTrabajadas - 44;
            if (horasTrabajadas > 44) { Console.WriteLine("tu cantidad de horas extras (con un incremento del) es de :" + (horasExtras));}
            double totalHorasExtras = horasExtras * valorHora * 1.5;
            double salarioTotal = salarioSemanal + totalHorasExtras;
            Console.WriteLine("su salario total con horas extras es:" + salarioTotal);
            Pausa();
        }

        private void Pausa()
        {
            Console.WriteLine("Presiona Enter para continuar...");
            Console.ReadLine();
        }
    }
}