using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(FunctionInFunction(IsDog, "Cat"));
            Console.ReadKey();
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
