using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiyLinq
{
    public static class DiyLinqExtensionMethods
    {
        // Extension method
        public static IEnumerable<int> WhereMine(this IEnumerable<int> values, Predicate<int> predicate)
        {
            IList<int> matchedValues = new List<int>();

            foreach(var value in values)
            {
                if (predicate(value))
                    matchedValues.Add(value);
            }

            return matchedValues;
        }

        // Generic extension method
        public static IEnumerable<T> WhereMine<T>(this IEnumerable<T> values, Predicate<T> predicate)
        {
            IList<T> matchedValues = new List<T>();

            foreach(var value in values)
            {
                if (predicate(value))
                    matchedValues.Add(value);
            }

            return matchedValues;
        }
    }
}
