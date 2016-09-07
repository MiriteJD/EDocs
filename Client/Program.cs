using Client.Container;

namespace Client
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using DocManagementReference;
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

        /// <summary>
		/// Liefert eine DataService-Instanz.
		/// </summary>
		/// <returns>Der DataService.</returns>
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

        /// <summary>
        /// adds a new keyword
        /// </summary>
        /// <param name="keyword"></param>
        /// <returns>the new keyword</returns>
        private KeywordContainer AddnewKeyword(KeywordContainer keyword)
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
        private bool DeleteKeyword(KeywordContainer keyword)
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
        private KeywordContainer UpdateKeyword(KeywordContainer keyword)
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

    }
}