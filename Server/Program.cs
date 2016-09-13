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
                //Console.ReadLine();

                IDocumentService service = new DocumentService();
                var input = service.AddNewDossier();
                var result = service.GetAllDossiers();

                Console.WriteLine("Name neue Dossier: "+input.Name);
                Console.WriteLine("All Dossiers: "+result);
                Console.WriteLine("Count all Dossiers: " +result.Count);

                Console.ReadLine();
                host.Close();
            }
        }
    }
}
