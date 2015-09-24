namespace RandomNumbers
{
    using System;

    public static class Program
    {
        public static void Main()
        {
            var randomInstancesWithTheSameSeed = new RandomInstancesWithTheSameSeed(4);
            randomInstancesWithTheSameSeed.PrintRandomNumbers();

            Console.WriteLine(new string('=', 50));

            var highQualityRandomNumbers = new HighQualityRandomNumbers(4);
            highQualityRandomNumbers.PrintRandomNumbers();
        }
    }
}
