using Microsoft.EntityFrameworkCore;
using MyPortfolioUdemy1.DAL1.Entities;
using MyPortfolioUdemy1.Views.Entities;

namespace MyPortolioUdemy2.DAL.Context
{
    public class MyPortfolioContext : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=CASPER;initial Catalog=MyPortfolioDb;integrated Security=true;");



        }

        public DbSet<About> Abouts{ get; set; }
        public DbSet<Contact> Contacts{ get; set; }
        public DbSet<Experience> Experiences{ get; set; }
        public DbSet<Feature> Features{ get; set; }
        public DbSet<Message> Messages{ get; set; }
        public DbSet<Portfolio> Portfolios{ get; set; }
        public DbSet<Skill> Skills{ get; set; }
        public DbSet<SocialMedia> SocialMedias{ get; set; }
        public DbSet<Testimonial> Testimonials{ get; set; }



    }
}
