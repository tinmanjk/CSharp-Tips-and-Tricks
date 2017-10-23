namespace CastingVsAsOperator
{
    using System;

    public static class Program
    {
        public static void Main()
        {
            object number = "Five";

            Console.WriteLine("The type of 'number' is: {0}", number.GetType());

            if (number is string)
            {
                Console.WriteLine("'number is string' is true");
            }

            int? numberAsInt = null;


            //This will cause an unhandled exception of type 'InvalidCastException' because the specified cast is not valid.

            try
            {
                numberAsInt = (int?)number;

            }
            catch (Exception e)
            {
                Console.WriteLine(e.GetType());
            }

            //This will cause an unhandled exception of type 'InvalidOperationException' because numberAsInt will be null

            try
            {
                numberAsInt = number as int?;
                Console.WriteLine(numberAsInt.Value);


            }
            catch (Exception e)
            {
                Console.WriteLine(e.GetType());
            }

            //When using the 'as' operator we should always consider the possible null value
            Console.WriteLine(numberAsInt.GetValueOrDefault(0));
        }
    }
}
