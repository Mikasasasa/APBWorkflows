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
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        ChooseBestSubscriptionResponse ChooseBestSubscription(ChooseBestSubscriptionRequest request);

        [OperationContract]
        CreateClientAccountResponse CreateClientAccount(CreateClientAccountRequest request);

        [OperationContract]
        SaveClientSurveyResponse SaveClientSurvey(SaveClientSurveyRequest request);

        [OperationContract]
        SaveSubscriptionResponse SaveSubscription(SaveSubscriptionRequest request);

        
    }
}
