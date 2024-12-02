using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using ForumMotor_13BC_A.Data;
using ForumMotor_13BC_A.Models;
using Microsoft.AspNetCore.Identity;

namespace ForumMotor_13BC_A.Pages
{
    public class CreateModel : PageModel
    {
        private readonly ForumMotor_13BC_A.Data.ApplicationDbContext _context;
        private readonly UserManager<User> _userManager;

        public CreateModel(ForumMotor_13BC_A.Data.ApplicationDbContext context, UserManager<User> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        public IActionResult OnGet()
        {
        ViewData["UserId"] = new SelectList(_context.Users, "Id", "Id");
            return Page();
        }

        [BindProperty]
        public Category Category { get; set; } = default!;

        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            /*if (!ModelState.IsValid)
            {
                return Page();
            }*/
            Category.CreateDate = DateTime.Now;
            Category.UserId = _userManager.GetUserId(User);

            _context.Categories.Add(Category);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
