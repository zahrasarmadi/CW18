using CW18.Configuration;
using CW18.Model;
using Microsoft.EntityFrameworkCore;

namespace CW18.Ripository;

public class CategoryRepository
{
   Context context= new Context();

    public List<Category> GetCategories()
    {
        var categories = context.Category.Include(c => c.Articles).ToList() ;
        return categories;
    }

    public Category GetCategory(int id)
    {
        var category = context.Category.FirstOrDefault(x => x.Id == id);
        return category;
    }

    public void AddCategory(Category model)
    {
        context.Category.Add(model);

        context.SaveChanges();
    }

    public void DeleteCategory(int id)
    {
        var category = context.Category.First(x => x.Id == id);
        context.Category.Remove(category);

        context.SaveChanges();
    }

    public void UpdateCategory(Category model)
    {
        var category = context.Category.FirstOrDefault(x => x.Id == model.Id);

        category.Name = model.Name;
        category.Articles = model.Articles;

        context.SaveChanges();
    }
}
