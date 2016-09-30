using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace Client.Container
{
    using DocReference;
    public class DocContainer
    {
        public DocContainer(Document document)
        {
            Instanz = document;
        }

        public DocContainer(string name)
        {
            Instanz = new Document();
            Filename = name;
            Version = 1;

        }

        public Document Instanz { get; set; }

        public string Filename
        {
            get
            {
                return Instanz.Filename;
            }
            set
            {
                Instanz.Filename = value;
            }
        }

        public ObservableCollection<KeywordContainer> Keywords
        {
            get
            {
                return new ObservableCollection<KeywordContainer>(Instanz.Keywords.Select(kwList => new KeywordContainer(kwList)).ToList()); ;
            }
            set
            {
                foreach (var val in value)
                {
                    //TODO implement
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
    }
}
