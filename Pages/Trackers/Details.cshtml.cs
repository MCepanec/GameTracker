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
    public class DetailsModel : PageModel
    {
        private readonly AppDbContext _context;

        public DetailsModel(AppDbContext context)
        {
            _context = context;
        }

        public Tracker Tracker { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tracker = await _context.Tracker.FirstOrDefaultAsync(m => m.Id == id);

            if (tracker is not null)
            {
                Tracker = tracker;

                return Page();
            }

            return NotFound();
        }
    }
}
