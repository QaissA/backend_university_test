using BackendTest.Data;
using BackendTest.Models;

namespace BackendTest.Services
{
    public class UserService : IUser
    {

        private readonly DataContext _datacontext;

        public UserService(DataContext datacontext)
        {
            _datacontext = datacontext;
        }

        public void CreateUser(User user)
        {
            _datacontext.Users.Add(user);
            _datacontext.SaveChanges();
        }

        public IEnumerable<User> GetUsers()
        {
            return _datacontext.Users.ToList();
        }
    }
}
