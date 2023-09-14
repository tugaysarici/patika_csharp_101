using System;

namespace Interface
{
    public class FileLogger : ILogger
    {
        public void WriteLog()
        {
            Console.WriteLine("It writes logs to the file.");
        }
    }
}