using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Globalization;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace MemberClient
{
    public class HttpMemberClient : IMemberClient
    {
        private string CALENDAR_URL = "http://data.parliament.uk/membersdataplatform/services/mnis/members/query/";

        private string CULTURE = "en-GB";

        private string SHORT_DATE_FORMAT = "yyyy-MM-dd";

        private HttpClient _http;

        public HttpMemberClient(HttpClient http)
        {
            _http = http;
        }

        public async Task<IList<Member>> GetMember(int id)
        {
            NameValueCollection query = System.Web.HttpUtility.ParseQueryString(string.Empty);
            IFormatProvider culture = new CultureInfo(CULTURE, true);

            query["house"] = House.Commons;
            query["id"] = id.ToString();

            string queryString = query.ToString().Replace("&","|");
            string url = CALENDAR_URL + queryString;

            string responseXml = await _http.GetStringAsync(url);
            XmlSerializer serializer = new XmlSerializer(typeof(List<Member>), new XmlRootAttribute("Members"));
            StringReader stringReader = new StringReader(responseXml);
            List<Member> eventList = (List<Member>)serializer.Deserialize(stringReader);

            return eventList;
        }
    }
}
