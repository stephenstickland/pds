using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MemberClient
{
    public interface IMemberClient
    {
        Task<IList<Member>> GetMember(int id);
    }
}
