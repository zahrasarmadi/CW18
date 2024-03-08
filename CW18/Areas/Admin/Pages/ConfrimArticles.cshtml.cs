using CW18.Database;
using CW18.Model;
using CW18.Ripository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CW18.Areas.AdminArea.Pages;

public class ConfrimArticlesModel : PageModel
{
    AdminRepository adminRipository = new AdminRepository();

    ArticleRepository ArticleRepository = new ArticleRepository();
    [BindProperty]
    //public Admin loginAdmin { get; set; } = StaticDatabase.Admin;

    public List<Article> Articles { get; set; } = new List<Article>();
    public Admin OnlineAdmin { get; set; } = StaticDatabase.Admin;
    public void OnGet()
    {
        Articles = ArticleRepository.GetListArticles();
        if (OnlineAdmin == null)
        {
            TempData["False"] = "False";
        }
    }

    public IActionResult OnGetConfrim(int id)
    {
        adminRipository.ConfrimArticle(id);
        return RedirectToAction("OnGet");
    }
}
