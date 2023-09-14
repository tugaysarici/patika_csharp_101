using System;

namespace Interface
{
    public class SmsLogger : ILogger
    {
        public void WriteLog()
        {
            //throw new NotImplementedException();
            Console.WriteLine("It writes logs as sms.");
        }
    }
}
