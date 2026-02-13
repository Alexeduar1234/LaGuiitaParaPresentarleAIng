using System;

namespace EjerciciosTarea.Ejercicios
{
    public class Ejercicio20
    {
        public void Ejecutar()
        {
            Console.WriteLine("Ejercicio 20:");
            Console.WriteLine("Validador de contraseñas");
            Console.WriteLine("Por favor, ingresa la contraseña que quieras validar:");
            string contrasena = Console.ReadLine();
            // indicadores para mayuscula, minuscula, numero y simbolo en la contrasena
            bool tieneMayuscula = false;
            bool tieneMinuscula = false;
            bool tieneNumero = false;
            bool tieneSimbolo = false;
            if (contrasena.Length >= 8)
            {foreach (char GuardaLetra in contrasena)
            {
            if (char.IsUpper(GuardaLetra)) tieneMayuscula = true;
            else if (char.IsLower(GuardaLetra)) tieneMinuscula = true;
            else if (char.IsDigit(GuardaLetra)) tieneNumero = true;
            else if (!char.IsLetterOrDigit(GuardaLetra))
            tieneSimbolo = true;
            }
            if (tieneMayuscula && tieneMinuscula && tieneNumero && tieneSimbolo)
            {
            Console.WriteLine("Contrasena valida.");
            }
            else
            {
            Console.WriteLine("La contrasena no cumple con los requisitos.");
            }
            }
            else
            {
                Console.WriteLine(" La contrasena debe tener al menos 8 caracteres.");
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