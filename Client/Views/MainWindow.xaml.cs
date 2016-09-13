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
using Client.DocManagementReference;
using Client.ViewModels;

namespace Client.Views
{
    using DocManagementReference;
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private Program _program;

        private MainViewModel _viewModel;

        private DocumentServiceClient _service;



        private void button_Click(object sender, RoutedEventArgs e)
        {
            var dossier = _service.AddNewDossier();
            if (dossier != null)
                listBox.Items.Add(dossier);


        }
    }
}
