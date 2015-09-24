using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CombineSequences
{
    public static class Program
    {
        private static readonly IEnumerable<string> firstList =
            new List<string> { "apples", "bananas", "cherries", "durian" };

        private static readonly IEnumerable<string> secondList =
            new List<string> { "durian", "eggplant", "apples" };

        public static void Main()
        {
            Console.WriteLine(new string('=', 50));
            ConcatMethod();
            Console.WriteLine(new string('=', 50));
            UnionMethod();
            Console.WriteLine(new string('=', 50));
        }

        private static void ConcatMethod()
        {
            var concatenatedList = firstList.Concat(secondList);
            Console.WriteLine("Concat() result:");
            PrintList(concatenatedList);
        }

        private static void UnionMethod()
        {
            var concatenatedList = firstList.Union(secondList);
            Console.WriteLine("Union() result:");
            PrintList(concatenatedList);

            Console.WriteLine();

            var concatenatedListWithComparer = firstList.Union(secondList, new CustomStringEqualityComparer());
            Console.WriteLine("Union(with length comparer) result:");
            PrintList(concatenatedListWithComparer);
        }

        private static void PrintList<T>(IEnumerable<T> list)
        {
            var stringBuilder = new StringBuilder();
            foreach (var item in list)
            {
                stringBuilder.Append(item);
                stringBuilder.Append(", ");
            }

            Console.WriteLine(stringBuilder.ToString().Trim(' ', ','));
        }
    }
}
