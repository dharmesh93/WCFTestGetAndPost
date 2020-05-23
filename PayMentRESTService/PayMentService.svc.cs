using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Web.Helpers;

namespace PayMentRESTService
{

    public class PayMentService : IPayMentService
    {
        public void AddPayee(string Name, string City)
        {
           //write database related insert logic here.
        }
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
            //write database related data retrival logic here.
        }

        public void RemovePayee(string Id)
        {
            //write database related delete logic here.
        }

        public void UpdateBillPayment(string PayId, string TransId)
        {
            //write database related update logic here.
        }
    }
}
