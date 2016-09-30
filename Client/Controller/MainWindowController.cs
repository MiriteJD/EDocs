using System;
using System.Collections.ObjectModel;
using System.ServiceModel.Channels;
using System.Windows;
using Client.Container;

namespace Client.Controller
{
    using Views;
    using ViewModels;
    using Framework;
    using DocReference;

    public class MainWindowController
    {
        private MainWindow _view;
        private MainViewModel _viewModel;
        private Program _program;

        public MainWindowController()
        {
            _program = Program.Instance;


            _viewModel = new MainViewModel()
            {
                Dossiers = _program.GetAllDossiers(),
                AddDossierCommand =  new RelayCommand(AddDossier,CanAddDos),
                DeleteDossierCommand = new RelayCommand(DeleteDossier,CanDeleteDossier),
                AddDocumentCommand = new RelayCommand(AddDoc,CanAddDoc),
                DeleteDocumentCommand = new RelayCommand(DeleteDocument, CanDeleteDoc),
                OpenKwViewCommand = new RelayCommand(OpenKwView)

                
            };

            //_viewModel.SelectedDossier = _viewModel.Dossiers[0];


            //Test ob Doc einem Dos zugeordnet werden kann
            //var doc = new DocContainer("new doc");
            //_viewModel.Dossiers[1].AddDoc(doc);

            _view = new MainWindow()
            {
                DataContext = _viewModel
            };


            _view.ShowDialog();
        }

        #region DOS
        private void AddDossier(object obj)
        {
            var dos = _program.AddnewDos();
            if (dos != null)
            {
                _viewModel.Dossiers.Add(dos);
            }
        }


        private bool CanAddDos(object obj)
        {
            return _viewModel.SelectedDossier != null;
        }


        private bool CanDeleteDossier(object obj)
        {
            return _viewModel.SelectedDossier != null;
        }


        private void DeleteDossier(object obj)
        {
            try
            {

                var messageResult = MessageBox.Show("Wollen Sie die Akte wirklich löschen?", "Sie sind im Begriff eine Aktion auszuführen",
                    MessageBoxButton.YesNoCancel, MessageBoxImage.Warning);
                if (messageResult == MessageBoxResult.Yes)
                {
                    if (_program.DeleteDossier(_viewModel.SelectedDossier))
                    {
                        _viewModel.Dossiers.Remove(_viewModel.SelectedDossier);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                Console.ReadLine();
            }
           
        }
        #endregion

        #region DOC
        private void DeleteDocument(object obj)
        {
            try
            {
                var messageResult = MessageBox.Show("Wollen Sie das Dokument wirklich löschen?", "Sie sind im Begriff eine Aktion auszuführen",
                      MessageBoxButton.YesNoCancel, MessageBoxImage.Warning);
                if (messageResult == MessageBoxResult.Yes)
                {
                    if (_program.DeleteDocument(_viewModel.SelectedDocument))
                    {
                        _viewModel.Documents.Remove(_viewModel.SelectedDocument);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                Console.ReadLine();
            }

        }
     
        private void AddDoc(object obj)
        {
            var model = new Document
            {
                CreationDate = DateTime.Now,
                Comment = "Neues Dokument",
                Version = 1,
                DossierId = _viewModel.SelectedDossier.Instanz.Id

            };
            var doc = _program.AddnewDoc(new DocContainer(model), _viewModel.SelectedDossier);
            if (_viewModel.Documents == null)
            {

                _viewModel.Documents = new ObservableCollection<DocContainer>();
            }
            _viewModel.Documents.Add(doc);
        }


        private bool CanAddDoc(object obj)
        {
            return _viewModel.SelectedDossier != null;
        }
       


        private bool CanDeleteDoc(object obj)
        {
            return _viewModel.SelectedDocument != null;
        }


        #endregion

        #region KW

        private void OpenKwView(object obj)
        {
            try
            {
                KeywordsWindow window = new KeywordsWindow();
                window.ShowDialog();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                Console.ReadLine();
            }
        }
        #endregion







    }
}
