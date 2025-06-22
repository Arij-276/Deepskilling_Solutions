namespace FinancialForecasting;

class Program
{
    static void Main()
    {
        double[] pastData = { 100.0, 110.0, 121.0, 133.1 };
        var forecaster = new FinancialForecaster();

        double forecast = forecaster.Forecast(pastData, 5);
        Console.WriteLine($"5-period forecast: {forecast:F2}");

        Console.WriteLine("\n--- Complexity Analysis ---");
        Console.WriteLine("Time Complexity: O(n * p)");
        Console.WriteLine("Where n = past data points, p = forecast periods");
        Console.WriteLine("Optimization: Memoization or iterative approach");
    }
}
