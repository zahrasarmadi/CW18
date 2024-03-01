using CW18.Model;
using CW18.Ripository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CW18.Areas.ReporterArea.Pages;
public class ArticlesListModel : PageModel
{
    ArticleRepository articleRepo = new ArticleRepository();

    [BindProperty]
    public List<Article> Articles { get; set; } = new List<Article>();
    public void OnGet()
    {
        var articles = articleRepo.GetListArticles();
        foreach (var article in articles)
        {
            if (article.IsConfrime == true)
            {
                Articles.Add(article);
            }
        }
        TempData["null"] = Articles;

    }
}
