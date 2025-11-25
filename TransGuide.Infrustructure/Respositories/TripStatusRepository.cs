using TransGuide.Data.Entities.ApplicationEntities;
using TransGuide.Data.Entities.ApplicationEtities;
using TransGuide.Data.Repositories;

namespace TransGuide.Infrastructure.Repositories;

public class TripStatusRepository : Repository<TripStatus>, ITripStatusRepository
{
    public TripStatusRepository(DbContext context) : base(context) { }
}
