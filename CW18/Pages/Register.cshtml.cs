using CW18.Model;
using CW18.Ripository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CW18.Pages;

public class RegisterModel : PageModel
{
    [BindProperty]
    public RegsiterViewModel RegisterView { get; set; }

    ReporterRepository reporterRipo = new ReporterRepository();

    AdminRepository adminRipository = new AdminRepository();

    public void OnGet() { }

    public IActionResult OnPostAdmin(RegsiterViewModel registerView)
    {
        var admin = new Admin
        {
            FisrtName = registerView.FisrtName,
            LastName = registerView.LastName,
            Password = registerView.Password,
            Email = registerView.Email,
        };
        adminRipository.RegisterAdmin(admin);
        return RedirectToPage("LoginAdmin");
    }


    public IActionResult OnPostReporter(RegsiterViewModel registerView)
    {
        var reporter = new Reporter
        {
            FisrtName = registerView.FisrtName,
            LastName = registerView.LastName,
            Password = registerView.Password,
            Email = registerView.Email,
        };
        reporterRipo.RegisterReporter(reporter);
        return RedirectToPage("LoginReporter");
    }

}
