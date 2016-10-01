using System;
using System.Configuration;
using System.IO;
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


                //var currentPath = Path.GetFullPath(Path.Combine(Directory.GetCurrentDirectory(), @"..\..\"));
                //var appPath = Path.Combine(currentPath, "app.config");
                //var _path = ConfigurationManager.AppSettings["DossierPath"];
                //if (_path == null)
                //{
                //    Configuration config = ConfigurationManager.OpenExeConfiguration(appPath);

                //    config.AppSettings.Settings.Add("DossierPath", Directory.GetCurrentDirectory());

                //    config.Save(ConfigurationSaveMode.Modified);

                //    ConfigurationManager.RefreshSection("appSettings");
                //}

                //test KW
                //var teskw = new Keyword();
                //service.AddNewKeyword(teskw);

                //var allkw = service.GetAllKeywords();
                //foreach (var kw in allkw)
                //{
                //    Console.WriteLine("kw:  : " + kw.Name);
                //}
                //var result = service.DeleteKeyword(teskw);
                //Console.WriteLine("deleting test kw3(1) status : " + result);


                //test DOS
                //var alldos = service.GetAllDossiers();
                //foreach (var d in alldos)
                //{
                //    Console.WriteLine("kw:  : " + d.Name);
                //}



                Console.ReadLine();

                // Close the ServiceHost after finish
                host.Close();
            }
        }
    }
}