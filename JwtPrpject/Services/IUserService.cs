using JwtPrpject.Models;
using Microsoft.AspNetCore.Mvc;

namespace JwtPrpject.Services
{
    public interface IUserService
    {

        public List<User> GetUsers();
        public User getUserByUsernameAndPass(string email,string password);
        public User getCurrentUserInfo(Guid id);
    }
}
