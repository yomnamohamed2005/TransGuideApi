using TransGuide.Data.Entities.ApplicationEntities;
using TransGuide.Data.Entities.ApplicationEtities;
using TransGuide.Data.Repositories;

namespace TransGuide.Infrastructure.Repositories;

public class StationRepository : Repository<Station>, IStationRepository
{
    public StationRepository(DbContext context) : base(context) { }
}
