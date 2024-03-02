using CW18.Database;
using CW18.Model;
using CW18.Ripository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Metadata;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;


namespace CW18.Areas.ReporterArea.Pages;

public class AddArticleModel : PageModel
{
    [BindProperty]
    public Article Article { get; set; }
    [BindProperty]
    public IFormFile Image { get; set; }
    public List<Category> Categories { get; set; } = new List<Category>();

    ArticleRepository articleRipo = new ArticleRepository();

    CategoryRipository categoryRipo = new CategoryRipository();
    public Reporter OnlineReporter { get; set; } = StaticDatabase.Reporter;
    public void OnGet()
    {
        Categories = categoryRipo.GetCategories();
        if (OnlineReporter == null)
        {
            TempData["False"] = "False";
        }
    }
    public IActionResult OnPost(Article article, IFormFile Image)
    {

        if (Image != null && Image.Length > 0)
        {
            var filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/uploads", Image.FileName);
            var filePath2 = "../uploads/" + Image.FileName;
            using (var stream = new FileStream(filePath, FileMode.Create))
            {
                Image.CopyToAsync(stream);
            }
            article.Image = filePath2;
            article.ReporterId = StaticDatabase.Reporter.Id;
            article.Id = 0;
            articleRipo.AddArticle(article);
            return RedirectToPage("ViewArticles");
        }

        return Page();
    }
}

