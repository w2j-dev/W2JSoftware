using System;
using W2JSoftware.Utils.Common.Providers.Interfaces;

namespace W2JSoftware.Utils.Common.Providers.Implementations
{
    public class DateTimeProvider : IDateTimeProvider
    {
        public DateTimeOffset DatetTimeOffsetNow => DateTimeOffset.Now;

        public DateTime DateTimeNow => DateTime.Now;
    }
}
