using System;
using System.Collections.Generic;
using System.Text;

namespace MemberClient
{
    public class CurrentStatus
    {
        public int Id { get; set; }

        public bool IsActive { get; set; }

        public string Name { get; set; }

        public string Reason { get; set; }

        public DateTime StartDate { get; set; }
    }
}
