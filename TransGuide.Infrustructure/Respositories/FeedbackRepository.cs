using Microsoft.EntityFrameworkCore;
using TransGuide.Data.Entities.ApplicationEntities;
using TransGuide.Data.Entities.ApplicationEtities;
using TransGuide.Data.Repositories;

namespace TransGuide.Infrastructure.Repositories;

public class FeedbackRepository : Repository<Feedback>, IFeedbackRepository
{
    public FeedbackRepository(DbContext context) : base(context) { }
}