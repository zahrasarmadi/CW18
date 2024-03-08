using CW18.Model;
using CW18.Ripository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CW18.Areas.AdminArea.Pages
{
    public class AddCategoryModel : PageModel
    {
        [BindProperty]
        public CategoryViewModel Category { get; set; }

        CategoryRepository categoryRipository=new CategoryRepository();

        public void OnGet() { }

        public IActionResult OnPost(CategoryViewModel category)
        {
            var ccat = new Category()
            {
               Name = category.Name,
            };
            categoryRipository.AddCategory(ccat);
            return RedirectToPage("CategoriesManagement");
        }
    }
}
