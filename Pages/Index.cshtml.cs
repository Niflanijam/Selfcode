using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Moviemanager.Data;
using Moviemanager.Models;

namespace Moviemanager.Pages
{
    public class IndexModel : PageModel
    {
        private readonly Moviemanager.Data.MoviemanagerContext _context;

        public IndexModel(Moviemanager.Data.MoviemanagerContext context)
        {
            _context = context;
        }

        public IList<Movie> Movie { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Movie = await _context.Movie.ToListAsync();
        }
    }
}
