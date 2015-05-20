using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace TrainingMeetingService.Models
{
    public class ProposeDatesResponse
    {
        [DataMember]
        public DateTime[] ProposedDateTimes { get; set; }
    }
}
