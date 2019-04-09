using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace MemberClient
{
    public class CurrentStatus
    {
        [XmlAttribute]
        public int Id { get; set; }

        public bool IsActive { get; set; }

        public string Name { get; set; }

        public string Reason { get; set; }

        public DateTime StartDate { get; set; }
    }
}
