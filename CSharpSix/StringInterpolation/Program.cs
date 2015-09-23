namespace StringInterpolation
{
    using System;

    public static class Program
    {
        public static void Main(string[] args)
        {
            var personWithStringInterpolation =
                new PersonWithStringInterpolation("Nikolay", "Kostov");
            Console.WriteLine(personWithStringInterpolation.Name);

            var a = 1;
            var b = 2;
            Console.WriteLine($"{nameof(a)} + {nameof(b)} = {a + b}");

            // Escaping
            var name = "some text";
            Console.WriteLine($"{name} {{name}}");
        }
    }
}
