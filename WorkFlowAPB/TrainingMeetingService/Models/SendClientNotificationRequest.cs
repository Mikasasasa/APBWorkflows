using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace TrainingMeetingService.Models
{
    [DataContract]
    public class SendClientNotificationRequest
    {
        [DataMember]
        public string Text { get; set; }
        [DataMember]
        public string Receiver { get; set; }
    }
}
