using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Reflection.Emit;
using TransGuide.Data.Entities.ApplicationEntities;
using TransGuide.Data.Entities.ApplicationEtities;
using TransGuide.Data.Entities.Identity;

namespace TransGuide.Data.TransGuidedbcontext; 

public class Datadbcontext : DbContext 
{
    public Datadbcontext(DbContextOptions<Datadbcontext> options)
        : base(options)
    {
    }

    // Application Entities
    public DbSet<Feedback> Feedbacks { get; set; }
    public DbSet<Rating> Ratings { get; set; }
    public DbSet<Route> Routes { get; set; }
    public DbSet<RouteStatus> RouteStatuses { get; set; }
    public DbSet<Station> Stations { get; set; }
    public DbSet<TripStatus> TripStatuses { get; set; }

    // Identity Entity
    public DbSet<UserProfile> UserProfiles { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
    }
}