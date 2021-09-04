using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using rpc_users_page.Data;
using rpc_users_page.Models;

namespace rpc_users_page.Pages.Users
{
    public class DetailsModel : PageModel
    {
        private readonly rpc_users_page.Data.rpc_users_pageContext _context;

        public DetailsModel(rpc_users_page.Data.rpc_users_pageContext context)
        {
            _context = context;
        }

        public User User { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            User = await _context.User.FirstOrDefaultAsync(m => m.ID == id);

            if (User == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
