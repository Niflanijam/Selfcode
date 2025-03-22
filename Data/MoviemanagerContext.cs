using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Moviemanager.Models;

namespace Moviemanager.Data
{
    public class MoviemanagerContext : DbContext
    {
        public MoviemanagerContext (DbContextOptions<MoviemanagerContext> options)
            : base(options)
        {
        }

        public DbSet<Moviemanager.Models.Movie> Movie { get; set; } = default!;
    }
}
