using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Client.Container;

namespace Client.ViewModels
{
    public class MainViewModel
    {
        private ObservableCollection<DosContainer> _dossiers;

        private ObservableCollection<DosContainer> _currentDossiers;

        private DosContainer _selectedDossier;

        private DocContainer _selectedDocument;



        public ObservableCollection<DosContainer> Dossiers
        {
            get
            {
                return _dossiers;
            }
            set
            {
                _dossiers = value;
            }
        }


        //für die Button Reference, da binding nur über ICommand --> Binding 

        public ICommand AddDossierCommand { get; set; }

        public ICommand DeleteDossierCommand { get; set; }

        public ICommand AddDocumentCommand { get; set; }

        public ICommand DeleteDocumentCommand { get; set; }




    }



}
