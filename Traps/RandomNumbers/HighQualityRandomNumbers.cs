namespace Traps.RandomNumbers
{
    using System;
    using System.Security.Cryptography;

    public class HighQualityRandomNumbers : IRandomNumbersPrinter
    {
        private readonly int numberOfRandomNumbers;

        private readonly RandomNumberGenerator randomNumberGenerator;

        public HighQualityRandomNumbers(int numberOfRandomNumbers)
        {
            this.numberOfRandomNumbers = numberOfRandomNumbers;
            this.randomNumberGenerator = RandomNumberGenerator.Create();
        }

        public void PrintRandomNumbers()
        {
            Console.Write("RNGCryptoServiceProvider: ");
            for (int i = 0; i < this.numberOfRandomNumbers; i++)
            {
                var randomInt32Value = this.GenerateRandomInt32Value();
                Console.Write("{0} ", randomInt32Value);
            }

            Console.WriteLine();
        }

        private int GenerateRandomInt32Value()
        {
            var fourRandomBytes = new byte[4]; // 4 bytes = 32 bits = Int32
            this.randomNumberGenerator.GetBytes(fourRandomBytes);
            var randomInt32Value = BitConverter.ToInt32(fourRandomBytes, 0);
            return randomInt32Value;
        }
    }
}
