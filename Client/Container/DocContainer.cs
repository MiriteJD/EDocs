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
