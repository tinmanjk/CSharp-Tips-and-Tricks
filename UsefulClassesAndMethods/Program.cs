namespace UsefulClassesAndMethods
{
    using System;
    using System.Collections.Generic;

    using UsefulClassesAndMethods.Tuple;

    public static class Program
    {
        public static void Main()
        {
            TupleDemo();
        }

        private static void TupleDemo()
        {
            var countAndAverageCalculator = new CountAndAverageCalculator();
            var result = countAndAverageCalculator.GetCountAndAverage(new List<int> { 1, 2, 3, 4 });
            Console.WriteLine("Count: {0}", result.Item1);
            Console.WriteLine("Average: {0}", result.Item2);
            
            var anotherResult = countAndAverageCalculator.GetCountAndAverage(new List<int> { 4, 3, 2, 1 });
            Console.WriteLine(anotherResult.Equals(result)); // anotherResult == result => reference comparison

            // Property or indexer 'System.Tuple<int,decimal>.Item1' cannot be assigned to -- it is read only
            // result.Item1 = 1;
        }
    }
}
