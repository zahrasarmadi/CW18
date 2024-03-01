using CW18.Database;
using CW18.Model;
using CW18.Ripository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CW18.Areas.AdminArea.Pages;

public class RegisterAdminrModel : PageModel
{
    [BindProperty]
    public RegsiterViewModel AdminViewModel { get; set; }

    AdminRipository adminRipository= new AdminRipository();
    public void OnGet()
    {

    }

    public IActionResult OnPost(RegsiterViewModel adminViewModel)
    {
       var admin= new Admin
        {
            FisrtName = adminViewModel.FisrtName,
            LastName = adminViewModel.LastName,
            Password = adminViewModel.Password,
            Email= adminViewModel.Email,
        };
        adminRipository.RegisterAdmin(admin);
        return RedirectToPage("LoginAdmin");
    }
}
