using System;

namespace downr.Models
{
    public class Post
    {
        public string Slug { get; set; }
        public string Title { get; set; }
        public DateTime PublicationDate { get; set; }
        public DateTime LastModified { get; set; }
        public string Author { get; set; }
        public string[] Categories { get; set; }
        public string Content { get; set; }
    }
}