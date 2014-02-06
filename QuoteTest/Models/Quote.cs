using System;
using System.Data.Entity;

namespace QuoteTest.Models
{
    public class Quote
    {
        public int ID { get; set; }
        public string Quotation { get; set; }
        public string Author { get; set; }
        public string Alias { get; set; }
        //public int AuthorID { get; set; }
        public string Context { get; set; }        
        //public decimal Price { get; set; }
    }

    public class QuoteDBContext : DbContext
    {
        public DbSet<Quote> Quotations { get; set; }
    }
}