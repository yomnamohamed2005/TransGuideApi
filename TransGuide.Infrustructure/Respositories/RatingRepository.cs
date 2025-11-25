using TransGuide.Data.Entities.ApplicationEntities;
using TransGuide.Data.Entities.ApplicationEtities;
using TransGuide.Data.Repositories;

namespace TransGuide.Infrastructure.Repositories;

public class RatingRepository : Repository<Rating>, IRatingRepository
{
    public RatingRepository(DbContext context) : base(context) { }
}