using CW18.Configuration;
using CW18.Model;

namespace CW18.Ripository;

public class AdminRipository
{
    Context context = new Context();

    public void ConfrimArticle(int id)
    {
        var targetArticle = context.Article.FirstOrDefault(a=>a.Id==id);
        targetArticle.IsConfrime = true;

        context.SaveChanges();
    }

    public List<Admin> GetListAdmins()
    {
        var admins = context.Admin.ToList();
        return admins;
    }

    public Admin GetAdmin(int id)
    {
        var admin = context.Admin.FirstOrDefault(x => x.Id == id);
        return admin;
    }

    public void RegisterAdmin(Admin model)
    {
        context.Admin.Add(model);
        context.SaveChanges();
    }

    public void DeleteAdmin(int id)
    {
        var admin = context.Admin.First(x => x.Id == id);
        context.Admin.Remove(admin);
        context.SaveChanges();
    }

    public void UpdateAdmin(Admin model)
    {
        var admin = context.Admin.First(x => x.Id == model.Id);

        admin.FisrtName = model.FisrtName;
        admin.LastName = model.LastName;
        admin.Email= model.Email;
        admin.Password= model.Password;
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
}