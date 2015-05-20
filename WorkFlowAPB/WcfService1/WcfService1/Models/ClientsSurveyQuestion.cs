using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace WcfService1.Models
{
    [DataContract]
    public class ClientsSurveyQuestion
    {
        [DataMember]
        public string Question { get; set; }
        [DataMember]
        public string Answer { get; set; }
    }
}
