using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using GameTracker.Models;

namespace GameTracker.Pages_Trackers
{
    public class IndexModel : PageModel
    {
        private readonly AppDbContext _context;

        public IndexModel(AppDbContext context)
        {
            _context = context;
        }

        public IList<Tracker> Tracker { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Tracker = await _context.Tracker.ToListAsync();
        }
    }
}
