namespace CSharpSix
{
    using System;

    using CSharpSix.AutoPropertyEnhancements;

    public static class Program
    {
        public static void Main()
        {
            Console.WriteLine(new string('=', 75));
            AutoPropertyEnhancements();
            Console.WriteLine(new string('=', 75));
        }

        private static void AutoPropertyEnhancements()
        {
            var person = new Person();
            Console.WriteLine("{0} {1}", person.FirstName, person.LastName);

            var readOnlyPerson = new ReadOnlyPerson();
            Console.WriteLine("{0} {1}", readOnlyPerson.FirstName, readOnlyPerson.LastName);
        }
    }
}
