using BusinessObjects.Entity;
using DataAccessLayer.Contexts;
using Microsoft.EntityFrameworkCore.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repository
{
    public class BookRepository : IRepository<Book>
    {
        private readonly LibraryContext _libraryContext;

        public BookRepository(LibraryContext libraryContext)
        {
            _libraryContext = libraryContext;
        }
        public IEnumerable<Book> GetAll()
        {
            return _libraryContext.Books.ToList();
        }

        public Book Get(int id)
        {
            return _libraryContext.Books.Single(book => book.id == id);
        }
    }
}
