using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace WcfService1.Models
{
    [DataContract]
    public class SaveClientSurveyRequest
    {
        [DataMember]
        public int ClientId { get; set; }
        [DataMember]
        public List<ClientsSurveyQuestion> Answers { get; set; }
    }
}
