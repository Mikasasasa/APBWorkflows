using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace TrainingMeetingService.Models
{
    [DataContract]
    public class SaveDietAndTrainingPlanResponse
    {
        [DataMember]
        public bool Result { get; set; }
    }
}
