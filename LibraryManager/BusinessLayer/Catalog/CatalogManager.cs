using DataAccessLayer.Repository;
using BusinessObjects.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

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
            IEnumerable<Book> fantasyBooks =
                from book
                in _bookRepository.GetAll()
                where book.type.Equals(type)
                select book;

            return _bookRepository.GetAll();
        }
        public Book FindBook(int id)
        {
            return new Book();
        }

        public IEnumerable<Book> DisplayFantasyCatalog()
        {
            return DisplayCatalog(BusinessObjects.Entity.Type.Fantasy);
        }

        public Book BestRatedBook()
        {
            int max = _bookRepository.GetAll().Max(book => book.rate);

            return _bookRepository.GetAll().Where(book => book.rate == max).FirstOrDefault();
        }
    }
}
