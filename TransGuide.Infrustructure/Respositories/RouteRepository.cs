using TransGuide.Data.Entities.ApplicationEntities;
using TransGuide.Data.Entities.ApplicationEtities;
using TransGuide.Data.Repositories;

namespace TransGuide.Infrastructure.Repositories;

public class RouteRepository : Repository<Route>, IRouteRepository
{
    public RouteRepository(DbContext context) : base(context) { }
}