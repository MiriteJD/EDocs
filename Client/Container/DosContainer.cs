using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using Client.Framework;

namespace Client.Container
{
    using DocReference;
    public class DosContainer : ViewModelBase
    {

        public Dossier Instanz { get; set; }

        public DosContainer(Dossier dossier)
        {
            this.Instanz = dossier;
            if(Instanz.Documents == null)
                Instanz.Documents = new Document[dossier.Documents.Length];
            var counter = 0;
            foreach (var doc in dossier.Documents)
            {
                Instanz.Documents[counter] = doc;
                counter++;
            }
        }


        private ObservableCollection<DocContainer> _docs;

        public ObservableCollection<DocContainer> Docs
        {
            get { return _docs; }
            set
            {
                _docs = value;
                OnPropertyChanged();
            }
        }

        public string Name
        {
            get
            { return Instanz.Name; }
            set
            {
                if (Instanz.Name != value)
                {
                    bool isNew = Instanz.Name == null;
                    Instanz.Name = string.IsNullOrWhiteSpace(value) ? "Neue Akte" : value;
                    if (!isNew)
                    {
                        Program.Instance.UpdateDossier(this);
                    }
                }
            }
        }

        public string Nr
        {
            get { return Instanz.Nr; }
            set { Instanz.Nr = value; }
        }

        public int Version
        {
            get { return Instanz.Version; }
            set { Instanz.Version = value; }
        }


        public string Comment
        {
            get { return Instanz.Comment; }
            set { Instanz.Comment = value; }

        }

        public int CountEntries
        {
            get { return Instanz.Documents.Length; }
        }

        public int Year
        {
            get { return Instanz.Year; }
            set { Instanz.Year = value; }
        }

        public DateTime CreationDate
        {
            get { return Instanz.CreationDate; }
            set { Instanz.CreationDate = value; }
        }

        public void AddDoc(DocContainer document)
        {
            try
            {
                if (Instanz.Documents == null)
                {
                    Instanz.Documents = new Document[1];
                    Instanz.Documents[0] = document.Instanz;
                }
                else
                {
                    var Doc = new Document[Instanz.Documents.Length + 1];
                    int targetsize = Instanz.Documents.Length;
                    for (int i = 0; i < targetsize; i++)
                    {
                        Doc[i] = Instanz.Documents[i];
                    }
                    Doc[targetsize] = document.Instanz;
                    Instanz.Documents = Doc;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                Console.ReadLine();
            }
        }
    }
}