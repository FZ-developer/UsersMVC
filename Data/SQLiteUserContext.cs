using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MVC_User.Models;

namespace MVC_User.Data
{
    public class SQLiteUserContext : DbContext
    {
        public SQLiteUserContext (DbContextOptions<SQLiteUserContext> options)
            : base(options)
        {
        }

        public DbSet<MVC_User.Models.User> User { get; set; } = default!;
    }
}
