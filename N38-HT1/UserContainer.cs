using System.Collections;

namespace N38_HT1;

public class UserContainer : IEnumerable<User>
{
    private List<User> users;
    public UserContainer()
    {
        users = new List<User>();
    }

    public UserContainer(IEnumerable<User> userCollection)
    {
        users = userCollection.ToList();
    }

    public User this[Guid id] => users.FirstOrDefault(user => user.Id == id);

    public User this[string keyword] =>
        users.FirstOrDefault(user => user.FirstName.Contains(keyword) || user.LastName.Contains(keyword));

    public User this[int index] => users[index];

    public void AddUser(User user)
    {
        users.Add(user);
    }

    public IEnumerator<User> GetEnumerator()
    {
        return users.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }


}
