using CW18.Model;
using CW18.Ripository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CW18.Areas.Viewer.Pages;

public class AddCommentModel : PageModel
{
    CommentRipository commentRipository = new CommentRipository();
    ArticleRepository articleRepository = new ArticleRepository();  

    [BindProperty]
    public CommentViewModel Comment { get; set; } = new CommentViewModel();
    public void OnGet(int id)
    {
       var result= articleRepository.GetArticle(id);
        TempData["ArticleId"] = id;
        TempData["Article"] = result;
    }
    public IActionResult OnPost(CommentViewModel comment)
    {
        var result = new Comment()
        {
            UserName = comment.UserName,
            Description = comment.Description,
            Title = comment.Title,
            Article = comment.Article,
            ArticleId = comment.ArticleId,
        };
        commentRipository.AddComment(result);
        return RedirectToPage("Viewer/Index");
    }
}
