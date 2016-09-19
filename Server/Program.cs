using System;
using System.ServiceModel;
using Server.Model;
using Server;



namespace Server
{
    class Program
    {
        static void Main(string[] args)
        {
            var baseAddress = new Uri("http://localhost:8733/Design_Time_Addresses/Server/DocumentService/");
            using (ServiceHost host = new ServiceHost(typeof(DocumentService)))
            {
                //reset sqlite sequence 
                //UPDATE sqlite_sequence SET seq=0 WHERE name = "Dossiers"

                host.Open();


                Console.WriteLine($"The service is ready at {baseAddress}");
                Console.WriteLine("Press <Enter> to stop the service.");


                DocumentService service = new DocumentService();
                //var teskw = service.GetKeywordbyId(6);
                var result = service.DeleteKeyword(teskw);
                Console.WriteLine("deleting test kw3(1) status : " + result);


                Console.ReadLine();
                host.Close();
            }
        }
    }
}
