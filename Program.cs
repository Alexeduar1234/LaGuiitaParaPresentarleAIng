using System;
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

			string entrada = Console.ReadLine();
			int selecion = 0;
			try
			{
				selecion = int.Parse(entrada);
			}
			catch
			{
				Console.WriteLine("Entrada invalida. Presiona Enter para continuar...");
				Console.ReadLine();
				continue;
			}
			if (selecion == 0)
			{
				Console.WriteLine("Saliendo...");
				Console.Clear();
				break;
			}

			if (selecion < 1 || selecion > OpcionMax)
			{
				Console.WriteLine("No se puede realizar la accion: por favor selecciona una opcion valida.");
				Console.WriteLine("Presiona Enter para continuar...");
				Console.ReadLine();
				continue;
			}

			EjecutarEjercicio(selecion);
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
