using System;
using System.Collections;
using System.Linq;

namespace GeneratorFunctionScratch
{
    class Program
    {
        public static System.Collections.Generic.IEnumerable<int> GetValue()
        {
            yield return 10;
            yield return 20;
        }

        static void Main(string[] args)
        {
            foreach(int i in GetValue())
            {
                Console.WriteLine(i);
            }
            Console.Read();           
        }
    }
}
