using System.Runtime.Serialization;

namespace TrainingMeetingService.Models
{
    public class SaveChangesToDietResponse
    {
        [DataMember]
        public bool Result { get; set; }
    }
}
