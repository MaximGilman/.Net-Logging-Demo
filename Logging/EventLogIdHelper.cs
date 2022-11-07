using Microsoft.Extensions.Logging;

namespace Logging;

public static class EventLogIdHelper
{
    public static readonly EventId RequestIndexId = new(9001,"RequestIndex");
    public static readonly EventId DivideNumberId = new(9701,"DivideNumber");
    public static readonly EventId DivideNumberErrorId = new(9800,"DivideNumberError");

}