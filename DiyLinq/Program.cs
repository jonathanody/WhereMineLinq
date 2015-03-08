using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiyLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<int> numbers = new[] { 1, 2, 3, 4, 5 };
            Console.WriteLine("Numbers:");
            numbers.DisplayToConsole();

            ////Predicate Method
            Console.WriteLine("Predicate Method");
            Console.WriteLine("Only Even:");
            WhereMine(numbers, x => x % 2 == 0).DisplayToConsole();
            Console.WriteLine("Greater than 2:");
            WhereMine(numbers, x => x > 2).DisplayToConsole();            

            //Extension Method
            Console.WriteLine("Extension Method");
            Console.WriteLine("Only odd:");
            numbers.WhereMine(x => x % 2 == 1).DisplayToConsole();
            Console.WriteLine("Greater than 3 but less than 5");
            numbers.WhereMine(x => x > 3 && x < 5).DisplayToConsole();

            ////Generic Extension Method
            Console.WriteLine("Generic Extension Method");
            Console.WriteLine("Numbers doubles:");
            IEnumerable<double> numbersDouble = new[] { 1.5d, 5.6d, 9.9d, 10.8d, 20d };
            numbersDouble.DisplayToConsole();
            Console.WriteLine("Less than 10");
            numbersDouble.WhereMine(x => x < 10).DisplayToConsole();

            IEnumerable<string> names = new[] { "Jane", "Steve", "Jack", "Betty", "Bill", "Jenny", "Joseph" };
            Console.WriteLine("Names:");
            names.DisplayToConsole();
            Console.WriteLine("Names that start with 'J':");
            names.WhereMine(x => x.StartsWith("J")).DisplayToConsole();
            Console.WriteLine("Names that are 5 characters in length:");
            names.WhereMine(x => x.Length == 5).DisplayToConsole();
            Console.WriteLine("Names that start with 'J' and are longer than 4 characters");
            names.WhereMine(x => x.Length > 4)
                 .WhereMine(x => x.StartsWith("J"))
                 .DisplayToConsole();
            // Or could be written as
            //names.WhereMine(x => x.Length > 4 && x.StartsWith("J")).DisplayToConsole();

            Console.ReadLine();
        }

        //Predicate method
        public static IEnumerable<int> WhereMine(IEnumerable<int> values, Predicate<int> predicate)
        {
            IList<int> matchedValues = new List<int>();

            foreach(var value in values)
            {
                if(predicate(value))                
                    matchedValues.Add(value);                
            }

            return matchedValues;
        }
    }
}
