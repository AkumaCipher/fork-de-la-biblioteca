﻿namespace BusinessObjects.Entity
{
    public class Author
    {
        public int? id { get; set; }
        public string? firstName { get; set; }
        public string? lastName { get; set; }
        public IEnumerable<Book>? books { get; set; }
    }
}