using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace TrainingMeetingService.Models
{
    [DataContract]
    public class SaveDietAndTrainingPlanRequest
    {
        [DataMember]
        public string TrainingPlan { get; set; }
        [DataMember]
        public string Diet { get; set; }
    }
}
