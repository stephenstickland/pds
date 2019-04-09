using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Globalization;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CalendarClient
{
    public class HttpCalendarClient : ICalendarClient
    {
        private string CALENDAR_URL = "http://service.calendar.parliament.uk/calendar/events/list.xml";

        private string CULTURE = "en-GB";

        private string SHORT_DATE_FORMAT = "yyyy-MM-dd";

        private HttpClient _http;

        public HttpCalendarClient(HttpClient http)
        {
            _http = http;
        }

        public async Task<IList<Event>> GetEvents(DateTime startDate, DateTime endDate)
        {
            NameValueCollection query = System.Web.HttpUtility.ParseQueryString(string.Empty);
            IFormatProvider culture = new CultureInfo(CULTURE, true);

            query["house"] = House.Commons;
            query["startDate"] = startDate.ToString(SHORT_DATE_FORMAT, culture);
            query["endDate"] = endDate.ToString(SHORT_DATE_FORMAT, culture);

            string queryString = query.ToString();
            string url = CALENDAR_URL + "?" + queryString;

            string responseXml = await _http.GetStringAsync(url);
            XmlSerializer serializer = new XmlSerializer(typeof(List<Event>), new XmlRootAttribute("ArrayOfEvent"));
            StringReader stringReader = new StringReader(responseXml);
            List<Event> eventList = (List<Event>)serializer.Deserialize(stringReader);

            return eventList;
        }
    }
}
