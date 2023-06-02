using Microsoft.EntityFrameworkCore;
using NoteApp.Models.Entities;

namespace NoteApp.Models.Context
{
    public class DatabaseContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Note> Notes { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<LikedNote> LikedNotes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (optionsBuilder.IsConfigured == false)
            {
                optionsBuilder.UseSqlServer("Server = localhost;Database=NotesDB;Username=INNOVA/utuncer;Trusted_Connection=true");
                optionsBuilder.UseLazyLoadingProxies();
            }
        }
    }
}
