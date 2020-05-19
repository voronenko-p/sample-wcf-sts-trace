using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WcfServicesA.ServiceReferenceB;

namespace WcfServicesA
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class ServiceA : IServiceA
    {

        public void DoSomething()
        {
        }


        public string GetSomething()
        {
            return DateTime.Today.ToString();

        }

        public string PassSomethingToB()
        {
            ServiceBClient client = null;
            try
            {
                client = new ServiceBClient();
                return client.GetSomething();
            }
            finally
            {
                client.Close();
            }
        }
    }
}
