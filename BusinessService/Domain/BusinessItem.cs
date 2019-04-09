using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessService.Domain
{
    public class BusinessItem
    {
        public string Description { get; set; }

        public string Category { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public string StartTime { get; set; }

        public string EndTime { get; set; }

        public List<Member> ApplicableMembers { get; set; }
    }
}
