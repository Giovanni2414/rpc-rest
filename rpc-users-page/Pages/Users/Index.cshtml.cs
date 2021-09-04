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
    public class IndexModel : PageModel
    {
        private readonly rpc_users_page.Data.rpc_users_pageContext _context;

        public IndexModel(rpc_users_page.Data.rpc_users_pageContext context)
        {
            _context = context;
        }

        public IList<User> User { get;set; }

        public async Task OnGetAsync()
        {
            User = await _context.User.ToListAsync();
        }
    }
}
