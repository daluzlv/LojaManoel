using Domain.Models;

namespace Domain.Services;

public interface ITokenService
{
    string GenerateToken(User user);
}
