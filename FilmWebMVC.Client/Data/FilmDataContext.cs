using Microsoft.EntityFrameworkCore;
using FilmWebMVC.Client.Models;

namespace FilmWebMVC.Client.Data {
    public class FilmDataContext : DbContext {
        public DbSet<Film> Films { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\mssqllocaldb;Initial Catalog=shop;Integrated Security=True");
            base.OnConfiguring(optionsBuilder);
        }

    }
}
