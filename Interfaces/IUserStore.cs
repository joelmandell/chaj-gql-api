using System.Collections.Generic;

public interface IUserStore {
    public List<User> GetUsers();
    public User UpdateUser(int id,User user);
    public User DeleteUser(int id);
    public User CreateUser(User user);
}