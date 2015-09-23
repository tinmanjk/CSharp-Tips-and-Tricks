namespace NameofExpressions
{
    using System;

    public static class Program
    {
        public static void Main()
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
