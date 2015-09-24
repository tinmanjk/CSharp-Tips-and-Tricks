namespace NullConditionalOperator
{
    using System;

    public static class Program
    {
        public static void Main()
        {
            NullCoalescingOperator();
            Console.WriteLine(new string('=', 50));
            NullConditionalOperator();
        }

        // This is not new in C# 6
        private static void NullCoalescingOperator()
        {
            int? temperatureInSofia = null;
            Console.WriteLine(temperatureInSofia ?? 22);

            // Chaining
            int? temperatureInBulgaria = null;
            int? temperatureInEurope = null;
            Console.WriteLine(temperatureInSofia ?? temperatureInBulgaria ?? temperatureInEurope ?? 22);
        }

        private static void NullConditionalOperator()
        {
            string[] listOfStrings = null;

            int? lengthOrNull = listOfStrings?.Length;
            Console.WriteLine("lengthOrNull.HasValue: {0}", lengthOrNull.HasValue);

            var firstValue = listOfStrings?[0];
            Console.WriteLine("firstValue == null? {0}", firstValue == null);

            // Chaining
            var substringValue = listOfStrings?[0]?.Substring(0, 1) ?? "[null]";
            Console.WriteLine("substringValue = {0}", substringValue);
        }
    }
}
