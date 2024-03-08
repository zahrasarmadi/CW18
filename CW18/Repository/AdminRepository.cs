using CW18.Configuration;
using CW18.Model;

namespace CW18.Ripository;

public class AdminRepository
{
    Context context = new Context();
    public void ConfrimComment(int id)
    {
        var targetComment = context.Comment.FirstOrDefault(a => a.Id == id);
        targetComment.IsConfrim = true;

        context.SaveChanges();
    }

    public void ConfrimArticle(int id)
    {
        var targetArticle = context.Article.FirstOrDefault(a=>a.Id==id);
        targetArticle.IsConfrim = true;

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
}