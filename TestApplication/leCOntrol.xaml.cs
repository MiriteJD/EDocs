using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using TestApplication.ServiceReference;

namespace TestApplication
{
    /// <summary>
    /// Interaction logic for UserControl1.xaml
    /// </summary>
    public partial class leCOntrol 
    {
        public leCOntrol()
        {
            InitializeComponent();

            var test = new DocumentServiceClient();


            Items = test.GetAllDossiers();

        }

        public static IList<Dossier> Items { get; set; }




    }

}
