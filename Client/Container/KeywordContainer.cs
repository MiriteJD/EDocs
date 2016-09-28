using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.Container
{
    using DocReference;
    public class KeywordContainer
    {

        public KeywordContainer(Keyword keyword)
        {
            this.Instanz = keyword;

        }

        public KeywordContainer(string name)
        {
            Instanz = new Keyword();
            Name = name;
            Version = 1;
        }

        public Keyword Instanz { get; set; }

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
                    Instanz.Name = string.IsNullOrWhiteSpace(value) ? "Neue Kategorie" : value;
                    if (!isNew)
                    {
                        Program.Instance.UpdateKeyword(this);
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



    }
}
