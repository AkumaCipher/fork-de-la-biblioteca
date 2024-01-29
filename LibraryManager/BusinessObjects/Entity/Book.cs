using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObjects.Entity
{
    public class Book
    {
        public int? id { get; set; }
        public string? name { get; set; }
        public int? pages { get; set; }
        public Type? type { get; set; }
        public int rate { get; set; }

        public Author? author {  get; set; }
        public IEnumerable<Library>? libraries { get; set; }
    }
        public enum Type
        {
            Aventure,
            Fantasy,
            Enseignement,
            Histoire,
            Juridique
        }
}
