using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Are_we_alternate
{
    internal class Program
    {
        static void Main(string[] args)
        {
           bool r =  isALT("Alonso"); 
           Console.WriteLine(r.ToString());
           Console.ReadKey();
        }

        public static bool isALT(string text)
        {
            string vowels = "aeiouáéíóú";

            if (text == string.Empty)
            {
                return false;
            }
            else
            {
                text = text.ToLower();

                for (int i = 0; i < text.Length -1; i++)
                {
                    bool isActualVowel = vowels.Contains(text[i]);
                    bool isNextVowel = vowels.Contains(text[i + 1]);

                    if (isActualVowel == isNextVowel)
                    {
                        return false;
                    }
                    
                }
                return true;
            }


           

            return false;
        }
    }

}
