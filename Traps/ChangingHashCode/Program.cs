namespace ChangingHashCode
{
    using System;
    using System.Collections.Generic;

    public static class Program
    {
        public static void Main()
        {
            var first = new Student { Id = 1, Name = "Pesho" };
            var second = new Student { Id = 2, Name = "Gosho" };
            var third = new Student { Id = 3, Name = "Stamat" };
            var fourth = new Student { Id = 4, Name = "Kolio (me) :D" };

            var marks = new Dictionary<Student, int>();
            marks.Add(first, 6); // adding the object with hash code 1
            marks.Add(second, 5);
            marks.Add(third, 4);
            marks.Add(fourth, 3);

            // this call works correctly as the hash code is still 1
            Console.WriteLine(marks[first]);

            // changing the Id, without realizing the hash code will change to 10 too
            first.Id = 10;

            // the collection is no longer capable of finding the first student
            Console.WriteLine(marks[first]);
        }
    }
}
