using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace CalendarClient
{
    public class Member
    {
        [XmlAttribute]
        public int Id { get; set; }

        public string Name { get; set; }

        public int SortOrder { get; set; }
    }
}
