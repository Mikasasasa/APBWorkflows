using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace WcfService1.Models
{
    [DataContract]
    public class SaveSubscriptionRequest
    {
        [DataMember]
        public int ClientId { get; set; }
        [DataMember]
        public DateTime SubscriptionStart { get; set; }
        [DataMember]
        public DateTime SubscriptionEnd { get; set; }
        [DataMember]
        public int SubscriptionType { get; set; }
    }
}
