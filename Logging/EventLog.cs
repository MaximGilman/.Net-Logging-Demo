using Microsoft.Extensions.Logging;

namespace Logging;

public static class EventLog
{
    public static void RequestIndex(ILogger logger, Exception? exception = null)
    {
        if (logger.IsEnabled(LogLevel.Debug))
            RequestIndexExecute(logger, exception);
    }

    public static void DivideNumber(ILogger logger, int number)
    {
        DivideNumberExecute(logger, number, null);
    }

    public static void DivideNumberError(ILogger logger, Exception exception)
    { 
        DivideNumberExecute(logger, 0, exception);
    }

    private static readonly Action<ILogger, Exception?> RequestIndexExecute = LoggerMessage.Define(LogLevel.Information,
        EventLogIdHelper.RequestIndexId, $"Index endpoint was requested at {DateTime.Now:u}");

    private static readonly Action<ILogger, int, Exception?> DivideNumberExecute = LoggerMessage.Define<int>(
        LogLevel.Information,
        EventLogIdHelper.DivideNumberId, "Divide of value is {result}.");

    private static readonly Action<ILogger, Exception> DivideNumberErrorExecute = LoggerMessage.Define(
        LogLevel.Error,
        EventLogIdHelper.DivideNumberErrorId, "Random value was 0 and error raised");
}