using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Client.DocManagementReference;

namespace Client.Container
{
    public class DocContainer
    {
        public DocContainer(Document document)
        {
            this.Instanz = document;
        }

        public DocContainer(string name)
        {
            Instanz = new Document();
            Name = name;
            Version = 1;
        }

        public Document Instanz { get; set; }

        public string Name
        {
            get
            {
                return Instanz.Filename;
            }
            set
            {
                if (Instanz.Filename != value)
                {
                    bool isNew = Instanz.Filename == null;
                    Instanz.Filename = string.IsNullOrWhiteSpace(value) ? "Neues Dokument" : value;
                    if (!isNew)
                    {
                        //Program.Instance.UpdateDocument(this);
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
