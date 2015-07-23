namespace SyntacticSugar.Yield
{
    using System.Collections.Generic;

    public static class YieldNumbersGenerator
    {
        public static IEnumerable<int> EvenNumbers(int from, int to)
        {
            for (int i = from; i <= to; i++)
            {
                if (i % 2 == 0)
                {
                    yield return i;
                }
            }
        }
    }
}
