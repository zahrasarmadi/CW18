using CW18.Model;
using CW18.Ripository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CW18.Areas.AdminArea.Pages;

public class EditCategoryModel : PageModel
{
    CategoryRepository categoryRipository=new CategoryRepository();
    [BindProperty]
    public Category Category { get; set; }=new Category();
    public void OnGet(int id)
    {
        Category=categoryRipository.GetCategory(id);
    }
    public IActionResult OnPost(Category category)
    {
        categoryRipository.UpdateCategory(category);
        return RedirectToPage("CategoriesManagement");
    }


}
