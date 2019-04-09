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
        private string MEMBER_URL = "http://data.parliament.uk/membersdataplatform/services/mnis/members/query/";

        private string CULTURE = "en-GB";

        private readonly IHttpClientFactory _httpClientFactory;

        public HttpMemberClient(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IList<Member>> GetMember(int id)
        {
            NameValueCollection query = System.Web.HttpUtility.ParseQueryString(string.Empty);

            query["house"] = House.Commons;
            query["id"] = id.ToString();

            string queryString = query.ToString().Replace("&","|");
            string url = MEMBER_URL + queryString;

            string responseXml = await _httpClientFactory.CreateClient().GetStringAsync(url);
            XmlSerializer serializer = new XmlSerializer(typeof(List<Member>), new XmlRootAttribute("Members"));
            StringReader stringReader = new StringReader(responseXml);
            List<Member> list = (List<Member>)serializer.Deserialize(stringReader);

            return list;
        }

        public async Task<IList<Member>> GetMembers()
        {
            NameValueCollection query = System.Web.HttpUtility.ParseQueryString(string.Empty);

            query["house"] = House.Commons;

            string queryString = query.ToString().Replace("&", "|");
            string url = MEMBER_URL + queryString;

            string responseXml = await _httpClientFactory.CreateClient().GetStringAsync(url);
            XmlSerializer serializer = new XmlSerializer(typeof(List<Member>), new XmlRootAttribute("Members"));
            StringReader stringReader = new StringReader(responseXml);
            List<Member> list = (List<Member>)serializer.Deserialize(stringReader);

            return list;
        }
    }
}
