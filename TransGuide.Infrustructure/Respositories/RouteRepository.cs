using TransGuide.Data;
using TransGuide.Data.Entities.ApplicationEntities;
using TransGuide.Data.Repositories;

namespace TransGuide.Infrastructure.Repositories;

public class RouteRepository : GenericRepository<Route>, IRouteRepository
{
    public RouteRepository(TransGuideDbContext context) : base(context) { }
}