using JwtPrpject.Entity;
using JwtPrpject.Models;
using Microsoft.AspNetCore.Mvc;

namespace JwtPrpject.Services
{
    public class UserService : IUserService
    {

        private ApplicationDbContext _context;

        public UserService(ApplicationDbContext context)
        {
            _context = context;
        }

        public User getUserByUsernameAndPass(string email, string password)
        {
            var user=_context.Users.Where(e=>e.Email==email).Where(e=>e.Password==password).FirstOrDefault();
            return user;

        }

        public List<User> GetUsers()
        {
            return _context.Users.ToList();
            throw new NotImplementedException();
        }

        public User getCurrentUserInfo(Guid id)
        {
            return _context.Users.Where(u => u.Id == id).FirstOrDefault();
        }

      
    }
}
