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
            if (request.Diet.Length < 200)
            {
                throw new Exception("Diet is not valid");
            }
            else if (request.TrainingPlan.Length < 300)
            {
                throw new Exception("Training Plan is not valid");
            }

            return new SaveDietAndTrainingPlanResponse { Result = true };
        }

        public SendClientNotificationResponse SendClientNotification(SendClientNotificationRequest request)
        {
            return new SendClientNotificationResponse { Result = true };
        }

        public ProposeDatesResponse ProposeDates(ProposeDatesRequest request)
        {
            var availableDays = new List<DateTime>();
            for (var i = 0; i < 3; ++i)
            {
                availableDays.Add(new DateTime().AddDays(i));
            }
            return new ProposeDatesResponse { ProposedDateTimes = availableDays.ToArray() };
        }

        public SaveChosenDateResponse SaveChosenDate(SaveChosenDateRequest request)
        {
            return new SaveChosenDateResponse { Result = true };
        }

        public SaveChangesToDietResponse SaveChangesToDiet(SaveChangesToDietRequest request)
        {
            if (request.NewDietText.Length < 300)
            {
                throw new Exception("Diet is not valid");
            }

            return new SaveChangesToDietResponse { Result = true };
        }
    }
}
