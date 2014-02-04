using System.Data.Entity;

namespace QuoteTest.Models
{
    public class Author
    {
        public int ID { get; set; }
        public string Alias { get; set; }
        public string Name { get; set; }
    }
    
    public class AuthorDBContext : DbContext
    {
        public DbSet<Author> Authors { get; set; }
    }

    
}