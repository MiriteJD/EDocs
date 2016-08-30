using System;
using System.ServiceModel;
using Server.Repository;



namespace Server
{
    class Program
    {
        static void Main(string[] args)
        {
            var baseAddress = new Uri("http://localhost:8733/Design_Time_Addresses/Server/DocumentService/");
            using (var host = new ServiceHost(typeof(DocumentService)))
            {
                host.Open();

                Console.WriteLine($"The service is ready at {baseAddress}");
                Console.WriteLine("Press <Enter> to stop the service.");
                Console.ReadLine();

                host.Close();
            }
        }
    }
}
