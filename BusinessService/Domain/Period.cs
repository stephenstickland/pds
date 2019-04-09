using BusinessService.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessService.Domain
{
    public class Period
    {
        public DateTime PeriodStart { get; set; }

        public DateTime PeriodEnd { get; set; }

        public List<BusinessItem> BusinessItems { get; set; } = new List<BusinessItem>();

        public Period(DateTime periodStart, DateTime periodEnd)
        {
            PeriodStart = periodStart;
            PeriodEnd = periodEnd;
        }
    }
}
