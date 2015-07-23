namespace SyntacticSugar
{
    using System;

    using SyntacticSugar.CombinableEnumValues;
    using SyntacticSugar.Yield;

    public static class Program
    {
        public static void Main()
        {
            Console.WriteLine(new string('=', 75));
            CombinableEnumValues();
            Console.WriteLine(new string('=', 75));
            CastingVsAsOperator();
            Console.WriteLine(new string('=', 75));
            YieldDemo();
            Console.WriteLine(new string('=', 75));
        }

        private static void CombinableEnumValues()
        {
            var bottomRightMargin = Margins.Bottom | Margins.Right;
            var topLeftMargin = Margins.Top | Margins.Left;

            // Getting information
            Console.WriteLine("bottomRightMargin string value: {0}", bottomRightMargin);
            Console.WriteLine("bottomRightMargin integer value: {0}", (int)bottomRightMargin);
            Console.WriteLine("bottomRightMargin == Margins.Bottom: {0}", bottomRightMargin == Margins.Bottom);
            Console.WriteLine(
                "bottomRightMargin has flag Margins.Bottom: {0}",
                bottomRightMargin.HasFlag(Margins.Bottom)); // Equivalent to (bottomRightMargin & Margins.Bottom) != 0

            // Combining combinations
            Console.WriteLine("bottomRightMargin and topLeftMargin: {0}", bottomRightMargin | topLeftMargin);

            // Toggling values
            bottomRightMargin ^= Margins.Bottom;
            Console.WriteLine("bottomRightMargin ^= Margins.Bottom => {0}", bottomRightMargin);
            bottomRightMargin ^= Margins.Bottom;
            Console.WriteLine("bottomRightMargin ^= Margins.Bottom => {0}", bottomRightMargin);
        }

        private static void CastingVsAsOperator()
        {
            object number = "Five";

            Console.WriteLine("The type of 'number' is: {0}", number.GetType());

            if (number is string)
            {
                Console.WriteLine("'number is string' is true");
            }

            //// This will cause an unhandled exception of type 'InvalidCastException' because the specified cast is not valid.
            //// var numberAsInt = (int?)number;

            //// var numberAsInt = number as int?;
            //// This will cause an unhandled exception of type 'InvalidOperationException' because numberAsInt will be null
            //// Console.WriteLine(numberAsInt.Value);
            
            //// When using the 'as' operator we should always consider the possible null value
            //// Console.WriteLine(numberAsInt.GetValueOrDefault(0));
        }

        private static void YieldDemo()
        {
            foreach (var evenNumber in YieldNumbersGenerator.EvenNumbers(50, 60))
            {
                Console.WriteLine("!! Iterated number {0}", evenNumber);
                if (evenNumber > 55)
                {
                    break;
                }
            }
        }
    }
}
