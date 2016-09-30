using System.Windows;
using Client.Container;
using Client.Framework;
using Client.ViewModels;
using Client.Views;

namespace Client.Controller
{
    public class KwController
    {
        private readonly KeywordsWindow _kwview;
        private readonly KwViewModel _kwviewModel;
        private Program _program;

        /// <summary>
        /// Constructor to bind everything together
        /// </summary>
        public KwController()
        {
            _program = Program.Instance;
            _kwviewModel = new KwViewModel()
            {
                AddKeywordCommand = new RelayCommand(AddKw),
                DeleteKeywordCommand = new RelayCommand(DeleteKw, CanDeleteKw),
                CloseCommand = new RelayCommand(Close),
                Keywords = _program.GetAllKeywords(),
            };

            _kwview = new KeywordsWindow()
            {
                DataContext = _kwviewModel
            };
        }

        //connect view - viewmodel 
        private void Close(object obj)
        {
            _kwview.Close();
        }

        private void AddKw(object obj)
        {
            var kw = Program.Instance.AddnewKeyword(new KeywordContainer("Neues Schlagwort"));
            if (kw != null)
            {
                _kwviewModel.Keywords.Add(kw);
            }

        }

        private bool CanDeleteKw(object obj)
        {
            return _kwviewModel.SelectedKw != null;
        }

        private void DeleteKw(object obj)
        {
            if (Program.Instance.DeleteKeyword(_kwviewModel.SelectedKw))
            {
                _kwviewModel.Keywords.Remove(_kwviewModel.SelectedKw);
            }
            else
            {
                MessageBox.Show("Das ausgewählte Schlagwort enthält noch Verweise auf Dokumente. Solange diese bestehen können Sie das Schlagwort nicht löschen","noch Verweise vorhanden",MessageBoxButton.OK,MessageBoxImage.Error);
            }
        }
    }
}
