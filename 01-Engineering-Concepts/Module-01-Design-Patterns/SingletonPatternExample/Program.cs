using System;

namespace DesignPatternsAssignment
{
    public sealed class Logger
    {
        private static Logger _instance;
        private static readonly object _lock = new object();

        private Logger()
        {
            Console.WriteLine("Logger instance created.");
        }

        public static Logger GetInstance()
        {
            if (_instance == null)
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new Logger();
                    }
                }
            }

            return _instance;
        }

        public void Log(string message)
        {
            Console.WriteLine($"[LOG] {message}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Logger logger1 = Logger.GetInstance();
            Logger logger2 = Logger.GetInstance();

            logger1.Log("Application Started");
            logger2.Log("Processing Request");

            if (logger1 == logger2)
            {
                Console.WriteLine("Singleton Pattern Verified: Only one instance exists.");
            }
        }
    }
}