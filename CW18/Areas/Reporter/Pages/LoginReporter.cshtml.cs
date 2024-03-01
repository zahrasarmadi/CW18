using CW18.Database;
using CW18.Model;
using CW18.Ripository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;


namespace CW18.Areas.ReporterArea.Pages;

public class LoginReporterModel : PageModel
{
    [BindProperty]
    public Reporter Reporter { get; set; }
    [BindProperty]
    public LoginViewModel Login { get; set; }
    ReporterRepository reporterRipo=new ReporterRepository();
    public void OnGet()
    {
    }
    public IActionResult OnPost(LoginViewModel Login)
    {
        var OnlineReporter = reporterRipo.Login(Login);
        StaticDatabase.Reporter = OnlineReporter;
        return RedirectToPage("AddArticle");
    }
}
