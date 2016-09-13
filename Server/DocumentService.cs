using System;
using System.Collections.Generic;
using System.IO;
using Server.Model;
using Server.Repository;

namespace Server
{
    public class DocumentService : IDocumentService
    {

        private readonly DossierRepository _dossierRepository;

        private readonly DocumentRepository _documentRepository;

        private readonly KeywordRepository _keywordRepository;

        public DocumentService()
        {
            var relativePath = @"Database\DocManager.db3";
            string currentPath = Path.GetFullPath(Path.Combine(Directory.GetCurrentDirectory(), @"..\..\"));
            var absolutePath = Path.Combine(currentPath, relativePath);

            _dossierRepository = new DossierRepository(absolutePath);
            _documentRepository = new DocumentRepository(absolutePath);
            _keywordRepository = new KeywordRepository(absolutePath);
        }

        #region DOSSIERS
        public IList<Dossier> GetAllDossiers()
        {
            try
            {
                return _dossierRepository.GetAll();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            return new List<Dossier>();
        }

        public Dossier AddNewDossier()
        {
            try
            {
                var dossier = new Dossier()
                {
                    Name = "Neue Liste"
                };
                return _dossierRepository.Save(dossier);
            }
            catch (Exception ex)
            {
                Console.Write(ex);
                return null;
            }

        }

        public Dossier EditDossier(Dossier dossier)
        {
            try
            {
                foreach (var doc in dossier.Documents)
                {
                    doc.DossierId = dossier.Id;
                }
                return _dossierRepository.Update(dossier);
            }
            catch (Exception ex)
            {
                Console.Write(ex);
            }
            return new Dossier();

        }

        public bool DeleteDossier(Dossier dossier)
        {
            try
            {
               return _dossierRepository.Delete(dossier);
            }
            catch (Exception ex)
            {
                Console.Write(ex);
                return false;
            }
        }
        #endregion

        #region DOCS

        public Document AddDocumentToDossier(Dossier dossier, Document document)
        {
            try
            {
                dossier.AddDocument(document);
                _dossierRepository.Update(dossier);
                return document;
            }
            catch (Exception ex)
            {
                Console.Write(ex);
            }
            return new Document();
        }

        public Document EditDocument(Dossier dossier, Document doc)
        {
            try
            {
                doc.DossierId = dossier.Id;
                return _documentRepository.Update(doc);
            }
            catch (Exception ex)
            {
                Console.Write(ex);
            }
            return new Document();
        }

        public bool DeleteDocument(Document doc)
        {
            try
            {
                return _documentRepository.Delete(doc);
            }
            catch (Exception ex)
            {
                Console.Write(ex);
                return false;
            }
        }

        #endregion

        #region KEYWORDS
        public IList<Keyword> GetAllKeywords()
        {
            try
            {
                return _keywordRepository.GetAll();
            }
            catch (Exception ex)
            {
                Console.Write(ex);
            }
            return new List<Keyword>();
        }

        public Keyword AddNewKeyword(Keyword keyword)
        {
            try
            {
                return _keywordRepository.Save(keyword);
            }
            catch (Exception ex)
            {
                Console.Write(ex);
            }
            return new Keyword();
        }

        public Keyword EditKeyword(Keyword keyword)
        {
            try
            {
                return _keywordRepository.Update(keyword);
            }
            catch (Exception ex)
            {
                Console.Write(ex);
            }
            return new Keyword();

        }

        public bool DeleteKeyword(Keyword keyword)
        {
            try
            {
               return _keywordRepository.Delete(keyword);
            }
            catch (Exception ex)
            {
                Console.Write(ex);
                return false;
            }
        }
        #endregion
    }
}
