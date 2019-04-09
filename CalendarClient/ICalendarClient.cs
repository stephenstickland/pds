using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CalendarClient
{
    public interface ICalendarClient
    {
        Task<IList<Event>> GetEvents(DateTime startDate, DateTime endDate);
    }
}
