using System.ComponentModel;

namespace CW18.Model;

public class CommentViewModel
{
    [DisplayName("عنوان")]
    public string Title { get; set; }
    [DisplayName("متن")]
    public string Description { get; set; }
    [DisplayName("خبر")]
    public Article Article { get; set; }
    public int ArticleId { get; set; }
    [DisplayName("نام کاربر")]
    public string UserName { get; set; }
}
