using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace TrainingMeetingService.Models
{
    [DataContract]
    public class SaveChangesToDietRequest
    {
        [DataMember]
        public string NewDietText { get; set; }
    }
}
