using System;

namespace EjerciciosTarea.Ejercicios
{
    public class Ejercicio14
    {
        public void Ejecutar()
        {
            Console.Clear();

            int CantidadEnCuenta = 1000;
            int[] billetes = { 500, 200, 100, 50, 20 };
            
            Console.WriteLine("Ejercicio 14:");
            Console.WriteLine("Bienvenido al Cajero Automatico de Alex's Bank");
            Console.WriteLine("Por favor, indique su nombre:");
            
            string NombreCliente = Console.ReadLine();

            Console.WriteLine("Hola " + NombreCliente + 
                              ", su saldo actual es de: " + CantidadEnCuenta + " Lempiras");

            Console.WriteLine("Cuanto dinero desea retirar?");
            int Retiro = int.Parse(Console.ReadLine());

            if (Retiro <= 0)
            {
                Console.WriteLine("La cantidad indicada no es valida.");
            }
            else if (Retiro > CantidadEnCuenta)
            {
                Console.WriteLine("No tiene suficiente dinero en su cuenta.");
            }
            else if (Retiro % 20 != 0)
            {
                Console.WriteLine("El monto debe ser multiplo de 20.");
            }
            else
            {
                Console.WriteLine("Retiro aprobado.");
                Console.WriteLine("Desglose de billetes:");

                int montoRestante = Retiro;

                for (int i = 0; i < billetes.Length; i++)
                {
                    int cantidadBilletes = montoRestante / billetes[i];

                    if (cantidadBilletes > 0)
                    {
                        Console.WriteLine("Billetes de " + billetes[i] + 
                                          ": " + cantidadBilletes);
                        montoRestante = montoRestante % billetes[i];
                    }
                }

                CantidadEnCuenta -= Retiro;

                Console.WriteLine("Su nuevo saldo es: " + CantidadEnCuenta + " Lempiras");
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
