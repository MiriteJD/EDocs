using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using TestApplication.ServiceReference;

namespace TestApplication
{
    public static class Program
    {
        public static IList<Dossier> Items;


        private static DocumentServiceClient _test;

        private static bool IsServiceRunning => _test.State == CommunicationState.Opened || _test.State == CommunicationState.Created;


        public static void Main(string[] args)
        {
            try
            {
                _test = new DocumentServiceClient();
                if (IsServiceRunning)
                {
                    Items = _test.GetAllDossiers();
                }

               

            }
            catch (Exception ex)
            {
                Console.WriteLine("Exeption: " + ex);
            }
        }
    }
}


////überprüfen dossiers
//var ret = test.GetAllDossiers();
//foreach (Dossier dossier in ret)
//{
//    Console.WriteLine("Dossiernummer: " + dossier.Nr);
//}
//Console.WriteLine("all Dossiers expensed");
//var newdos = new Dossier()
//{
//    Name = "Test dossier"
//};
//var dos = test.AddNewDossier(newdos);
//Console.WriteLine("Dossiernummer: " + dos.Nr + " erstellt");
////und wieder löschen
//if (test.DeleteDossier(dos)) Console.WriteLine("Dossier erfolgreich gelöscht/n");
//else Console.WriteLine("deleting gone wrong");

////überprüfen keywords
//Console.WriteLine("erstelle keyword");
//for (var i = 1; i < 4; i++)
//{
//    var newkw = new Keyword()
//    {
//        Name = "Test keyword" + i
//    };
//    var keyw = test.AddNewKeyword(newkw);
//    Console.WriteLine("Keyword name: " + newkw.Name);
//}
//var kws = test.GetAllKeywords();
//foreach (var kw in kws)
//{
//    Console.WriteLine("get all: " + kw.Name);
//}
////und wieder löschen

//foreach (var kw in kws)
//{
//    Console.WriteLine(kw.Name+" deleting: "+test.DeleteKeyword(kw));
//}
//Console.ReadLine();
