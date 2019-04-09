using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace CalendarClient
{
    public class Event
    {
        [XmlAttribute]
        public int Id { get; set; }

        public DateTime? StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        public string StartTime { get; set; }

        public string EndTime { get; set; }

        public string Description { get; set; }

        public string Notes { get; set; }

        public int SortOrder { get; set; }

        public string Type { get; set; }

        public string House { get; set; }

        public string Category { get; set; }

        public string Location { get; set; }

        public string LocationMetadata { get; set; }

        public bool HasSpeakers { get; set; }

        [XmlElement(ElementName = "Committee", IsNullable = true)]
        public Committee Committee { get; set; } = null;

        public List<Tag> Tags { get; set; }

        public List<Member> Members { get; set; }

        public List<Metadata> Metadata { get; set; }

        public string SummarisedDetails { get; set; }
    }
}
