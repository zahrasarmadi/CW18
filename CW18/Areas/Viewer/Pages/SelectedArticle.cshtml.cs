using CW18.Model;
using CW18.Ripository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CW18.Areas.Viewer.Pages
{
    public class SelectedArticleModel : PageModel
    {
        [BindProperty]
        public Article Article { get; set; } = new Article();

        ArticleRepository articleRepo = new ArticleRepository();

        CommentRipository commentRipository= new CommentRipository();
        public void OnGet(int id)
        {
            ViewData["id"] = id;
            Article = articleRepo.GetArticle(id);
            articleRepo.VisitCounter(id);
        }
        public IActionResult OnGetDisLike(int id)
        {
            commentRipository.DisLikeCounter(id);
            var res = commentRipository.GetComment(id);
            var res2 = res.ArticleId;
            return RedirectToPage("SelectedArticle", res);
        }

        public IActionResult OnGetLike(int id)
        {
            commentRipository.LikeCounter(id);
            var res = commentRipository.GetComment(id);
            var res2 = res.ArticleId;
            return RedirectToPage("SelectedArticle", res);
        }
    }
}
