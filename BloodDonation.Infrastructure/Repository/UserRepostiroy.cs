using BloodDonation.Data.Entities;
using BloodDonation.Infrastructure.IRepository;

namespace BloodDonation.Infrastructure.Repository
{
    public class UserRepostiroy : IUserRepostiroy
    {
        public User GetUserById(string id)
        {
            throw new NotImplementedException();
        }

        public bool Login(string username, string password)
        {
            throw new NotImplementedException();
        }

        public User Register(User user)
        {
            throw new NotImplementedException();
        }
    }
}
