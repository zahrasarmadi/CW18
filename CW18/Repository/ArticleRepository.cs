using CW18.Configuration;
using CW18.Model;
using Microsoft.EntityFrameworkCore;

namespace CW18.Ripository;

public class ArticleRepository
{
    Context context = new Context();

    public List<Article> GetListArticles()
    {
        var articles = context.Article.Include(a=>a.Reporter).ToList();
        return articles;
    }

    public Article GetArticle(int id)
    {

        var article = context.Article
            .Include(a=>a.Category)
            .Include(a=>a.Comments)
            .FirstOrDefault(x => x.Id == id);
        return article;
    }

    public void AddArticle(Article model)
    {
        context.Article.Add(model);
        context.SaveChanges();
    }

    public void DeleteArticle(int id)
    {
        var article = context.Article.First(x => x.Id == id);
        context.Article.Remove(article);
        context.SaveChanges();
    }

    public void UpdateArticle(Article model)
    {
        var article = context.Article.FirstOrDefault(x => x.Id == model.Id);

        article.Title = model.Title;
        article.Description = model.Description;
        article.Image = model.Image;
        article.ReporterId = model.ReporterId;
        article.Reporter = article.Reporter;

        context.SaveChanges();
    }

    public void VisitCounter(int id)
    { 
        var targetArticle=context.Article.FirstOrDefault(a=>a.Id == id);
        targetArticle.VisitCount++;
        context.SaveChanges();
    }
}
