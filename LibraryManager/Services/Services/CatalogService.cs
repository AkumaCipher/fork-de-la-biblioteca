using BusinessLayer.Catalog;
using BusinessObjects.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Services
{
    public class CatalogService : ICatalogService
    {
        private readonly ICatalogManager _catalogManager;

        public CatalogService(ICatalogManager catalogManager)
        {
            _catalogManager = catalogManager;
        }
        public IEnumerable<Book> ShowCatalog()
        {
            return _catalogManager.DisplayCatalog();
        }
        public IEnumerable<Book> ShowCatalog(BusinessObjects.Entity.Type type)
        {
            return _catalogManager.DisplayCatalog(type);

        }
        public Book FindBook(int id)
        {
            return _catalogManager.FindBook(id);
        }

        public IEnumerable<Book> ShowFantasyCatalog()
        {
            return _catalogManager.DisplayFantasyCatalog();
        }

        public Book BestRatedBook()
        {
            return _catalogManager.BestRatedBook();
        }
    }
}
