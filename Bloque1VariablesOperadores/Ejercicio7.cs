
using System;

namespace EjerciciosTarea.Ejercicios
{
    public class Ejercicio7
    {
        public void Ejecutar()
        {
            int opcion = 0;
            Console.WriteLine("Ejercicio 7:");
            Console.WriteLine("bienvenido a tu convertidor de unidades de almacenamiento bytes de confianza");
            Console.WriteLine("a continuacion se te mostrara un menu con las opciones de conversion, selecciona la que deseas realizar:");
            Console.WriteLine("--- Conversiones desde Bytes ---");
            Console.WriteLine("1. Bytes a Kilobytes (KB)");
            Console.WriteLine("2. Bytes a Megabytes (MB)");
            Console.WriteLine("3. Bytes a Gigabytes (GB)");
            Console.WriteLine("4. Bytes a Terabytes (TB)");
            Console.WriteLine("--- Conversiones desde Kilobytes ---");
            Console.WriteLine("5. Kilobytes a Bytes");
            Console.WriteLine("6. Kilobytes a Megabytes (MB)");
            Console.WriteLine("7. Kilobytes a Gigabytes (GB)");
            Console.WriteLine("8. Kilobytes a Terabytes (TB)");
            Console.WriteLine("--- Conversiones desde Megabytes ---");
            Console.WriteLine("9. Megabytes a Bytes");
            Console.WriteLine("10. Megabytes a Kilobytes (KB)");
            Console.WriteLine("11. Megabytes a Gigabytes (GB)");
            Console.WriteLine("12. Megabytes a Terabytes (TB)");
            Console.WriteLine("--- Conversiones desde Gigabytes ---");
            Console.WriteLine("13. Gigabytes a Bytes");
            Console.WriteLine("14. Gigabytes a Kilobytes (KB)");
            Console.WriteLine("15. Gigabytes a Megabytes (MB)");
            Console.WriteLine("16. Gigabytes a Terabytes (TB)");
            Console.WriteLine("--- Conversiones desde Terabytes ---");
            Console.WriteLine("17. Terabytes a Bytes");
            Console.WriteLine("18. Terabytes a Kilobytes (KB)");
            Console.WriteLine("19. Terabytes a Megabytes (MB)");
            Console.WriteLine("20. Terabytes a Gigabytes (GB)");
            Console.WriteLine("21. Salir");

            opcion = int.Parse(Console.ReadLine());
            double valorEntrada;
            double resultadoConversion;
            
            switch (opcion)
            {
                case 1:
                    Console.WriteLine("Has seleccionado Bytes a Kilobytes (KB)");
                    Console.WriteLine("Ingresa la cantidad de bytes que deseas convertir:");
                    valorEntrada = double.Parse(Console.ReadLine());
                    resultadoConversion = valorEntrada / 1024;
                    Console.WriteLine("la conversion es de: " + resultadoConversion + " KB");
                    break;
                case 2:
                    Console.WriteLine("Has seleccionado Bytes a Megabytes (MB)");
                    Console.WriteLine("Ingresa la cantidad de bytes que deseas convertir:");
                    valorEntrada = double.Parse(Console.ReadLine());
                    resultadoConversion = valorEntrada / (1024 * 1024);
                    Console.WriteLine("la conversion es de: " + resultadoConversion + " MB");
                    break;
                case 3:
                    Console.WriteLine("Has seleccionado Bytes a Gigabytes (GB)");
                    Console.WriteLine("Ingresa la cantidad de bytes que deseas convertir:");
                    valorEntrada = double.Parse(Console.ReadLine());
                    resultadoConversion = valorEntrada / (1024 * 1024 * 1024);
                    Console.WriteLine("la conversion es de: " + resultadoConversion + " GB");
                    break;
                case 4:
                    Console.WriteLine("Has seleccionado Bytes a Terabytes (TB)");
                    Console.WriteLine("Ingresa la cantidad de bytes que deseas convertir:");
                    valorEntrada = double.Parse(Console.ReadLine());
                    resultadoConversion = valorEntrada / (1024.0 * 1024 * 1024 * 1024);
                    Console.WriteLine("la conversion es de: " + resultadoConversion + " TB");
                    break;
                case 5:
                    Console.WriteLine("Has seleccionado Kilobytes a Bytes");
                    Console.WriteLine("Ingresa la cantidad de kilobytes que deseas convertir:");
                    valorEntrada = double.Parse(Console.ReadLine());
                    resultadoConversion = valorEntrada * 1024;
                    Console.WriteLine("la conversion es de: " + resultadoConversion + " Bytes");
                    break;
                case 6:
                    Console.WriteLine("Has seleccionado Kilobytes a Megabytes (MB)");
                    Console.WriteLine("Ingresa la cantidad de kilobytes que deseas convertir:");
                    valorEntrada = double.Parse(Console.ReadLine());
                    resultadoConversion = valorEntrada / 1024;
                    Console.WriteLine("la conversion es de: " + resultadoConversion + " MB");
                    break;
                case 7:
                    Console.WriteLine("Has seleccionado Kilobytes a Gigabytes (GB)");
                    Console.WriteLine("Ingresa la cantidad de kilobytes que deseas convertir:");
                    valorEntrada = double.Parse(Console.ReadLine());
                    resultadoConversion = valorEntrada / (1024 * 1024);
                    Console.WriteLine("la conversion es de: " + resultadoConversion + " GB");
                    break;
                case 8:
                    Console.WriteLine("Has seleccionado Kilobytes a Terabytes (TB)");
                    Console.WriteLine("Ingresa la cantidad de kilobytes que deseas convertir:");
                    valorEntrada = double.Parse(Console.ReadLine());
                    resultadoConversion = valorEntrada / (1024.0 * 1024 * 1024);
                    Console.WriteLine("la conversion es de: " + resultadoConversion + " TB");
                    break;
                case 9:
                    Console.WriteLine("Has seleccionado Megabytes a Bytes");
                    Console.WriteLine("Ingresa la cantidad de megabytes que deseas convertir:");
                    valorEntrada = double.Parse(Console.ReadLine());
                    resultadoConversion = valorEntrada * (1024 * 1024);
                    Console.WriteLine("la conversion es de: " + resultadoConversion + " Bytes");
                    break;
                case 10:
                    Console.WriteLine("Has seleccionado Megabytes a Kilobytes (KB)");
                    Console.WriteLine("Ingresa la cantidad de megabytes que deseas convertir:");
                    valorEntrada = double.Parse(Console.ReadLine());
                    resultadoConversion = valorEntrada * 1024;
                    Console.WriteLine("la conversion es de: " + resultadoConversion + " KB");
                    break;
                case 11:
                    Console.WriteLine("Has seleccionado Megabytes a Gigabytes (GB)");
                    Console.WriteLine("Ingresa la cantidad de megabytes que deseas convertir:");
                    valorEntrada = double.Parse(Console.ReadLine());
                    resultadoConversion = valorEntrada / 1024;
                    Console.WriteLine("la conversion es de: " + resultadoConversion + " GB");
                    break;
                case 12:
                    Console.WriteLine("Has seleccionado Megabytes a Terabytes (TB)");
                    Console.WriteLine("Ingresa la cantidad de megabytes que deseas convertir:");
                    valorEntrada = double.Parse(Console.ReadLine());
                    resultadoConversion = valorEntrada / (1024.0 * 1024);
                    Console.WriteLine("la conversion es de: " + resultadoConversion + " TB");
                    break;
                case 13:
                    Console.WriteLine("Has seleccionado Gigabytes a Bytes");
                    Console.WriteLine("Ingresa la cantidad de gigabytes que deseas convertir:");
                    valorEntrada = double.Parse(Console.ReadLine());
                    resultadoConversion = valorEntrada * (1024 * 1024 * 1024);
                    Console.WriteLine("la conversion es de: " + resultadoConversion + " Bytes");
                    break;
                case 14:
                    Console.WriteLine("Has seleccionado Gigabytes a Kilobytes (KB)");
                    Console.WriteLine("Ingresa la cantidad de gigabytes que deseas convertir:");
                    valorEntrada = double.Parse(Console.ReadLine());
                    resultadoConversion = valorEntrada * (1024 * 1024);
                    Console.WriteLine("la conversion es de: " + resultadoConversion + " KB");
                    break;
                case 15:
                    Console.WriteLine("Has seleccionado Gigabytes a Megabytes (MB)");
                    Console.WriteLine("Ingresa la cantidad de gigabytes que deseas convertir:");
                    valorEntrada = double.Parse(Console.ReadLine());
                    resultadoConversion = valorEntrada * 1024;
                    Console.WriteLine("la conversion es de: " + resultadoConversion + " MB");
                    break;
                case 16:
                    Console.WriteLine("Has seleccionado Gigabytes a Terabytes (TB)");
                    Console.WriteLine("Ingresa la cantidad de gigabytes que deseas convertir:");
                    valorEntrada = double.Parse(Console.ReadLine());
                    resultadoConversion = valorEntrada / 1024;
                    Console.WriteLine("la conversion es de: " + resultadoConversion + " TB");
                    break;
                case 17:
                    Console.WriteLine("Has seleccionado Terabytes a Bytes");
                    Console.WriteLine("Ingresa la cantidad de terabytes que deseas convertir:");
                    valorEntrada = double.Parse(Console.ReadLine());
                    resultadoConversion = valorEntrada * (1024.0 * 1024 * 1024 * 1024);
                    Console.WriteLine("la conversion es de: " + resultadoConversion + " Bytes");
                    break;
                case 18:
                    Console.WriteLine("Has seleccionado Terabytes a Kilobytes (KB)");
                    Console.WriteLine("Ingresa la cantidad de terabytes que deseas convertir:");
                    valorEntrada = double.Parse(Console.ReadLine());
                    resultadoConversion = valorEntrada * (1024.0 * 1024 * 1024);
                    Console.WriteLine("la conversion es de: " + resultadoConversion + " KB");
                    break;
                case 19:
                    Console.WriteLine("Has seleccionado Terabytes a Megabytes (MB)");
                    Console.WriteLine("Ingresa la cantidad de terabytes que deseas convertir:");
                    valorEntrada = double.Parse(Console.ReadLine());
                    resultadoConversion = valorEntrada * (1024.0 * 1024);
                    Console.WriteLine("la conversion es de: " + resultadoConversion + " MB");
                    break;
                case 20:
                    Console.WriteLine("Has seleccionado Terabytes a Gigabytes (GB)");
                    Console.WriteLine("Ingresa la cantidad de terabytes que deseas convertir:");
                    valorEntrada = double.Parse(Console.ReadLine());
                    resultadoConversion = valorEntrada * 1024;
                    Console.WriteLine("la conversion es de: " + resultadoConversion + " GB");
                    break;
                case 21:
                    Console.WriteLine("Gracias por utilizar el Programa Bro");
                    return;
                default:
                    Console.WriteLine("Opcion invalida");
                    break;
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
