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
            //Pfad zur Datenbank ermitteln
            var relativePath = @"Database\DocManager.db3";
            string currentPath = Path.GetFullPath(Path.Combine(Directory.GetCurrentDirectory(), @"..\..\"));
            var absolutePath = Path.Combine(currentPath, relativePath);

            _dossierRepository = new DossierRepository(absolutePath);
            _documentRepository = new DocumentRepository(absolutePath);
            _keywordRepository = new KeywordRepository(absolutePath);
        }


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
            }
            return new Dossier();

        }

        public Dossier ImportDossier(Dossier dossier)
        {
            try
            {
                var newdossier = new Dossier()
                {
                    Name = dossier.Name,
                    Comment = dossier.Comment
                };
                var saveddossier = _dossierRepository.Save(newdossier);

                foreach (var document in dossier.Documents)
                {
                    var newdocument = new Document()
                    {
                        Title = document.Title,
                        Comment = document.Comment,
                        CreationDate = document.CreationDate,
                        Path = document.Path,
                        Filename = document.Filename,
                        DossierId = document.DossierId
                    };
                    saveddossier.AddDocument(newdocument);

                    newdocument.Keywords = new List<Keyword>();
                    foreach (var keywordsinList in document.Keywords)
                    {
                        keywordsinList.Documents = new List<Document>();
                        keywordsinList.Documents.Add(newdocument);
                        newdocument.Keywords.Add(keywordsinList);
                        _keywordRepository.Save(keywordsinList);
                    }
                    EditDocument(saveddossier, newdocument);
                }
                return _dossierRepository.Update(saveddossier);
            }
            catch (Exception ex)
            {
                Console.Write(ex);
            }
            return new Dossier();

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
    }
}
