using MySpace.Application.Common.Interfaces.Services;

namespace MySpace.Infrastructure.Services;

public class DateTimeProvider : IDateTimeProvider
{
    public DateTime UtcNow => DateTime.UtcNow;    
}