namespace CSharpSix
{
    using System;

    using CSharpSix.AutoPropertyEnhancements;
    using CSharpSix.ExpressionBodiedFunctionMembers;
    using CSharpSix.NameofExpressions;
    using CSharpSix.StringInterpolation;

    public static class Program
    {
        public static void Main()
        {
            Console.WriteLine(new string('=', 75));
            AutoPropertyEnhancements();
            Console.WriteLine(new string('=', 75));
            ExpressionBodiedFunctionMembers();
            Console.WriteLine(new string('=', 75));
            NameofExpressions();
            Console.WriteLine(new string('=', 75));
            StringInterpolation();
            Console.WriteLine(new string('=', 75));
            NullCoalescingOperator();
            Console.WriteLine(new string('=', 75));
            NullConditionalOperator();
            Console.WriteLine(new string('=', 75));
        }

        private static void AutoPropertyEnhancements()
        {
            var person = new Person();
            Console.WriteLine("{0} {1}", person.FirstName, person.LastName);

            var readOnlyPerson = new ReadOnlyPerson();
            Console.WriteLine("{0} {1}", readOnlyPerson.FirstName, readOnlyPerson.LastName);
        }

        private static void ExpressionBodiedFunctionMembers()
        {
            var point = new Point(1, 2);
            var point2 = point.Clone() as Point;
            point.Move(2, 3);
            point.Print();
            point2.Print();

            var personWithChildren = new PersonWithChildren("John", "Doe");
            Console.WriteLine(personWithChildren.Name);
            personWithChildren.Children.Add(new PersonWithChildren("John", "Little"));
            Console.WriteLine(personWithChildren["John Little"].Name);
        }

        private static void NameofExpressions()
        {
            Console.WriteLine(nameof(NameofExpressions));
            Console.WriteLine(nameof(string.Contains));
            try
            {
                var person = new PersonWithValidation(null, null);
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private static void StringInterpolation()
        {
            var personWithStringInterpolation =
                new PersonWithStringInterpolation("Nikolay", "Kostov");
            Console.WriteLine(personWithStringInterpolation.Name);

            var a = 1;
            var b = 2;
            Console.WriteLine($"{nameof(a)} + {nameof(b)} = {a + b}");
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
