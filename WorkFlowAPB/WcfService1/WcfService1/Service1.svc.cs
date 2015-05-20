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
        public ChooseBestSubscriptionResponse ChooseBestSubscription(ChooseBestSubscriptionRequest request)
        {
            throw new NotImplementedException();
        }

        public CreateClientAccountResponse CreateClientAccount(CreateClientAccountRequest request)
        {
            throw new NotImplementedException();
        }

        public SaveClientSurveyResponse SaveClientSurvey(SaveClientSurveyRequest request)
        {
            throw new NotImplementedException();
        }

        public SaveSubscriptionResponse SaveSubscription(SaveSubscriptionRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
