using System.Collections.ObjectModel;
using Client.Container;

namespace Client
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using DocReference;
    public class Program
    {
        private readonly DocumentServiceClient _serviceReference;
        

        /// <summary>
        /// Konstruktor
        /// </summary>
        private Program()
        {
            _serviceReference = new DocumentServiceClient();
        }

        private static Program _instanz;

      
		public static Program Instance
        {
            get
            {
                if (_instanz == null)
                {
                    _instanz = new Program();
                }
                return _instanz;
            }
        }


        //Connect Service Reference --> local Instace

        #region KW
        /// <summary>
        /// adds a new keyword
        /// </summary>
        /// <param name="keyword"></param>
        /// <returns>the new keyword</returns>
        public KeywordContainer AddnewKeyword(KeywordContainer keyword)
        {
            try
            {
                var addKService = _serviceReference.AddNewKeyword(keyword.Instanz);
                return new KeywordContainer(addKService);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                Console.ReadLine();
                return null;
            }
        }

        /// <summary>
        /// deletes keyword
        /// </summary>
        /// <param name="keyword"></param>
        /// <returns>success of operation</returns>
        public bool DeleteKeyword(KeywordContainer keyword)
        {
            try
            {

                var deleteKService = _serviceReference.DeleteKeyword(keyword.Instanz);
                return deleteKService;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                Console.ReadLine();
                return false;
            }
        }

        /// <summary>
        /// edits a keyword
        /// </summary>
        /// <param name="keyword"></param>
        /// <returns>container of keyword</returns>
        public KeywordContainer UpdateKeyword(KeywordContainer keyword)
        {
            try
            {
                var updateKService = _serviceReference.EditKeyword(keyword.Instanz);
                return new KeywordContainer(updateKService);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                Console.ReadLine();
                return null;
            }
        }

        public ObservableCollection<KeywordContainer> GetAllKeywords()
        {
            try
            {
                var allKwService = _serviceReference.GetAllKeywords();
                return new ObservableCollection<KeywordContainer>(allKwService.Select(kwList => new KeywordContainer(kwList)).ToList());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                Console.ReadLine();
                return null;
            }
        }
        #endregion KW


        #region DOSSIERS


        public ObservableCollection<DosContainer> GetAllDossiers()
        {
            try
            {
                var allDosService = _serviceReference.GetAllDossiers();
                return new ObservableCollection<DosContainer>(allDosService.Select(dosList => new DosContainer(dosList)).ToList());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                Console.ReadLine();
                return null;
            }
        }

        public DosContainer AddnewDos()
        {
            try
            {
                var dos = new Dossier()
                {
                    Name = "Neue Akte"

                };
                var addDosService = _serviceReference.AddNewDossier(dos);
                return new DosContainer(addDosService);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                Console.ReadLine();
                return null;
            }
        }


        public DosContainer UpdateDossier(DosContainer dossier)
        {
            try
            {
                //var updateDosService = _serviceReference.EditDossier(dossier.Instanz,dossier.Name,)
                return null;
                //new DosContainer(updateDosService);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                Console.ReadLine();
                return null;
            }
        }

        public bool DeleteDossier(DosContainer dossier)
        {
            try
            {
                if (_serviceReference.DeleteDossier(dossier.Instanz))
                    return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                Console.ReadLine();
                return false;
            }
            return false;
        }



        #endregion


        #region DOCUMENTS
        public DocContainer AddnewDoc(DocContainer document, DosContainer dossier)
        {
            try
            {
                var addDocService = _serviceReference.AddDocumentToDossier(dossier.Instanz, document.Instanz);
                return new DocContainer(addDocService);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                Console.ReadLine();
                return null;
            }
        }

        public DocContainer UpdateDocument(DocContainer document, DosContainer dossier)
        {
            try
            {
                var updateDocService = _serviceReference.EditDocument(dossier.Instanz, document.Instanz);
                return new DocContainer(updateDocService);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                Console.ReadLine();
                return null;
            }
        }

        public ObservableCollection<DocContainer> GetDocumentsByDossier(DosContainer dossier)
        {
            try
            {
                var allDocService = _serviceReference.GetAllDocumentsByDosId(dossier.Instanz.Id);
                return new ObservableCollection<DocContainer>(allDocService.Select(docList => new DocContainer(docList)).ToList());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                Console.ReadLine();
                return new ObservableCollection<DocContainer>();
            }
        }

        public bool DeleteDocument(DocContainer document)
        {
            try
            {
                if (_serviceReference.DeleteDocument(document.Instanz))
                    return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                Console.ReadLine();
                return false;
            }
            return false;
        }



        #endregion

    }
}