using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

using Newtonsoft.Json;

namespace ActivityServiceWebRole
{
    [ServiceContract]
    public interface IActivityDetailsService
    {
        [OperationContract]
        [WebInvoke(UriTemplate = "/checkservice/{value}", Method = "GET", ResponseFormat = WebMessageFormat.Json)]
        string CheckService(string value);

        [OperationContract]
        [WebInvoke(UriTemplate = "/activitydetails", Method = "GET", ResponseFormat = WebMessageFormat.Json)]
        IEnumerable<ActivityDetailDataContract> GetActivityDetails();
    }

    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class ActivityDetailDataContract
    {
        [DataMember]
        public DateTime DateTimeStamp { get; set; }

        [DataMember]
        public string UserName { get; set; }

        [DataMember]
        public string Action { get; set; }

        [DataMember]
        public string Description { get; set; }
    }
}