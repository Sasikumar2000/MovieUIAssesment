using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace MovieWebsite.Model
{
    public class MovieDbContext:DbContext
    {
        public MovieDbContext()
        {

        }
        public MovieDbContext(DbContextOptions<MovieDbContext> options) : base(options)
        {

        }
        
        public DbSet<MovieProperty> movieProperty { get; set; }
        public DbSet<UserInfo> userInfo {get; set;}
    }
}
