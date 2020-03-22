using BasicArch.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace BasicArch.Infra.Data.Context
{
    public class BasicArchDbContext : DbContext
    {
        public BasicArchDbContext(DbContextOptions options) : base(options)
        { }

        public DbSet<Profile> Profiles { get; set; }
    }
}