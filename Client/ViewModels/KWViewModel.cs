using System.Collections.ObjectModel;
using System.Windows.Input;
using Client.Container;
using Client.Framework;
using Client.Views;

namespace Client.ViewModels
{
    public class KwViewModel : ViewModelBase
    {
        private ObservableCollection<KeywordContainer> _keywords;

        private KeywordContainer _selectedKeyword;

        public ObservableCollection<KeywordContainer> Keywords
        {
            get
            {
                return _keywords;
            }
            set
            {
                _keywords = value;
                OnPropertyChanged();
            }
        }


        public KeywordContainer SelectedKw
        {
            get
            {
                return _selectedKeyword;
            }
            set
            {
                _selectedKeyword = value;
                OnPropertyChanged();
            }
        }


        //für die Button Reference, da binding nur über ICommand --> Binding 

        public ICommand AddKeywordCommand { get; set; }

        public ICommand DeleteKeywordCommand { get; set; }

        public ICommand CloseCommand { get; set; }

    }



}

