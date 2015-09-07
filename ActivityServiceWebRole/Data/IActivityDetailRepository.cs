using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActivityServiceWebRole.Data
{
    interface IActivityDetailRepository
    {
        IQueryable<ActivityDetailDataContract> GetActivityDetails();
    }
}
