using CW18.Model;
using CW18.Ripository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CW18.Areas.ReporterArea.Pages;

public class ViewArticlesModel : PageModel
{
    ArticleRepository articleRepo = new ArticleRepository();

    [BindProperty]
    public List<Article> ArticlesList { get; set; } = new List<Article>();
    public void OnGet()
    {
        var articles = articleRepo.GetListArticles();
        foreach (var article in articles)
        {
            if (article.IsConfrim == true)
            {
                ArticlesList.Add(article);
            }
        }
    }
}
