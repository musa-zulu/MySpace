using System;

namespace MyOfficeSpace.Service.Contract
{
    public interface IDateTimeService
    {
        DateTime NowUtc { get; }
    }
}
