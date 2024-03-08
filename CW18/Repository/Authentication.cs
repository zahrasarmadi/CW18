using CW18.Configuration;
using CW18.Model;

namespace CW18.Ripository;

public class Authentication
{
    Context context=new Context();
    public void RegisterAdmin(Admin model)
    {
        context.Admin.Add(model);
        context.SaveChanges();
    }

    public Admin Login(LoginViewModel loginViewModel)
    {
        var targetReporter = context.Admin.FirstOrDefault(r => r.Email == loginViewModel.Email && r.Password == loginViewModel.Password);
        if (targetReporter != null)
        {
            return targetReporter;
        }
        return null;
    }


    public Reporter Login(LoginViewModel login)
    {
        var targetReporter = context.Reporter.FirstOrDefault(r => r.Email == login.Email && r.Password == login.Password);
        if (targetReporter != null)
        {
            return targetReporter;
        }
        return null;
    }

    public void RegisterReporter(Reporter model)
    {
        context.Reporter.Add(model);
        context.SaveChanges();
    }

}
