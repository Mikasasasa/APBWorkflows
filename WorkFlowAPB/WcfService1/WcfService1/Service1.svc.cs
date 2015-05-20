using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using WcfService1.Models;

namespace WcfService1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        //public ChooseBestSubscriptionResponse ChooseBestSubscription(ChooseBestSubscriptionRequest request)
        //{
        //    throw new NotImplementedException();
        //}

        public CreateClientAccountResponse CreateClientAccount(CreateClientAccountRequest request)
        {
            var response = new CreateClientAccountResponse();
            if (request.Name.Length > 3 && request.Surname.Length > 3 &&
                (request.BirthDate - DateTime.Now).TotalDays/365 > 18)
            {
                var rnd = new Random();
                response.Id = rnd.Next(1, 50000);
            }
            else
            {
                throw new Exception("Data isn't valid.");
            }
            return response;
        }

        public SaveClientSurveyResponse SaveClientSurvey(SaveClientSurveyRequest request)
        {
            return new SaveClientSurveyResponse {Result = true};
        }

        public SaveSubscriptionResponse SaveSubscription(SaveSubscriptionRequest request)
        {
            return new SaveSubscriptionResponse {Result = true};
        }
    }
}
