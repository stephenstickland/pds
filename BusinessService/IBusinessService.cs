using BusinessService.Domain;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BusinessService
{
    public interface IBusinessService
    {
        Task<Week> GetWeek(DateTime startDate);
    }
}
