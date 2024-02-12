using BusinessObjects.Entity;
using DataAccessLayer.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repository
{
    public class AuthorRepository : IRepository<Author>
    {
        private readonly LibraryContext _libraryContext;

        public AuthorRepository(LibraryContext libraryContext)
        {
            _libraryContext = libraryContext;
        }
        public IEnumerable<Author> GetAll()
        {
            return _libraryContext.Authors.ToList();
        }

        public Author Get(int id)
        {
            return _libraryContext.Authors.Single(author => author.id == id);
        }
    }
}
