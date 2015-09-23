namespace ExpressionBodiedFunctionMembers
{
    using System;

    public static class Program
    {
        public static void Main(string[] args)
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
    }
}
