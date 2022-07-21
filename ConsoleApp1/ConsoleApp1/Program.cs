using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    public class Program
    {
        static void Main(string[] args)
        {
            DefferedExecution();
            Console.ReadKey();
        }

        public static void DefferedExecution()
        {
            var animals = new List<string>() { "Duck", "Lion", "Dolphin", "Tiger" };

            var animalsWithD = animals.Where(
                animal =>
                {
                    Console.WriteLine("Checking animal: " + animal);
                    return animal.StartsWith("D");
                }
            );

            foreach (var animal in animalsWithD)
            {
                Console.WriteLine(animal);
            }
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
