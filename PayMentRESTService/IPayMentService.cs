using System.ServiceModel;
using System.ServiceModel.Web;

namespace PayMentRESTService
{

    [ServiceContract]
    public interface IPayMentService
    {
        //To Insert or POST Records
        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "/AddPayee/{Name}/{City}", BodyStyle = WebMessageBodyStyle.Wrapped, RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        void AddPayee(string Name, string City);

        //To Get Records from database 
        [OperationContract]
        [WebInvoke(Method = "GET",UriTemplate = "/ValidateToken/{Token}", BodyStyle = WebMessageBodyStyle.Wrapped,RequestFormat = WebMessageFormat.Json,ResponseFormat = WebMessageFormat.Json)]
        string ValidateToken(string Token);

        //To Update records
        [OperationContract]
        [WebInvoke(Method = "PUT", UriTemplate = "/UpdateBillPayment/{PayId}/{TransId}", BodyStyle = WebMessageBodyStyle.Wrapped, RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        void UpdateBillPayment(string PayId,string TransId);

        //To delete records
        [OperationContract]
        [WebInvoke(Method = "DELETE", UriTemplate = "/RemovePayee/{Id}", BodyStyle = WebMessageBodyStyle.Wrapped, RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        void RemovePayee(string Id);

    }
}
