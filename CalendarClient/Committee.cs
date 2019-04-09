using System;
using System.Collections.Generic;
using System.Text;

namespace CalendarClient
{
    public class Committee
    {
        public int Id { get; set; }

        public string Description { get; set; }

        public List<Inquiry> Inquiries { get; set; }
    }
}
