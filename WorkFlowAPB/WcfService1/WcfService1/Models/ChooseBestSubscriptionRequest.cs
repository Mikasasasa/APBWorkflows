using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WcfService1.Models
{
    [DataContract]
    public class ChooseBestSubscriptionRequest
    {
        [DataMember]
        public bool IsWholeDayImportant { get; set; }
        [DataMember]
        public bool IsWeekendIncluded { get; set; }
        [DataMember]
        public int TrainingsInWeek { get; set; }
    }
}