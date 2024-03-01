using CW18.Model;
using CW18.Ripository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CW18.Areas.User.Pages
{
    public class SelectedArticleModel : PageModel
    {
        [BindProperty]
        public Article Article { get; set; } = new Article();

        ArticleRepository articleRepo = new ArticleRepository();
        public void OnGet(int id)
        {
            Article = articleRepo.GetArticle(id);
            articleRepo.VisitCounter(id);
        }
    }
}
