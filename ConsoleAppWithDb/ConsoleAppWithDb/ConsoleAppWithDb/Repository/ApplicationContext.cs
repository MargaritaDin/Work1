using System.Data.Entity;
using ConsoleAppWithDb.DAO;

namespace ConsoleAppWithDb.Repository
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext() : base("ApplicationContext")
        {
        }

        public DbSet<Postashalnik> Postashalniks { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Postashalnik>()
                .ToTable("Pracivnuku");

            modelBuilder.Entity<Postashalnik>()
                .HasKey(x => x.Id);

            modelBuilder.Entity<Postashalnik>()
                .Property(u => u.Id)
                .HasColumnName("ID_Pracik");

            modelBuilder.Entity<Postashalnik>()
                .Property(u => u.FirstName)
                .HasColumnName("Name");

            modelBuilder.Entity<Postashalnik>()
                .Property(u => u.LastName)
                .HasColumnName("Last_Name");
        }

    }
}