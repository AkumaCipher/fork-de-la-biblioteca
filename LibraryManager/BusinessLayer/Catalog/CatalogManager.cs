using DataAccessLayer.Repository;
using BusinessObjects.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Catalog
{
    public class CatalogManager
    {
        private readonly BookRepository _bookRepository;

        public CatalogManager()
        {
            _bookRepository = new BookRepository();
        }
        public IEnumerable<Book> DisplayCatalog()
        {
            return _bookRepository.GetAll();
        }
        public IEnumerable<Book> DisplayCatalog(BusinessObjects.Entity.Type type)
        {
            return _bookRepository.GetAll();

        }
        public Book FindBook(int id)
        {
            return new Book();
        }
    }
}
