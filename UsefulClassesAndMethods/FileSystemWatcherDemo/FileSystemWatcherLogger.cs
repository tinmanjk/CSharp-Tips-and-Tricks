namespace UsefulClassesAndMethods.FileSystemWatcherDemo
{
    using System;
    using System.IO;

    // Read more: http://weblogs.asp.net/ashben/31773
    public class FileSystemWatcherLogger
    {
        private readonly FileSystemWatcher fileSystemWatcher;

        public FileSystemWatcherLogger(string path)
        {
            this.fileSystemWatcher = new FileSystemWatcher
                                         {
                                             // Filter = "*.cs",
                                             IncludeSubdirectories = true,
                                             Path = path,
                                             NotifyFilter = NotifyFilters.FileName | NotifyFilters.LastWrite,
                                             EnableRaisingEvents = true
                                         };
            /* Notify filters:
                FileName, DirectoryName, Attributes, Size
                LastWrite, LastAccess, CreationTime, Security
             */

            // Events may be raised more than once.
            // Read more: http://stackoverflow.com/questions/1764809/filesystemwatcher-changed-event-is-raised-twice
            this.fileSystemWatcher.Changed += this.FileSystemWatcherOnChanged;
            this.fileSystemWatcher.Created += this.FileSystemWatcherOnCreated;
            this.fileSystemWatcher.Deleted += this.FileSystemWatcherOnDeleted;
            this.fileSystemWatcher.Error += this.FileSystemWatcherOnError;
            this.fileSystemWatcher.Renamed += this.FileSystemWatcherOnRenamed;
        }

        private void FileSystemWatcherOnChanged(object sender, FileSystemEventArgs fileSystemEventArgs)
        {
            Console.WriteLine($"{fileSystemEventArgs.ChangeType} {fileSystemEventArgs.Name}");
        }

        private void FileSystemWatcherOnCreated(object sender, FileSystemEventArgs fileSystemEventArgs)
        {
            Console.WriteLine($"{fileSystemEventArgs.ChangeType} {fileSystemEventArgs.Name}");
        }

        private void FileSystemWatcherOnDeleted(object sender, FileSystemEventArgs fileSystemEventArgs)
        {
            Console.WriteLine($"{fileSystemEventArgs.ChangeType} {fileSystemEventArgs.Name}");
        }

        private void FileSystemWatcherOnError(object sender, ErrorEventArgs errorEventArgs)
        {
            Console.WriteLine($"Error: {errorEventArgs.GetException()}");
        }

        private void FileSystemWatcherOnRenamed(object sender, RenamedEventArgs renamedEventArgs)
        {
            Console.WriteLine($"{renamedEventArgs.ChangeType} {renamedEventArgs.OldName} to {renamedEventArgs.Name}");
        }
    }
}
