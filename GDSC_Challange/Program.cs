
using GDSC_Challange.Challange;

Builder builder = new Builder();
Admin admin = builder.BuildAdmin();

WebApplication webApplication = new WebApplication("Web");
MobileApplication mobileApplication = new MobileApplication("Mobile");

admin.AddApplications(webApplication);
admin.AddApplications(mobileApplication);

User us1 = new User("Veniamin", "1234", "qwerty@gmail.com");
User us2 = new User("Veniamin", "1234", "qwer@gmail.com");
User us3 = new User("Venia", "1234", "qw@gmail.com");
/*
admin.AddUser(us1, mobileApplication);
admin.AddUser(us2, mobileApplication);
admin.AddUser(us3, mobileApplication);

mobileApplication.SetRating();
Console.WriteLine($"Rating of {mobileApplication.name} application is {mobileApplication.rating}");
*/

admin.AddUser(us1, webApplication);
admin.AddUser(us2, webApplication);
admin.AddUser(us3, webApplication);

webApplication.HttpRequest(us1);
admin.RemoveUser(us1, webApplication);
webApplication.HttpRequest(us1);