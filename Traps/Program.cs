namespace Traps
{
    using Traps.RandomNumbers;

    public static class Program
    {
        public static void Main()
        {
            RandomNumbers();
        }

        private static void RandomNumbers()
        {
            var randomInstancesWithTheSameSeed = new RandomInstancesWithTheSameSeed(4);
            randomInstancesWithTheSameSeed.PrintRandomNumbers();

            var highQualityRandomNumbers = new HighQualityRandomNumbers(4);
            highQualityRandomNumbers.PrintRandomNumbers();
        }
    }
}
