using System.Data.Entity;

namespace QuoteTest.Models
{
    public class Aauthor
    {
        public int ID { get; set; }
        public string Alias { get; set; }
        public string Name { get; set; }
    
        public class AauthorDBContext : DbContext
        {
            public DbSet<Aauthor> Aauthors { get; set; }
        }

    }
}