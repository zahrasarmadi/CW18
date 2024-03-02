using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CW18.Model;

public class Article
{
    public int Id { get; set; }
    [DisplayName("عنوان")]
    public string Title { get; set; }
    [DisplayName("عکس مقاله")]
    public string Image { get; set; }
    [DisplayName("توضیحات")]
    public string Description { get; set; }
    public int ReporterId { get; set; }
    [DisplayName("خبرنگار")]
    public Reporter Reporter { get; set; }
    public bool IsConfrim { get; set; }   
    [DisplayName("دسته بندی")]
    public Category Category { get; set; }
    public int CategoryId { get; set; }
    public int VisitCount { get; set; }
    public List<Comment> Comments { get; set;}
}