namespace Traps
{
    using System;
    using System.Security.Policy;

    using Traps.LinqMultipleEnumeration;
    using Traps.RandomNumbers;
    using Traps.References;

    public static class Program
    {
        public static void Main()
        {
            Console.WriteLine(new string('-', 70));
            References();
            Console.WriteLine(new string('-', 70));
            StringReferences();
            Console.WriteLine(new string('-', 70));
            RandomNumbers();
            Console.WriteLine(new string('-', 70));
            LinqMultipleEnumeration();
        }

        private static void References()
        {
            var firstPerson = new Person("1234567890", "John", "Doe");
            var secondPerson = new Person("1234567890", "John", "Doe");

            var thirdPerson = secondPerson;
            Console.WriteLine("var thirdPerson = secondPerson;");
            Console.WriteLine("thirdPerson == secondPerson is {0}", thirdPerson == secondPerson);
            Console.WriteLine();

            CompareObjects(firstPerson, secondPerson);

            var firstPersonWithEquals = new PersonWithEquals("1234567890", "John", "Doe");
            var secondPersonWithEquals = new PersonWithEquals("1234567890", "John", "Doe");
            CompareObjects(firstPersonWithEquals, secondPersonWithEquals);

            var firstPersonWithEqualityOperator = new PersonWithEqualityOperator("1234567890", "John", "Doe");
            var secondPersonWithEqualityOperator = new PersonWithEqualityOperator("1234567890", "John", "Doe");
            CompareObjects(firstPersonWithEqualityOperator, secondPersonWithEqualityOperator);
            Console.WriteLine(
                "Inline fPersonWithEqualityOperator == sPersonWithEqualityOperator is {0}",
                firstPersonWithEqualityOperator == secondPersonWithEqualityOperator);
        }

        private static void CompareObjects<T>(T firstObject, T secondObject) where T : class
        {
            Console.WriteLine(
                "f{1} == s{2} is {0}",
                firstObject == secondObject,
                firstObject.GetType().Name,
                secondObject.GetType().Name);
            Console.WriteLine(
                "f{1}.Equals(s{2}) is {0}",
                firstObject.Equals(secondObject),
                firstObject.GetType().Name,
                secondObject.GetType().Name);
            Console.WriteLine(
                "ReferenceEquals(f{1}, s{2}) is {0}",
                object.ReferenceEquals(firstObject, secondObject),
                firstObject.GetType().Name,
                secondObject.GetType().Name);
            Console.WriteLine();
        }

        private static void StringReferences()
        {
            var string1 = "some value";
            var string2 = "some value";
            Console.Write("Please enter \"some value\": ");
            var stringFromConsole = Console.ReadLine();
            var stringInternFromConsole = string.Intern(stringFromConsole);
            Console.WriteLine("ReferenceEquals(string1, string2) = {0}", ReferenceEquals(string1, string2));
            Console.WriteLine("ReferenceEquals(string1, stringFromConsole) = {0}", ReferenceEquals(string1, stringFromConsole));
            Console.WriteLine("ReferenceEquals(string1, stringInternFromConsole) = {0}", ReferenceEquals(string1, stringInternFromConsole));
        }

        private static void RandomNumbers()
        {
            var randomInstancesWithTheSameSeed = new RandomInstancesWithTheSameSeed(4);
            randomInstancesWithTheSameSeed.PrintRandomNumbers();

            var highQualityRandomNumbers = new HighQualityRandomNumbers(4);
            highQualityRandomNumbers.PrintRandomNumbers();
        }

        private static void LinqMultipleEnumeration()
        {
            var enumerateObjects = new EnumerateObjects();

            Console.WriteLine("==== Multiple enumerations:");
            enumerateObjects.LinqQueryMultipleEnumeration();

            Console.WriteLine("==== Single enumeration (calling .ToList()):");
            enumerateObjects.LinqQuerySingleEnumeration();
        }
    }
}
