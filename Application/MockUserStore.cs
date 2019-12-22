using System.Collections.Generic;
using System.Linq;

public class MockUserStore : IUserStore
{
    private List<User> Users { get; set; } = new List<User>();

    public MockUserStore() {
        this.Users.Add(new User() {
            ID = 1,
            Name = "Awesome Coder NR 1"
        });

        this.Users.Add(new User() {
            ID = 2,
            Name = "Scott Hanselman"
        });
    }
    public User CreateUser(User user)
    {
        this.Users.Add(user);
        return user;
    }

    public User DeleteUser(int id)
    {
        var deletedUser = this.Users.Where(x => x.ID == id).FirstOrDefault();
        this.Users.RemoveAll(x => x.ID == id);
        return deletedUser;
    }

    public List<User> GetUsers()
    {
        return this.Users;
    }

    public User UpdateUser(int id,User user)
    {
        var userToUpdate = this.Users.Where(x => x.ID == id).FirstOrDefault();
        userToUpdate = user;
        return user;
    }
}
