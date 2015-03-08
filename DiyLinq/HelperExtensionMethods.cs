using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiyLinq
{
    public static class HelperExtensionMethods
    {
        public static void DisplayToConsole<T>(this IEnumerable<T> values)
        {
            if (!values.Any())
                return;

            foreach (var value in values)
            {
                Console.Write("{0} ", value);
            }
            Console.WriteLine();
        }
    }
}
