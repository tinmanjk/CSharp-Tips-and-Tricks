namespace FileSystemWatcherClass
{
    using System;

    public static class Program
    {
        public static void Main()
        {
            var fileSystemWatcherLogger = new FileSystemWatcherLogger(Environment.CurrentDirectory);
            Console.WriteLine($"Started watching {Environment.CurrentDirectory}");
            Console.WriteLine("Press [enter] to stop watching...");
            Console.ReadLine();
        }
    }
}
