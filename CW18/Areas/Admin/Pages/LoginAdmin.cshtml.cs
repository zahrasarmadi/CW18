using CW18.Database;
using CW18.Model;
using CW18.Ripository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CW18.Areas.AdminArea.Pages;

public class LoginAdminModel : PageModel
{
    [BindProperty]
    public Admin Admin { get; set; }
    [BindProperty]
    public LoginViewModel Login { get; set; }
    AdminRepository adminRipository=new AdminRepository();
    public void OnGet()
    {
    }
    public IActionResult OnPost(LoginViewModel login)
    {
        var OnlineAdmin = adminRipository.Login(login);
        StaticDatabase.Admin = OnlineAdmin;
        return RedirectToPage("CategoriesManagement");
    }
}
