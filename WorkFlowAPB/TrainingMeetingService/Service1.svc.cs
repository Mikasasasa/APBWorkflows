using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using TrainingMeetingService.Models;

namespace TrainingMeetingService
{
    public class TrainingMeetingService : ITrainingMeetingService
    {
        public SaveDietAndTrainingPlanResponse SaveDietAndTrainingPlan(SaveDietAndTrainingPlanRequest request)
        {
            throw new NotImplementedException();
        }

        public SendClientNotificationResponse SendClientNotification(SendClientNotificationRequest request)
        {
            throw new NotImplementedException();
        }

        public ProposeDatesResponse ProposeDates(ProposeDatesRequest request)
        {
            throw new NotImplementedException();
        }

        public SaveChosenDateResponse SaveChosenDate(SaveChosenDateRequest request)
        {
            throw new NotImplementedException();
        }

        public SaveChangesToDietResponse SaveChangesToDiet(SaveChangesToDietRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
