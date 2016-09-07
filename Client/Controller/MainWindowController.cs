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
        private MainWindow _oMainWindow;
        private MainWindow _view;
        private Program _program;


        public MainWindowController()
        {
            _viewModel = new MainViewModel();
            _viewModel.AddTaskListCommand = new RelayCommand(AddTaskList);
            _viewModel.AddTaskCommand = new RelayCommand(AddTask, CanAddTask);
            _viewModel.DeleteTaskListCommand = new RelayCommand(DeleteTaskList, CanDeleteTaskList);
            _viewModel.DeleteTaskCommand = new RelayCommand(DeleteTask, CanDeleteTask);
            _viewModel.ManageTaskCategoriesCommand = new RelayCommand(ManageTaskCategories, CanManageTaskCategories);
            _viewModel.ManageAvailableCategoriesCommand = new RelayCommand(ManageCategories);
            _viewModel.ExportTasklistCommand = new RelayCommand(ExportTasklist, CanExportTasklist);
            _viewModel.ImportTasklistCommand = new RelayCommand(ImportTasklist, CanImportTasklist);
            _viewModel.SortTasksCommand = new RelayCommand(SortTasks, CanSortTasks);
            _viewModel.RemoveDueDateCommand = new RelayCommand(RemoveDueDate, CanRemoveDueDate);
            _viewModel.TaskLists = _program.GetAllTasklists();
            _view = new MainWindow();
            _view.DataContext = _viewModel;
            _oMainWindow = new MainWindow();
            



            
        }


    }
}
