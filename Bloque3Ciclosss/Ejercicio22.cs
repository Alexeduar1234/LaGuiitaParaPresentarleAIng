using System;

namespace EjerciciosTarea.Ejercicios
{
    public class Ejercicio22
    {
        public void Ejecutar()
        {
            Console.WriteLine("Ejercicio 30:");
            Console.WriteLine("Calculadora con menú");

            double ultimoResultado = 0;
            bool continuar = true;

            while (continuar)
            {
                Console.WriteLine("--- MENÚ DE OPERACIONES ---");
                Console.WriteLine("1. Suma (+)");
                Console.WriteLine("2. Resta (-)");
                Console.WriteLine("3. Multiplicación (*)");
                Console.WriteLine("4. División (/)");
                Console.WriteLine("5. Potencia (^)");
                Console.WriteLine("6. Raíz cuadrada (√)");
                Console.WriteLine("7. Porcentaje (%)");
                Console.WriteLine("0. Salir");
                Console.Write("Selecciona una opción: ");

                string opcionTexto = Console.ReadLine();
                int opcion;

                if (!int.TryParse(opcionTexto, out opcion))
                {
                    Console.WriteLine("Opción inválida. Intenta de nuevo.");
                    continue;
                }

                double numero1 = 0;
                double numero2 = 0;
                double resultado = 0;

                switch (opcion)
                {
                    case 0:
                        continuar = false;
                        Console.WriteLine("Saliendo de la calculadora...");
                        break;

                    case 1:
                        Console.WriteLine("Ingrese el primer número (último resultado = " + ultimoResultado + "):");
                        numero1 = LeerNumeroConResultado(ultimoResultado);
                        Console.WriteLine("Ingrese el segundo número:");
                        numero2 = double.Parse(Console.ReadLine());
                        resultado = numero1 + numero2;
                        break;

                    case 2:
                        Console.WriteLine("Ingrese el primer número (último resultado = " + ultimoResultado + "):");
                        numero1 = LeerNumeroConResultado(ultimoResultado);
                        Console.WriteLine("Ingrese el segundo número:");
                        numero2 = double.Parse(Console.ReadLine());
                        resultado = numero1 - numero2;
                        break;

                    case 3:
                        Console.WriteLine("Ingrese el primer número (último resultado = " + ultimoResultado + "):");
                        numero1 = LeerNumeroConResultado(ultimoResultado);
                        Console.WriteLine("Ingrese el segundo número:");
                        numero2 = double.Parse(Console.ReadLine());
                        resultado = numero1 * numero2;
                        break;

                    case 4:
                        Console.WriteLine("Ingrese el primer número (último resultado = " + ultimoResultado + "):");
                        numero1 = LeerNumeroConResultado(ultimoResultado);
                        Console.WriteLine("Ingrese el segundo número:");
                        numero2 = double.Parse(Console.ReadLine());
                        if (numero2 == 0)
                        {
                            Console.WriteLine("Error: no se puede dividir entre 0.");
                            Pausa();
                            continue;
                        }
                        resultado = numero1 / numero2;
                        break;

                    case 5:
                        Console.WriteLine("Ingrese la base (último resultado = " + ultimoResultado + "):");
                        numero1 = LeerNumeroConResultado(ultimoResultado);
                        Console.WriteLine("Ingrese el exponente:");
                        numero2 = double.Parse(Console.ReadLine());
                        resultado = Math.Pow(numero1, numero2);
                        break;

                    case 6:
                        Console.WriteLine("Ingrese el número (último resultado = " + ultimoResultado + "):");
                        numero1 = LeerNumeroConResultado(ultimoResultado);
                        if (numero1 < 0)
                        {
                            Console.WriteLine("Error: no se puede calcular raíz cuadrada de un número negativo.");
                            Pausa();
                            continue;
                        }
                        resultado = Math.Sqrt(numero1);
                        break;

                    case 7:
                        Console.WriteLine("Ingrese el número (último resultado = " + ultimoResultado + "):");
                        numero1 = LeerNumeroConResultado(ultimoResultado);
                        Console.WriteLine("Ingrese el porcentaje a calcular:");
                        numero2 = double.Parse(Console.ReadLine());
                        resultado = (numero1 * numero2) / 100;
                        break;

                    default:
                        Console.WriteLine("Opción inválida. Intenta de nuevo.");
                        Pausa();
                        continue;
                }

                // Mostrar resultado y guardar
                if (opcion >= 1 && opcion <= 7)
                {
                    Console.WriteLine("Resultado: " + resultado);
                    ultimoResultado = resultado;
                }

                Pausa();
                Console.Clear();
            }
        }

        private double LeerNumeroConResultado(double ultimoResultado)
        {
            Console.WriteLine("Si deseas usar el último resultado, escribe 'r', de lo contrario ingresa un número:");
            string entrada = Console.ReadLine();

            if (entrada.ToLower() == "r")
                return ultimoResultado;

            double numero;
            if (double.TryParse(entrada, out numero))
                return numero;
            else
            {
                Console.WriteLine("Entrada inválida. Se usará 0.");
                return 0;
            }
        }

        private void Pausa()
        {
            Console.WriteLine("Presiona Enter para continuar...");
            Console.ReadLine();
        }
    }
}
