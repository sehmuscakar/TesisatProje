using DataAccessLayer.Entities;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.Concrete.Context
{
    public class ProjeContext:DbContext
    {
        public DbSet<Topbar> Topbars { get; set; }   
        public DbSet<About> Abouts { get; set; } 
        public DbSet<Team> Teams { get; set; } 
        public DbSet<Carousel> Carousels { get; set; } 
        public DbSet<Fact> Facts { get; set; } 
        public DbSet<Service> Services { get; set; }

        public DbSet<Booking> Bookings { get; set; }
        public DbSet<Testimonial> Testimonials { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Contact> Contacts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlServer("Server=DESKTOP-PBFD0LU;  database=TesisatProje; integrated security=true; TrustServerCertificate=true");
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder) //fluent api ile ilgili
        {
            modelBuilder.Entity<About>(entity =>//herzamn çoklu üzerinden ilerle
            {
                //entity.Property(x => x.ServiceTitle1).HasMaxLength(200);
                //entity.Property(x => x.ServiceTitle1).IsRequired();
                entity.HasOne(x => x.User).WithMany(x => x.Abouts).HasForeignKey(x => x.CreatedBy);
            });

            modelBuilder.Entity<Booking>(entity =>
            {
             
                entity.HasOne(x => x.User).WithMany(x => x.Bookings).HasForeignKey(x => x.CreatedBy);
            });

            modelBuilder.Entity<Carousel>(entity =>
            {

                entity.HasOne(x => x.User).WithMany(x => x.Carousels).HasForeignKey(x => x.CreatedBy);
            });

            modelBuilder.Entity<Fact>(entity =>
            {

                entity.HasOne(x => x.User).WithMany(x => x.Facts).HasForeignKey(x => x.CreatedBy);
            });


            modelBuilder.Entity<Service>(entity =>
            {

                entity.HasOne(x => x.User).WithMany(x => x.services).HasForeignKey(x => x.CreatedBy);
            });

            modelBuilder.Entity<Team>(entity =>
            {

                entity.HasOne(x => x.User).WithMany(x => x.Teams).HasForeignKey(x => x.CreatedBy);
            });

            modelBuilder.Entity<Testimonial>(entity =>
            {

                entity.HasOne(x => x.User).WithMany(x => x.Testimonials).HasForeignKey(x => x.CreatedBy);
            });

            modelBuilder.Entity<Topbar>(entity =>
            {

                entity.HasOne(x => x.User).WithMany(x => x.Topbars).HasForeignKey(x => x.CreatedBy);
            });

            modelBuilder.Entity<Contact>(entity =>
            {

                entity.HasOne(x => x.User).WithMany(x => x.Contacts).HasForeignKey(x => x.CreatedBy);
            });

            base.OnModelCreating(modelBuilder);
        }


    }
}
