using System.Collections.Generic;

namespace LegacyApp;

public class UserRepository : IUserRepository
{
    private readonly List<User> users;

    public UserRepository()
    {
        users = new List<User>();
    }

    public void AddUser(User user)
    {
        users.Add(user);
    }
}