using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ForumMotor_13BC_A.Data;
using ForumMotor_13BC_A.Models;

namespace ForumMotor_13BC_A.Pages
{
    public class TopikListaModel : PageModel
    {
        private readonly ForumMotor_13BC_A.Data.ApplicationDbContext _context;

        public TopikListaModel(ForumMotor_13BC_A.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty(SupportsGet = true)]
        public int CategoryId { get; set; }


        public IList<Topic> Topic { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Topic = await _context.Topics
                .Where(x => x.CategoryId == CategoryId)
                .Include(t => t.Category)
                .Include(t => t.User).ToListAsync();
        }
    }
}
