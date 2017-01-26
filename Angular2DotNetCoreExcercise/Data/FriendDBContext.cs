using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Angular2DotNetCoreExcercise.Data
{
    public class FriendDBContext : DbContext
    {
        public FriendDBContext(DbContextOptions<FriendDBContext> options) : base(options)
        {

        }

        public FriendDBContext() { }

        public DbSet<Friend> Friends { get; set; }
    }
}
