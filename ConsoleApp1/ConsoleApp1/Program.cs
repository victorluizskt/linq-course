using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    public class Program
    {
        static void Main(string[] args)
        {
            var numbers = new int[] { 1, 2, 3, 55, 200, 500, 700 };
            Console.WriteLine(IsAny(numbers, number => number > 100));
            Console.ReadKey();
        }

        private static bool IsAny<T>(
            IEnumerable<T> source,
            Func<T, bool> predicate
        )
        {
            foreach(var element in source)
            {
                if (predicate(element)) return true;
            }

            return false;
        }

        public static bool FunctionInFunction(Func<string, bool> predicate, string param1)
        {
            var predicateFunction = predicate(param1);
            return predicateFunction;
        }

        public static bool IsDog(string param1)
        {
            return param1.Equals("Dog");
        }
    }
}
