using Microsoft.EntityFrameworkCore;

namespace AndrewGardanier_Mission_6.Models
{
    public class EnterMovieContext : DbContext
    {
        public EnterMovieContext(DbContextOptions<EnterMovieContext> options) : base(options)
        {

        }

        public DbSet<MovieInfo> MovieInfo { get; set; }
    }
}
