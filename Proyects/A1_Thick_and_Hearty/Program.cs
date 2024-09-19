using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A1_Thick_and_Hearty
{
    internal class Program
    {
        public static List<int> A1ThickAndHearty(int[] a1, int[] a2)
        {
            List<int> lengths = new List<int> { a1.Length, a2.Length };

            List<int> commonValues = a1.Intersect(a2).ToList();
            if (commonValues.Count == 0)
            {
                return commonValues;
            }

            List<int> result = new List<int>();

            foreach (var a in commonValues)
            {
                foreach (var b in commonValues)
                {
                    if (a != b) 
                    {

                        if (lengths.Contains(a + b) || lengths.Contains(Math.Abs(a - b)))
                        {
                            result.Add(a);
                            result.Add(b);
                        }
                    }
                }
            }
            return result.Distinct().ToList();
        }
        static void Main(string[] args)
        {
            int[] a1 = { 1, 2, 3, 4, 5, 6 };
            int[] a2 = { 1, 2, 4, 6, 7, 8, 9, 10 };

            List<int> result = A1ThickAndHearty(a1, a2);

            Console.WriteLine("Result: " + string.Join(", ", result));

            Console.ReadKey();
        }

    }
}
