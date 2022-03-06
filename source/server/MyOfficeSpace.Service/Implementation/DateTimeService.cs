using MyOfficeSpace.Service.Contract;
using System;

namespace MyOfficeSpace.Service.Implementation
{
    public class DateTimeService : IDateTimeService
    {
        public DateTime NowUtc => DateTime.UtcNow;
    }
}