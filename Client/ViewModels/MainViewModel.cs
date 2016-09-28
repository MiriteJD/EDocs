using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Input;
using Client.Container;
using Client.Framework;

namespace Client.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        private ObservableCollection<DosContainer> _dossiers;

        private ObservableCollection<DocContainer> _currentDocuments;

        private DosContainer _selectedDossier;

        private DocContainer _selectedDocument;


        #region DOS
        public ObservableCollection<DosContainer> Dossiers
        {
            get
            {
                return _dossiers;
            }
            set
            {
                _dossiers = value;
                OnPropertyChanged();
            }
        }


        public DosContainer SelectedDossier
        {
            get
            {
                return _selectedDossier;
            }
            set
            {
                _selectedDossier = value;
                OnPropertyChanged();
                //bool isnull = SelectedDossier != null;
                //OnPropertyChanged(nameof(isnull));


            }
        }
        #endregion



        #region DOC
        public ObservableCollection<DocContainer> Documents
        {
            get
            {
                return _currentDocuments;
            }
            set
            {
                _currentDocuments = value;
                OnPropertyChanged();
            }
        }


        public DocContainer SelectedDocument
        {
            get
            {
                return _selectedDocument;
            }
            set
            {
                _selectedDocument = value;
                OnPropertyChanged();
                //bool isnull = SelectedDocument != null;
                //OnPropertyChanged(nameof(isnull));
            }
        }


        #endregion



        //für die Button Reference, da binding nur über ICommand --> Binding 

        public ICommand AddDossierCommand { get; set; }

        public ICommand DeleteDossierCommand { get; set; }
        public ICommand SaveDossierCommand { get; set; }

        public ICommand AddDocumentCommand { get; set; }

        public ICommand DeleteDocumentCommand { get; set; }

        public ICommand SaveDocumentCommand { get; set; }

        public ICommand OpenKwViewCommand { get; set; }




    }



}
