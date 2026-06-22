using FinancialForecasting;

double futureValue =
    FinancialForecast.PredictFutureValue(
        10000,
        0.10,
        3);

Console.WriteLine($"Predicted Future Value: {futureValue:F2}");
