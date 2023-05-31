using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace UserDocuments.API.models
{
    public class MyDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Document> Documents { get; set; }
        public DbSet<DocumentStatus> DocumentStatuses { get; set; }
        public DbSet<EditHistory> EditHistories { get; set; }

        

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("I don't know how can i take a connection string from the appsettings.json SORRY");

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)//Добовляем ключи и связи
        {
            modelBuilder.Entity<DocumentStatus>()
                .HasKey(ds => ds.Id);

            modelBuilder.Entity<Document>()
                .HasKey(d => d.Id);
            modelBuilder.Entity<User>()
                .HasKey(u => u.Id);
            modelBuilder.Entity<EditHistory>()
            .HasKey(eh => eh.Id);

            modelBuilder.Entity<DocumentStatus>()
                .HasOne(ds => ds.Document)
                .WithOne()
                .HasForeignKey<Document>(d => d.Id);

            modelBuilder.Entity<DocumentStatus>()
                .HasOne(ds => ds.User)
                .WithOne()
                .HasForeignKey<User>(d => d.Id);

            modelBuilder.Entity<EditHistory>()
                .HasOne(eh => eh.User)
                .WithOne()
                .HasForeignKey<User>(u => u.Id);

            modelBuilder.Entity<EditHistory>()
                .HasOne(eh => eh.Document)
                .WithOne()
                .HasForeignKey<Document>(d => d.Id);

            modelBuilder.Entity<Document>()
            .HasOne(d => d.User)
            .WithMany(u => u.Documents) // Укажите имя навигационного свойства, если оно есть, например, .WithMany(u => u.Documents)
            .HasForeignKey(u => u.Id);

        }
    }
}