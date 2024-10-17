using Domain.Models;

namespace Domain.Repositories.Users;

public class UserRepository : IUserRepository
{
    public User Get(string username, string password)
    {
        List<User> users = new()
        { 
            new() { Id = 1, Username = "Admin", Password = "Admin", Role = "Admin" }
        };

        return users.FirstOrDefault(u => u.Username.Equals(username, StringComparison.CurrentCultureIgnoreCase) && u.Password == password);
    }
}
