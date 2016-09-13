using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestApplication.ServiceReference;

namespace TestApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var test = new DocumentServiceClient();
            //var dos = test.AddNewDossier();
            var ret = test.GetAllDossiers();
            //Keyword keyword = new Keyword()
            //{
            //    Name = "hello"

                

            //};
            //var keyw = test.AddNewKeyword(keyword);


            Console.WriteLine(test.GetAllDossiers());
            //ReturnObject packet = test.AddKeywords("Testword");
            Console.WriteLine(ret.Length);
            Console.ReadLine();




        }
    }
}
