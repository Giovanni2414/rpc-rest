using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using rpc_users_page.Models;

namespace rpc_users_page.Data
{
    public class rpc_users_pageContext : DbContext
    {
        public rpc_users_pageContext (DbContextOptions<rpc_users_pageContext> options)
            : base(options)
        {
        }

        public DbSet<rpc_users_page.Models.User> User { get; set; }
    }
}
