using TransGuide.Data.Entities.Identity;
using TransGuide.Data.Repositories;

namespace TransGuide.Infrastructure.Repositories;

public class UserProfileRepository : Repository<UserProfile>, IUserProfileRepository
{
    public UserProfileRepository(DbContext context) : base(context) { }
}