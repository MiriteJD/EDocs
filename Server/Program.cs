using System;
using System.ServiceModel;
using Server.Model;
using Server;
namespace Server
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var baseAddress = new Uri("http://localhost:8733/Design_Time_Addresses/Server/DocumentService/");
            using (ServiceHost host = new ServiceHost(typeof(DocumentService)))
            {
                //reset sqlite sequence 
                //UPDATE sqlite_sequence SET seq=0 WHERE name = "Dossiers"

                host.Open();


                Console.WriteLine($"Your service is ready at" + "\r\n"
                                  + "{baseAddress}" + "\r\n"
                                  + "If you want to stop the service press --Enter--" + "\r\n" + "\r\n");


                //DocumentService service = new DocumentService();

                //var teskw = new Keyword();
                //var all = service.GetAllDossiers();
                //foreach (var kw in all)
                //{
                //   Console.WriteLine(kw.Documents.Count);
                //}

                //var all = service.GetAllKeywords();
                //foreach (var kw in all)
                //{
                //    if (kw.Id == 6) teskw = kw;
                //}

                //var result = service.DeleteKeyword(teskw);

                //Console.WriteLine("deleting test kw3(1) status : " + result);


                Console.ReadLine();

                // Close the ServiceHost after finish
                host.Close();
            }
        }
    }
}