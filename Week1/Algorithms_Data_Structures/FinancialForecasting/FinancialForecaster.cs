namespace FinancialForecasting;

public class FinancialForecaster
{
    public double Forecast(double[] pastValues, int periods)
    {
        if (periods <= 0) 
            return pastValues[^1]; 
        
        double growthRate = CalculateAverageGrowthRate(pastValues);
        double[] newPastValues = new double[pastValues.Length + 1];
        Array.Copy(pastValues, newPastValues, pastValues.Length);
        
        
        newPastValues[^1] = pastValues[^1] * (1 + growthRate);
        
        
        return Forecast(newPastValues, periods - 1);
    }

    private double CalculateAverageGrowthRate(double[] values)
    {
        double totalGrowth = 0;
        for (int i = 1; i < values.Length; i++)
        {
            double growth = (values[i] - values[i-1]) / values[i-1];
            totalGrowth += growth;
        }
        return totalGrowth / (values.Length - 1);
    }
}

