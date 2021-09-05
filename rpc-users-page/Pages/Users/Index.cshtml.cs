using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
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
            UsernameLogged = string.Empty;
        }

        public IList<User> User { get;set; }
        [BindProperty(SupportsGet = true)]
        public string Username { get; set; }
        [BindProperty(SupportsGet = true)]
        public string Password { get; set; }
        public string UsernameLogged { get; set; }
        public async Task OnGetAsync()
        {
            Console.WriteLine(UsernameLogged);
            if (!string.IsNullOrEmpty(Username) & !string.IsNullOrEmpty(Password))
            {
                var userLogged = _context.User.FirstOrDefault(u => u.Username == Username && u.Password == Password);
                if (userLogged is null)
                {
                    UsernameLogged = string.Empty;
                }
                else
                {
                    UsernameLogged = userLogged.Username;
                }
            }
            else
            {
                UsernameLogged = "";
            }
            User = await _context.User.ToListAsync();
        }
    }
}
