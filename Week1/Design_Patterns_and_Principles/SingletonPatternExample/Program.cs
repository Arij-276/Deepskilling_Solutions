class Program
{
    static void Main(string[] args)
    {
        // Test singleton behavior
        Logger logger1 = Logger.Instance;
        Logger logger2 = Logger.Instance;
        
        // Verify single instance
        Console.WriteLine($"Same instance? {ReferenceEquals(logger1, logger2)}");
        
        // Test logging
        logger1.Log("First log message");
        logger2.Log("Second log message");
        
        // Thread-safety test
        Parallel.Invoke(
            () => Logger.Instance.Log("Thread 1 log"),
            () => Logger.Instance.Log("Thread 2 log")
        );
    }
}
