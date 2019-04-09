using BusinessService.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessService.Domain
{
    public class Week
    {
        public DateTime WeekStart { get; set; }

        public DateTime WeekEnd { get; set; }

        public List<BusinessItem> BusinessItems { get; set; } = new List<BusinessItem>();

        public Week(DateTime weekStart, DateTime weekEnd)
        {
            WeekStart = weekStart;
            WeekEnd = weekEnd;
        }
    }
}
