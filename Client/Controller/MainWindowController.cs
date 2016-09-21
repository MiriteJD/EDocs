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
            //_view.DataContext = _viewModel;
            _view = new MainWindow();
            //_view.listBox.DataContext = _program.GetAllDossiers();

            _view.ShowDialog();



        }





        ///// <summary>
        ///// 
        ///// </summary>
        ///// <param name="obj"></param>
        //private void AddTaskList(object obj)
        //{
        //    var tasklist = _program.Add();
        //    if (tasklist != null)
        //    {
        //        _viewModel.Add(tasklist);
        //    }
        //}

        ///// <summary>
        ///// Command Enable Funktion zum AddTaskCommand
        ///// 
        ///// </summary>
        ///// <param name="obj"></param>
        ///// <returns> </returns>
        //private bool CanAddTask(object obj)
        //{
        //    return _viewModel.SelectedTasklist != null;
        //}

        ///// <summary>
        ///// Command Funktion zum Hinzufügen eines neuen Task
        ///// </summary>
        ///// <param name="obj"></param>
        //private void AddTask(object obj)
        //{
        //    var model = new Task
        //    {
        //        CreationDate = DateTime.Now,
        //        Description = "Neue Aufgabe",
        //        Priority = 2,
        //        ReminderMinutes = -1,
        //        Version = 1,
        //        State = false
        //    };

        //    var task = _dataService.AddTaskToList(_viewModel.SelectedTasklist, new TaskContainer(model, _viewModel.SelectedTasklist));
        //    _viewModel.SelectedTasklist.AddTask(task);
        //}

        ///// <summary>
        /////  Command Enable Funktion zum DeleteTaskListCommand
        ///// </summary>
        ///// <param name="obj"></param>
        ///// <returns>enable bool</returns>
        //private bool CanDeleteTaskList(object obj)
        //{
        //    return _viewModel.SelectedTasklist != null;
        //}

        ///// <summary>
        ///// Command Funktion zum löschen einer TaskListe
        ///// </summary>
        ///// <param name="obj"></param>
        //private void DeleteTaskList(object obj)
        //{
        //    if (_dataService.DeleteTasklist(_viewModel.SelectedTasklist))
        //    {
        //        _viewModel.TaskLists.Remove(_viewModel.SelectedTasklist);
        //    }
        //}


    }
}
