using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObjects.Entity
{
    public class Library
    {
        public int? id { get; set; }
        public string? name { get; set; }
        public string? adress { get; set; }
        public IEnumerable<Book>? books { get; set; }
    }
}
