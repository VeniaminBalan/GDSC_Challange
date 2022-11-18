namespace GDSC_Challange.Challange;

public class WebApplication : IApplication
{
    private string name;
    private List<User> Users;

    public WebApplication(string name)
    {
        this.name = name;
        Users = new List<User>();
    }

    public string GetName()
    {
        return name;
    }

    public int GetNumberOfUsers()
    {
        return Users.Count();
    }

    public void AddUser(User user)
    {
        foreach (var _user in Users)
        {
            if (_user.Email == user.Email)
            {
                Console.WriteLine($"Email: {user.Email} is already used");
                return;
            }
            if (_user.Username == user.Username)
            {
                Console.WriteLine($"Name: {user.Username} is already used");
                return;
            }
        }

        Users.Add(user);
    }

    public void RemoveUser(User user)
    {
        if (Users.Contains(user))
        {
            Users.Remove(user);
        }
    }

    public void HttpRequest(User user)
    {
        if (Users.Contains(user))
        {
            Console.WriteLine("Ok Request");
        }
        else
        {
            Console.WriteLine("Bad Request");
        }
    }
}