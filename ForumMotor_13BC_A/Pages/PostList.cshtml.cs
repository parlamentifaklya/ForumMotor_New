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
    public class PostListModel : PageModel
    {
        private readonly ForumMotor_13BC_A.Data.ApplicationDbContext _context;

        public PostListModel(ForumMotor_13BC_A.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty(SupportsGet = true)]
        public int TopicId { get; set; }

        public IList<Post> Post { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Post = await _context.Posts
                .Where(x => x.TopicId == TopicId)
                .Include(p => p.Topic)
                .Include(p => p.User).ToListAsync();
        }
    }
}
