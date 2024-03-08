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

        CommentRepository commentRipository= new CommentRepository();

        public void OnGet(int id)
        {
            ViewData["id"] = id;
            Article = articleRepo.GetArticle(id);
            articleRepo.VisitCounter(id);
        }

        public IActionResult OnGetDisLike(int id)
        {
            commentRipository.DisLikeCounter(id);
            var result = commentRipository.GetComment(id);
            return RedirectToPage("SelectedArticle", result);
        }

        public IActionResult OnGetLike(int id)
        {
            commentRipository.LikeCounter(id);
            var result = commentRipository.GetComment(id);
            return RedirectToPage("SelectedArticle", result);
        }
    }
}
