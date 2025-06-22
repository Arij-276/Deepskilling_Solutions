using System;

public sealed class Logger
{
    private static Logger _instance = null;
    private static readonly object _lock = new object();
    
    // Private constructor prevents external instantiation
    private Logger() 
    {
        Console.WriteLine("Logger instance created");
    }
    
    public static Logger Instance
    {
        get
        {
            // Double-check locking for thread safety
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
    }
    
    public void Log(string message)
    {
        Console.WriteLine($"[{DateTime.Now:HH:mm:ss}] {message}");
    }
}

public class Program
{
    public static void Main()
    {
        // Test singleton behavior
        Logger logger1 = Logger.Instance;
        Logger logger2 = Logger.Instance;
        
        Console.WriteLine($"Same instance? {ReferenceEquals(logger1, logger2)}");
        
        // Demonstrate logging functionality
        logger1.Log("System initialized");
        logger2.Log("Configuration loaded");
        
        // Test thread safety
        System.Threading.Tasks.Parallel.Invoke(
            () => Logger.Instance.Log("Thread 1 message"),
            () => Logger.Instance.Log("Thread 2 message")
        );
    }
}
