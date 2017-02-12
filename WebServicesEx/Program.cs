using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.Text;
using System.Threading.Tasks;

namespace WebServicesEx
{
    class Program
    {
        static void Main(string[] args)
        {
            Uri baseAddress = new Uri("http://localhost:4321/Service1");

            using (ServiceHost host = new ServiceHost(typeof(Service1), baseAddress))
            {
                ServiceMetadataBehavior smb = new ServiceMetadataBehavior();
                smb.HttpGetEnabled = true;
                smb.MetadataExporter.PolicyVersion = PolicyVersion.Policy15;
                host.Description.Behaviors.Add(smb);

                host.Open();
                Console.WriteLine("The service is running at {0}", baseAddress);
                Console.WriteLine("press enter to stop the service");

                host.Close();
            }
        }
    }
}
