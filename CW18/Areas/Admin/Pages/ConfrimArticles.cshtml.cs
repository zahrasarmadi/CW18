using CW18.Database;
using CW18.Model;
using CW18.Ripository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CW18.Areas.AdminArea.Pages;

public class ConfrimArticlesModel : PageModel
{
    AdminRipository adminRipository = new AdminRipository();

    ArticleRepository ArticleRepository = new ArticleRepository();
    [BindProperty]
    public Admin loginAdmin { get; set; } = StaticDatabase.Admin;

    [BindProperty]
    public List<Article> Articles { get; set; } = new List<Article>();
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

        Articles = ArticleRepository.GetListArticles();
    }

    public IActionResult OnGetConfrim(int id)
    {
        adminRipository.ConfrimArticle(id);
        return Page();
    }
}
