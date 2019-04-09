using BusinessService.Domain;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BusinessApiTests
{
    public interface IBusinessController
    {
        Task<ActionResult<BusinessItem>> Get(DateTime startDate, DateTime endDate, int id);

        Task<ActionResult<Period>> Get(DateTime startDate, DateTime endDate);
    }
}
