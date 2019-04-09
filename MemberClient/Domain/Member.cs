using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace MemberClient
{
    public class Member
    {
        public int Member_Id { get; set; }

        public int Dods_Id { get; set; }

        public int Pims_Id { get; set; }

        public int Clerks_Id { get; set; }

        public string DisplayAs { get; set; }

        public string ListAs { get; set; }

        public string FullTitle { get; set; }

        public string LayingMinisterName { get; set; }

        public DateTime? DateOfBirth { get; set; }

        public DateTime? DateOfDeath { get; set; }

        public string Gender { get; set; }

        public string Party { get; set; }

        public string House { get; set; }

        public string MemberFrom { get; set; }

        public DateTime? HouseStartDate { get; set; }

        public DateTime? HouseEndDate { get; set; }

        public CurrentStatus CurrentStatus { get; set; }
    }
}
