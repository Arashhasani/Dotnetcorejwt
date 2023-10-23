using JwtPrpject.Models;

namespace JwtPrpject.Services
{
    public interface IJwtService
    {
        public string Generate(User user);
    }
}
