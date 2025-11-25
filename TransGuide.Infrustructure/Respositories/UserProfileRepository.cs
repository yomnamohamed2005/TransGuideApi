using TransGuide.Data;
using TransGuide.Data.Entities.Identity;
using TransGuide.Data.Repositories;

namespace TransGuide.Infrastructure.Repositories;

public class UserProfileRepository : GenericRepository<UserProfile>, IUserProfileRepository
{
    public UserProfileRepository(TransGuideDbContext context) : base(context) { }
}