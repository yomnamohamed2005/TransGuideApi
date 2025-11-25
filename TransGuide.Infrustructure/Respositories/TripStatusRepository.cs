using TransGuide.Data;
using TransGuide.Data.Entities.ApplicationEntities;
using TransGuide.Data.Repositories;

namespace TransGuide.Infrastructure.Repositories;

public class TripStatusRepository : GenericRepository<TripStatus>, ITripStatusRepository
{
    public TripStatusRepository(TransGuideDbContext context) : base(context) { }
}
