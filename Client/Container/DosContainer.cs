using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using Client.DocManagementReference;

namespace Client.Container
{
    public class DosContainer:INotifyPropertyChanged
    {
        private ObservableCollection<DocContainer> _tasks;

        public event PropertyChangedEventHandler PropertyChanged;

        public ObservableCollection<DocContainer> Docs { get; set; }

        public DosContainer(Dossier dossier)
        {
            this.Instanz = dossier;

        }

        public DosContainer(string name)
        {
            Instanz = new Dossier();
            Name = name;
            Version = 1;
        }

        public Dossier Instanz { get; set; }

        public string Name
        {
            get
            {
                return Instanz.Name;
            }
            set
            {
                if (Instanz.Name != value)
                {
                    bool isNew = Instanz.Name == null;
                    Instanz.Name = string.IsNullOrWhiteSpace(value) ? "Neue Akte" : value;
                    if (!isNew)
                    {
                        //Program.Instance.UpdateDossier(this);
                    }
                }
            }
        }



        public int Version
        {
            get
            {
                return Instanz.Version;
            }
            set
            {
                Instanz.Version = value;
            }
        }

        //public int CountEntries
        //{
        //    get { return Instanz.Documents.Length; }
        //}

        public void AddTask(DocContainer document)
        {
        //    Instanz.Documents.Add(document.Instanz);
        //    Docs.Add(document);
        }




    }
}