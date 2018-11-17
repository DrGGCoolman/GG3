using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace aspnetAndReact.Models
{
    public class GGContext : DbContext
    {
        // When used with ASP.net core, add these lines to Startup.cs
        //   var connectionString = Configuration.GetConnectionString("BlogContext");
        //   services.AddEntityFrameworkNpgsql().AddDbContext<BlogContext>(options => options.UseNpgsql(connectionString));
        // and add this to appSettings.json
        // "ConnectionStrings": { "BlogContext": "Server=localhost;Database=blog" }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("User ID=postgres;Password=Po102118910;Host=localhost;Port=5432;Database=GG");
        }

        public DbSet<GoalDTO> Blogs { get; set; }
        public DbSet<PostDTO> Posts { get; set; }
        public DbSet<UserDTO> Posts { get; set; }

    }
}