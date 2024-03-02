using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CW18.Model;

public class Comment
{
    public int Id { get; set; }
    [DisplayName("عنوان")]
    public string Title { get; set; }
    [DisplayName("متن")]
    public string Description { get; set; }
    [DisplayName("خبر")]
    public Article Article { get; set; }
    public int ArticleId { get; set; }
    [DisplayName("نام کاربر")]
    public string UserName { get; set; }
    [DisplayName("لایک")]
    public int Like { get; set; }
    [DisplayName("دیس لایک")]
    public int DisLike { get; set; }
    public bool IsConfrim { get; set; }
}
