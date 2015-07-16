namespace Debugging
{
    using System;
    using System.Collections.Generic;

    using Debugging.CallerInfoAttributes;
    using Debugging.DebuggerVariableDisplay;

    public static class Program
    {
        public static void Main()
        {
            DebuggerVariableDisplay();
            CallerInfoAttributes();
        }

        public static void DebuggerVariableDisplay()
        {
            // Set breakpoints and observe debugging info of the following variables
            var student = new Student("John", "Doe");

            var studentWithToStringMethod = new StudentWithToStringMethod("John", "Doe");

            var studentWithDebuggerDisplayAttribute = new StudentWithDebuggerDisplayAttribute("John", "Doe");

            var studentWithDebuggerBrowsableAttribute = new StudentWithDebuggerBrowsableAttribute(
                "John",
                "Doe",
                new List<int> { 3, 3, 6, 6 });
        }

        public static void CallerInfoAttributes()
        {
            Console.WriteLine(CallerInfoAttributesExamples.GetCallerMemberName());
            Console.WriteLine(CallerInfoAttributesExamples.GetCallerFilePath());
            Console.WriteLine(CallerInfoAttributesExamples.GetCallerLineNumber());
        }
    }
}
