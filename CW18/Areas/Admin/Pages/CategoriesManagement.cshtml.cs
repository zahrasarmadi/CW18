using CW18.Database;
using CW18.Model;
using CW18.Ripository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CW18.Areas.AdminArea.Pages;

public class CategoriesManagementModel : PageModel
{
    CategoryRipository categoryRipository=new CategoryRipository();
    [BindProperty]
    public List<Category> CategoriesList { get; set; }=new List<Category>();
    [BindProperty]
    public Admin loginAdmin { get; set; } = StaticDatabase.Admin;
    public void OnGet()
    {
        if (loginAdmin != null)
        {
            TempData["true"] = "true";
        }
        else
        {
            TempData["true"] = "false";
        }
        CategoriesList=categoryRipository.GetCategories();
    }

    public void OnGetDelete(int id) 
    {
        categoryRipository.DeleteCategory(id);
    }
}
