using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.ServiceModel.Web;
using System.Text;
using System.Web.Helpers;

namespace AjaxEnabledWCFServiceApplication
{
    [ServiceContract(Namespace = "Multiplication")]
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    public class Service
    {
        // To use HTTP GET, add [WebGet] attribute. (Default ResponseFormat is WebMessageFormat.Json)
        // To create an operation that returns XML,
        //     add [WebGet(ResponseFormat=WebMessageFormat.Xml)],
        //     and include the following line in the operation body:
        //         WebOperationContext.Current.OutgoingResponse.ContentType = "text/xml";
        [OperationContract]
        [System.ServiceModel.Web.WebInvoke(Method = "POST", ResponseFormat = WebMessageFormat.Json)]
        public int Multiplication(int Number)
        {
            return Number * Number;
        }

        [OperationContract]
        [WebGet(UriTemplate= "GetToken/{Token}", ResponseFormat = WebMessageFormat.Json)]
        public string GetToken(string Token)
        {
            string cookieToken = "";
            string formToken = "";

            string[] tokens = Token.Split('|');
            if (tokens.Length == 2)
            {
                cookieToken = tokens[0].Trim();
                formToken = tokens[1].Trim();
            }

            AntiForgery.Validate(cookieToken, formToken);
            return "success";
        }

        [OperationContract]
        [System.ServiceModel.Web.WebInvoke(Method = "POST", ResponseFormat = WebMessageFormat.Json)]
        public string ValidateToken(string Token)
        {
            string cookieToken = "";
            string formToken = "";

            string[] tokens = Token.Split('|');
            if (tokens.Length == 2)
            {
                cookieToken = tokens[0].Trim();
                formToken = tokens[1].Trim();
            }

            AntiForgery.Validate(cookieToken, formToken);
            return "success";
        }

        // Add more operations here and mark them with [OperationContract]
    }
}
