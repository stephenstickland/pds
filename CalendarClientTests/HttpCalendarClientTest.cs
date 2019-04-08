using CalendarClient;
using System;
using Xunit;

namespace CalendarClientTests
{
    public class HttpCalendarClientTest
    {
        [Fact]
        public void Construction()
        {
            var client = new HttpCalendarClient();
            Assert.NotNull(client);
        }
    }
}
