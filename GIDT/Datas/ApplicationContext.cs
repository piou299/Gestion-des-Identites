using GIDT.Models;
using Microsoft.EntityFrameworkCore;

namespace GIDT.Datas
{
    public class ApplicationContext: DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options) { }

        public DbSet<Adresse> Adresses { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<Utilisateur> Utilisateurs { get; set; }
    }
}
