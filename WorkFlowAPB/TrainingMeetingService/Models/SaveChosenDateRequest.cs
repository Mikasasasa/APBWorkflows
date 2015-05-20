using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace TrainingMeetingService.Models
{
    [DataContract]
    public class SaveChosenDateRequest
    {
        [DataMember]
        public DateTime AcceptedDate { get; set; }
    }
}
