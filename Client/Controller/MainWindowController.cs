using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Security.Tokens;
using System.Text;
using System.Threading.Tasks;

namespace Client.Controller
{
    using DocManagementReference;
    using Views;
    using ViewModels;

    public class MainWindowController
    {
        private MainWindow _view;
        private MainViewModel _viewModel;
        private Program _program;


        public MainWindowController()
        {

            _program = Program.Instance;
            _viewModel = new MainViewModel();
            _view = new MainWindow();
            _view.DataContext = _viewModel;
            _view = new MainWindow();
            



            
        }


    }
}
