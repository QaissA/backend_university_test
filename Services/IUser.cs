using BackendTest.Models;

namespace BackendTest.Services
{
    public interface IUser
    {
        IEnumerable<User> GetUsers();

        void CreateUser(User user);
    }
}
