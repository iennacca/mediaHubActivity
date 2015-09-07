using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

using ActivityServiceWebRole.Data;

namespace ActivityServiceWebRole
{
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    [ServiceBehavior(IncludeExceptionDetailInFaults=true)]
    public class ActivityDetailsService : IActivityDetailsService
    {
        IActivityDetailRepository _repository = new AzureActivityRepository();

        public string CheckService(string value)
        {
            Trace.TraceInformation("Testing");
            return string.Format("Test: {0}", value);
        }

        public IEnumerable<ActivityDetailDataContract> GetActivityDetails()
        {
            
            return _repository.GetActivityDetails();
        }
    }
}
