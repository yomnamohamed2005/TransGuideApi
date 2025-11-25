using System.Reflection;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using TransGuide.Data.Entities.ApplicationEtities;
using TransGuide.Data.Entities.Identity;

namespace TransGuide.Data
{
	public class TransGuideDbContext : IdentityDbContext<
		UserProfile,                      // UserProfile بدل User
		IdentityRole<int>,
		int,
		IdentityUserClaim<int>,
		IdentityUserRole<int>,
		IdentityUserLogin<int>,
		IdentityRoleClaim<int>,
		IdentityUserToken<int>>
	{
		

		public TransGuideDbContext(DbContextOptions<TransGuideDbContext> options)
			: base(options)
		{
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);


			modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
		}

		// DbSets
		public DbSet<Route> Routes { get; set; }
		public DbSet<Station> Stations { get; set; }
		public DbSet<UserProfile> UserProfiles { get; set; }
		public DbSet<RouteStatus> RouteStatuses { get; set; }
		public DbSet<Feedback> Feedbacks { get; set; }
		public DbSet<Rating> Ratings { get; set; }
		public DbSet<TripStatus> TripStatuses { get; set; }
	}
}
