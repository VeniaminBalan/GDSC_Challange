namespace GDSC_Challange.Challange;

public class Builder
{
    public Admin BuildAdmin()
    {
        string nume;
        Console.WriteLine("Introduceti numele administratorului: ");
        nume = Console.ReadLine();

        Admin ad = new Admin(nume);
        return ad;
    }

    public User BuildUser()
    {
        string nume;
        string password;
        string email;
        
        Console.WriteLine("Username: ");
        nume = Console.ReadLine();
        
        Console.WriteLine("Password: ");
        password = Console.ReadLine();
        
        Console.WriteLine("Email");
        email = Console.ReadLine();

        return new User(nume, password, email);
    }
}