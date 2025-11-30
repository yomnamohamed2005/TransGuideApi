using Microsoft.EntityFrameworkCore;
using TransGuide.Data;
using TransGuide.Data.Entities.ApplicationEntities;
using TransGuide.Data.Repositories;

namespace TransGuide.Infrastructure.Repositories;

public class RatingRepository : GenericRepository<Rating>, IRatingRepository
{
    protected readonly TransGuideDbContext _context;

    public RatingRepository(TransGuideDbContext context) : base(context)
    {
        _context = context;
    }

    public async Task<IEnumerable<Rating>> GetRatingsByTripIdAsync(int tripId)
    {
        return await _context.Ratings
            .Where(r => r.TripId == tripId)
            .ToListAsync();
    }

    public async Task<double> GetAverageRatingForTripAsync(int tripId)
    {
        return await _context.Ratings
       .Where(r => r.TripId == tripId)
       .Select(r => (double)r.Score)
       .DefaultIfEmpty(0)
       .AverageAsync();

    }
}