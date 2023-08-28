using Microsoft.EntityFrameworkCore;
using DomainModels;

namespace eSportPortalAPI.DB
{
	public class eSportPortalDbContext : DbContext
    {
		public eSportPortalDbContext(DbContextOptions options) : base(options) { 
		}

		public DbSet<User> Users { get; set; }
	}
}
