using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(GetInitials("Jose Alonso Alvarez Yanez"));
            //Console.ReadKey();


        }

        public static bool ValidateStrings(string input , string pattern)
        {
            if (input == pattern)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static string GetInitials(string input)
        {
            // Verificar si la cadena está vacía o es nula
            if (string.IsNullOrWhiteSpace(input))
            {
                return string.Empty;
            }

            // Dividir la cadena en palabras utilizando espacios como separadores
            var words = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            // Usar StringBuilder para concatenar las iniciales
            var initials = new StringBuilder();

            foreach (var word in words)
            {
                // Agregar la primera letra de cada palabra
                initials.Append(word[0]);
            }

            // Devolver las iniciales como cadena
            return initials.ToString();
        }

    }
}
