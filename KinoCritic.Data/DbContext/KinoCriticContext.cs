using Microsoft.EntityFrameworkCore;
using KinoCritic.Data;
using KinoCritic.Data.Entities;

namespace KinoCritic.Data
{
    public class KinoCriticContext : DbContext
    {
        public KinoCriticContext(DbContextOptions<KinoCriticContext> options) : base(options) { }

        public DbSet<Movie> Movies { get; set; }
        public DbSet<Show> Shows { get; set; }
        public DbSet<Rating> Ratings { get; set; }
    }
};
