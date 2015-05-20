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
    [ServiceContract]
    public interface ITrainingMeetingService
    {

        [OperationContract]
        SaveDietAndTrainingPlanResponse SaveDietAndTrainingPlan(SaveDietAndTrainingPlanRequest request);

        [OperationContract]
        SendClientNotificationResponse SendClientNotification(SendClientNotificationRequest request);

        [OperationContract]
        ProposeDatesResponse ProposeDates(ProposeDatesRequest request);

        [OperationContract]
        SaveChosenDateResponse SaveChosenDate(SaveChosenDateRequest request);

        [OperationContract]
        SaveChangesToDietResponse SaveChangesToDiet(SaveChangesToDietRequest request);
    }
}
