using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace WcfService1.Models
{
    [DataContract]
    public class SaveSubscriptionResponse
    {
        [DataMember]
        public bool Result { get; set; }
    }
}
