using Microsoft.EntityFrameworkCore;
using MyPortfolio.DAL.Entities;

namespace MyPortfolio.DAL.Context
{
    public class MyPrtfolioContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-6CFTTSA\\SQLEXPRESS;initial Catalog=MyPorfolioDb;integrated Security=true;");
        }
        public DbSet<About>Abouts { get; set; }
        public DbSet<Contact>Contacts { get; set; }
        public DbSet<Esperience>Esperiences { get; set; }
        public DbSet<Feture>Fetures { get; set; }
        public DbSet<Message>Messages { get; set; }
        public DbSet<Portfolio>Portfolios { get; set; }
        public DbSet<Skill>Skills { get; set; }
        public DbSet<SocialMedia>SocialMedias { get; set; }
        public DbSet<Testimonial>Testimonials { get; set; }
    }
}
