using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using websitePersonalInformation.Models;

namespace websitePersonalInformation.Pages_Favourite
{
    public class IndexModel : PageModel
    {
        private readonly RazorPagesMovieContext _context;

        public IndexModel(RazorPagesMovieContext context)
        {
            _context = context;
        }
        public IList<Favorite> Favorite { get;set; }
        public async Task OnGetAsync()
        {
            Favorite = await _context.Favorite.ToListAsync();
        }
    }
}
