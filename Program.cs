using System;
using EjerciciosTarea.Bloque2EstructurasDeControl;
using EjerciciosTarea.ejercicios;
using EjerciciosTarea.Ejercicios;


class Program
{
	static void Main()
	{
		const int OpcionMax = 30;

		while (true)
		{
			Console.Clear();
			Console.WriteLine("=== MENU PRINCIPAL ===");
			for (int i = 1; i <= OpcionMax; i++)
			{
				Console.WriteLine(i + ". Ejercicio " + i);
			}
			Console.WriteLine("0. Salir");
			Console.Write("Selecciona una opcion: ");

			string entradaUsuario = Console.ReadLine();
			int seleccion = 0;
			try
			{
				seleccion = int.Parse(entradaUsuario);
			}
			catch
			{
				Console.WriteLine("Entrada invalida. Presiona Enter para continuar...");
				Console.ReadLine();
				continue;
			}
			if (seleccion == 0)
			{
				Console.WriteLine("Saliendo...");
				Console.Clear();
				break;
			}

			if (seleccion < 1 || seleccion > OpcionMax)
			{
				Console.WriteLine("No se puede realizar la accion: por favor selecciona una opcion valida.");
				Console.WriteLine("Presiona Enter para continuar...");
				Console.ReadLine();
				continue;
			}

			EjecutarEjercicio(seleccion);
		}
	}

	static void EjecutarEjercicio(int numero)
	{
		try
		{
			switch (numero)
			{
				case 1: new Ejercicio1().Ejecutar(); break;
				case 2: new Ejercicio2().Ejecutar(); break;
				case 3: new Ejercicio3().Ejecutar(); break;
                case 4: new Ejercicio4().Ejecutar(); break;
                case 5: new Ejercicio5().Ejecutar(); break;
                case 6: new Ejercicio6().Ejecutar(); break;
                case 7: new Ejercicio7().Ejecutar(); break;
                case 8: new Ejercicio8().Ejecutar(); break;
				case 9: new Ejercicio9().Ejecutar(); break;
				case 10: new Ejercicio10().Ejecutar(); break;
				case 11: new Ejercicio11().Ejecutar(); break;
				case 12: new Ejercicio12().Ejecutar(); break;
				case 13: new Ejercicio13().Ejecutar(); break;
				case 14: new Ejercicio14().Ejecutar(); break;
				case 15: new Ejercicio15().Ejecutar(); break;
				case 16: new Ejercicio16().Ejecutar(); break;
				case 17: new Ejercicio17().Ejecutar(); break;
				case 18: new Ejercicio18().Ejecutar(); break;
				case 19: new Ejercicio19().Ejecutar(); break;
				case 20: new Ejercicio20().Ejecutar(); break;
				case 21: new Ejercicio21().Ejecutar(); break;
				case 22: new Ejercicio22().Ejecutar(); break;
				case 23: new Ejercicio23().Ejecutar(); break;
				case 24: new Ejercicio24().Ejecutar(); break;
				case 25: new Ejercicio25().Ejecutar(); break;
				case 26: new Ejercicio26().Ejecutar(); break;
				case 27: new Ejercicio27().Ejecutar(); break;
				case 28: new Ejercicio28().Ejecutar(); break;
				case 29: new Ejercicio29().Ejecutar(); break;
				case 30: new Ejercicio30().Ejecutar(); break;
				default:
					Console.WriteLine("No se puede realizar la accion: opcion no implementada.");
					Console.WriteLine("Presiona Enter para continuar...");
					Console.ReadLine();
					break;
			}
		}
		catch
		{
			Console.WriteLine("Error al ejecutar el ejercicio");
			Console.WriteLine("Presiona Enter para continuar...");
			Console.ReadLine();
		}
	}

}
