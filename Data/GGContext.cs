using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using aspnetAndReact.Data;

namespace aspnetAndReact.Data
{
    public class GGContext : DbContext
    {
        // When used with ASP.net core, add these lines to Startup.cs
        //   var connectionString = Configuration.GetConnectionString("BlogContext");
        //   services.AddEntityFrameworkNpgsql().AddDbContext<BlogContext>(options => options.UseNpgsql(connectionString));
        // and add this to appSettings.json
        // "ConnectionStrings": { "BlogContext": "Server=localhost;Database=blog" }


        public GGContext(DbContextOptions<GGContext> options) : base(options) { }


        public DbSet<GoalDTO> Goals { get; set; }
        public DbSet<PostDTO> Posts { get; set; }
        public DbSet<UserDTO> Users { get; set; }

    }
}
