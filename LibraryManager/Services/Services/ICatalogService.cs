using BusinessObjects.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Services
{
    public interface ICatalogService
    {
        public IEnumerable<Book> ShowCatalog();
        public IEnumerable<Book> ShowCatalog(BusinessObjects.Entity.Type type);
        public Book FindBook(int id);
        public IEnumerable<Book> ShowFantasyCatalog();
        public Book BestRatedBook();
    }
}
