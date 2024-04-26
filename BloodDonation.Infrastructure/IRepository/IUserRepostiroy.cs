using BloodDonation.Data.Entities;

namespace BloodDonation.Infrastructure.IRepository
{
    public interface IUserRepostiroy
    {
        public User Register(User user);
        public bool Login(string username, string password);
        public User GetUserById(string id);
    }
}
