using CW18.Database;
using CW18.Model;
using CW18.Ripository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CW18.Areas.ReporterArea.Pages;
public class RegisterReporterModel : PageModel
{
    [BindProperty]
    public RegsiterViewModel ReporterViewModel { get; set; }

    ReporterRepository reporterRipo= new ReporterRepository();
    public void OnGet()
    {

    }

    public IActionResult OnPost(RegsiterViewModel reporterViewModel)
    {
       var reporter= new Reporter
        {
            FisrtName = reporterViewModel.FisrtName,
            LastName = reporterViewModel.LastName,
            Password = reporterViewModel.Password,
            Email = reporterViewModel.Email,
        };
        reporterRipo.RegisterReporter(reporter);
        return RedirectToPage("LoginReporter");
    }
}
