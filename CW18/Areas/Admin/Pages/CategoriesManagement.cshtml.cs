using CW18.Database;
using CW18.Model;
using CW18.Ripository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CW18.Areas.AdminArea.Pages;

public class CategoriesManagementModel : PageModel
{
    [BindProperty]
    public List<Category> CategoriesList { get; set; } = new List<Category>();

    [BindProperty]
    public Admin OnlineAdmin { get; set; } = StaticDatabase.Admin;

    CategoryRepository categoryRipository = new CategoryRepository();

    public void OnGet()
    {
        CategoriesList = categoryRipository.GetCategories();
        if (OnlineAdmin == null)
        {
            TempData["False"] = "False";
        }
    }

    public IActionResult OnGetDelete(int id)
    {
        categoryRipository.DeleteCategory(id);
        return RedirectToAction("OnGet");
    }
}
