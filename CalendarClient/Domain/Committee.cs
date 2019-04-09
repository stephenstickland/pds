using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace CalendarClient
{
    public class Committee
    {
        [XmlAttribute]
        public int Id { get; set; }

        public string Description { get; set; }

        public List<Inquiry> Inquiries { get; set; }
    }
}
