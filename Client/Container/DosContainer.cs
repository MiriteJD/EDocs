using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Client.DocManagementReference;

namespace Client.Container
{
    public class DosContainer
    {
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
                            Program.Instance.UpdateDossier(this);
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

}
}
