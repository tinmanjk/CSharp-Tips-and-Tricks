namespace LinqMultipleEnumeration
{
    using System;

    public static class Program
    {
        public static void Main()
        {
            var enumerateObjects = new EnumerateObjects();

            Console.WriteLine("==== Multiple enumerations:");
            enumerateObjects.LinqQueryMultipleEnumeration();

            Console.WriteLine("==== Single enumeration (calling .ToList()):");
            enumerateObjects.LinqQuerySingleEnumeration();
        }
    }
}
