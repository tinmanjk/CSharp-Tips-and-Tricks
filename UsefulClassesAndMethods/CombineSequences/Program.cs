namespace CombineSequences
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public static class Program
    {
        private static readonly IEnumerable<string> FirstList =
            new List<string> { "apples", "bananas", "cherries", "durian" };

        private static readonly IEnumerable<string> SecondList =
            new List<string> { "durian", "eggplant", "apples" };

        public static void Main()
        {
            Console.WriteLine(new string('=', 50));
            ConcatMethod();
            Console.WriteLine(new string('=', 50));
            UnionMethod();
            Console.WriteLine(new string('=', 50));
            IntersectMethod();
            Console.WriteLine(new string('=', 50));
            ExceptMethod();
            Console.WriteLine(new string('=', 50));
            ZipMethod();
            Console.WriteLine(new string('=', 50));
            AggregateMethod();
            Console.WriteLine(new string('=', 50));
        }

        private static void ConcatMethod()
        {
            var newList = FirstList.Concat(SecondList);
            Console.WriteLine("Concat() result:");
            PrintList(newList);
        }

        private static void UnionMethod()
        {
            var newList = FirstList.Union(SecondList);
            Console.WriteLine("Union() result:");
            PrintList(newList);

            Console.WriteLine();

            var concatenatedListWithComparer = FirstList.Union(
                SecondList,
                new StringLengthEqualityComparer());
            Console.WriteLine("Union(with length comparer) result:");
            PrintList(concatenatedListWithComparer);
        }

        private static void IntersectMethod()
        {
            var newList = FirstList.Intersect(SecondList);
            Console.WriteLine("Intersect() result:");
            PrintList(newList);
        }

        private static void ExceptMethod()
        {
            var newList = FirstList.Except(SecondList);
            Console.WriteLine("Except() result:");
            PrintList(newList);
        }

        private static void ZipMethod()
        {
            var listOfNumbers = Enumerable.Range(1, FirstList.Count());
            var newList = listOfNumbers.Zip(FirstList, Tuple.Create);
            Console.WriteLine("Zip() result:");
            PrintList(newList);

            // Template magic:
            // public static IEnumerable<TResult> Zip<TFirst, TSecond, TResult>(
            //      this IEnumerable<TFirst> first,
            //      IEnumerable<TSecond> second,
            //      Func<TFirst, TSecond, TResult> resultSelector);
            // public static Tuple<T1, T2> Create<T1, T2>(T1 item1, T2 item2);
        }

        private static void AggregateMethod()
        {
            var allString = FirstList.Aggregate("_", (seed, current) => seed + current);
            Console.WriteLine("Aggregate() result:");
            Console.WriteLine(allString);

            // If we don't specify seed value => the seed value becomes the first element of the collection
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
