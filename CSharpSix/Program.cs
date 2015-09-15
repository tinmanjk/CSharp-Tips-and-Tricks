namespace CSharpSix
{
    using System;

    using CSharpSix.AutoPropertyEnhancements;
    using CSharpSix.ExpressionBodiedFunctionMembers;
    using CSharpSix.NameofExpressions;

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
    }
}
