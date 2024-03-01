using System.ComponentModel;

namespace CW18.Model;

public class Category
{
    public int Id { get; set; }
    [DisplayName("نام")]
    public string Name { get; set; }
    public List<Article> Articles { get; set; }=new List<Article>();
}
