using CW18.Configuration;
using CW18.Model;
using Microsoft.EntityFrameworkCore;

namespace CW18.Ripository;

public class CommentRipository
{
    Context context = new Context();

    public List<Comment> GetCommentsLit()
    {
        var comments = context.Comment.Include(a => a.Article).ToList();
        return comments;
    }

    public Comment GetComment(int id)
    {
        var comment = context.Comment.Include(a => a.Article).FirstOrDefault(x => x.Id == id);
        return comment;
    }

    public void AddComment(Comment model)
    {
        context.Comment.Add(model);
        context.SaveChanges();
    }

    public void DeleteComment(int id)
    {
        var comment = context.Comment.First(x => x.Id == id);
        context.Comment.Remove(comment);
        context.SaveChanges();
    }

    public void UpdateComment(Comment model)
    {
        var comment = context.Comment.FirstOrDefault(x => x.Id == model.Id);

        comment.Title = model.Title;
        comment.Description = model.Description;
        comment.UserName = model.UserName;
        comment.Article = model.Article;
        comment.ArticleId = model.ArticleId;
        comment.Like= model.Like;
        comment.DisLike= model.DisLike;
        comment.IsConfrim= model.IsConfrim;

        context.SaveChanges();
    }

    public void LikeCounter(int id)
    {
       var targetComment= GetComment(id);
        targetComment.Like++;
        context.SaveChanges();
    }

    public void DisLikeCounter(int id)
    {
        var targetComment = GetComment(id);
        targetComment.DisLike++;
        context.SaveChanges();
    }
}
