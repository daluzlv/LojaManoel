using Domain.Models;

namespace Domain.Repositories.Users;

public interface IUserRepository
{
    User Get(string username, string password);
}
