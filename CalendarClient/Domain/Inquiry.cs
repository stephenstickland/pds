using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace CalendarClient
{
    public class Inquiry
    {
        [XmlAttribute]
        public int Id { get; set; }

        public string Description { get; set; }

        public int SortOrder { get; set; }
    }
}
